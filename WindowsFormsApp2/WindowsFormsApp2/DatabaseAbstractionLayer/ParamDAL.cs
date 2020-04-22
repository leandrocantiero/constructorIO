using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    class ParamDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = null;
        DatabaseAbstractionLayer.ContatoDAL contatoDAL = null;

        public ParamDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();

            enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
            contatoDAL = new DatabaseAbstractionLayer.ContatoDAL();
        }

        public bool inserir(Model.Param param)
        {
            bool sucesso;
            var parametrosBD = bd.getParams();
            string sql;

            if (param.getCod() == 0)
            {
                sql = @"insert into parametro(razaoSocial, fantasia, cnpj, inscEstadual, cod_endereco, cod_contato)
						values 
                            (@razaoSocial, 
                            @fantasia,
                            @cnpj,
                            @inscEstadual, 
                            @cod_endereco, 
                            @cod_contato
                        ) RETURNING PES_COD;";
            }
            else
            {
                sql = @"update parametro 
                        set 
                            razaoSocial = @razaoSocial,
                            fantasia = @fantasia,
                            cnpj = @cnpj,
                            inscEstadual = @inscEstadual, 
                            cod_endereco = @cod_endereco, 
                            cod_contato = @cod_contato 
                        where pes_cod = @pes_cod RETURNING PES_COD;";
            }

            parametrosBD.Add("@razaoSocial", param.getRazaoSocial());
            parametrosBD.Add("@fantasia", param.getFantasia());
            parametrosBD.Add("@cnpj", param.getCnpj());
            parametrosBD.Add("@inscEstadual", param.getInscEstadual());

            try
            {
                // cria novos obj para atualizar o "COD" por referência;
                Model.Endereco endereco = param.getEndereco();
                Model.Contato contato = param.getContato();

                // inserir na tabelas que faz referência a tabela parametro
                sucesso = enderecoDAL.inserir(endereco);

                if (sucesso)
                    sucesso = contatoDAL.inserir(contato);
                if (sucesso)
                {
                    // atualizar obj "Model.parametro parametro"
                    param.setEndereco(endereco);
                    param.setContato(contato);

                    // add as fk
                    parametrosBD.Add("@cod_endereco", param.getEndereco().getCod());
                    parametrosBD.Add("@cod_contato", param.getContato().getCod());


                    // inserir de fato o "parametro" ja com os objetos atualizados
                    sucesso = bd.executeNonQuery(sql, parametrosBD);
                    param.setCod(bd.getUltimoCod());
                }
            }
            catch (Exception)
            {
                sucesso = false;
            }

            return sucesso;
        }

        public bool remover(int cod)
        {
            bool sucesso;

            var param = bd.getParams();
            string sql = @"delete from parametro  
                           where cod = @cod RETURNING cod;";

            param.Add("@cod", cod);

            try
            {
                Model.Param parametro = this.obterUm(cod);
                if (parametro != null)
                {
                    // remover na tabelas que faz referência a tabela parametro

                    sucesso = bd.executeNonQuery(sql, param);

                    if (sucesso)
                        sucesso = enderecoDAL.remover(parametro.getEndereco().getCod());
                    if (sucesso)
                        sucesso = contatoDAL.remover(parametro.getContato().getCod());
                }
                else
                {
                    sucesso = false;
                    MessageBox.Show("Há registro associados.");
                }
            }
            catch (Exception)
            {
                sucesso = false;
                MessageBox.Show("Problema no banco");
            }

            return sucesso;
        }

        public Model.Param obterUm(int cod)
        {
            Model.Param parametro = null;
            var param = bd.getParams();

            string sql = @"select 
                                cod, 
                                razaoSocial,
                                fantasia,
                                cnpj,
                                inscEstadual, 
                                cod_endereco, 
                                cod_contato
                           from parametro 
                           where cod = @cod";

            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    parametro = map(dt.Rows[0]);
                }
            }
            catch (Exception)
            {

            }

            return parametro;
        }

        internal Model.Param map(DataRow row)
        {
            Model.Param parametro = new Model.Param();
            Model.Endereco endereco = null;
            Model.Contato contato = null;

            endereco = enderecoDAL.obterUm(Convert.ToInt32(row["cod_endereco"]));
            contato = contatoDAL.obterUm(Convert.ToInt32(row["cod_contato"]));

            parametro.setEndereco(endereco);
            parametro.setContato(contato);

            parametro.setCod(Convert.ToInt32(row["cod"]));

            try
            {
                parametro.setCod(Convert.ToInt16(row["cod"]));
            }
            catch (Exception)
            {
                parametro.setCod(0);
            }

            parametro.setRazaoSocial(row["razaoSocial"].ToString());
            parametro.setFantasia(row["fantasia"].ToString());
            parametro.setCnpj(row["cnpj"].ToString());
            parametro.setInscEstadual(row["inscEstadual"].ToString());

            return parametro;
        }
    }
}

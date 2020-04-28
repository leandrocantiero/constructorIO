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


            if (obterQuantidade() == 0)
            {
                sql = @"insert into parametro(razao, fantasia, cnpj, inscricao_estadual, logo_menor, logo_maior, email, site, cod_endereco, cod_contato)
						values 
                            (@razao, 
                            @fantasia,
                            @cnpj,
                            @inscricao_estadual, 
                            @logo_menor,
                            @logo_maior,
                            @email,
                            @site,
                            @cod_endereco, 
                            @cod_contato
                        ) RETURNING cod;";
            }
            else
            {
                sql = @"update parametro 
                        set 
                            razao = @razao,
                            fantasia = @fantasia,
                            cnpj = @cnpj,
                            inscricao_estadual = @inscricao_estadual,
                            @logo_menor,
                            @logo_maior,
                            @email,
                            @site,
                            cod_endereco = @cod_endereco, 
                            cod_contato = @cod_contato 
                        where cnpj = @cnpj RETURNING cod;";
            }

            parametrosBD.Add("@razao", param.getRazaoSocial());
            parametrosBD.Add("@fantasia", param.getFantasia());
            parametrosBD.Add("@cnpj", param.getCnpj());
            parametrosBD.Add("@inscricao_estadual", param.getInscEstadual());
            parametrosBD.Add("@logo_menor", param.getLogoMenor());
            parametrosBD.Add("@logo_maior", param.getLogoMaior());
            parametrosBD.Add("@email", param.getEmail());
            parametrosBD.Add("@site", param.getSite());

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
                }
            }
            catch (Exception)
            {
                sucesso = false;
            }

            return sucesso;
        }

        public bool remover(string cnpj)
        {
            bool sucesso;

            var param = bd.getParams();
            string sql = @"delete from parametro  
                           where cnpj = @cnpj RETURNING cod;";

            param.Add("@cnpj", cnpj);

            try
            {
                Model.Param parametro = this.obterUm(cnpj);
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

        public Model.Param obterUm(string cnpj)
        {
            Model.Param parametro = null;
            var param = bd.getParams();

            string sql = @"select *
                           from parametro 
                           where cnpj = @cnpj";

            param.Add("@cnpj", cnpj);

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

        public int obterQuantidade()
        {
            string sql = @"select count(*) as quantidade_params from parametro;";

            int quantidade=0;

            try
            {
                DataTable dt = bd.executeSelect(sql);

                if (dt.Rows.Count > 0)
                {
                    quantidade = Convert.ToInt32(dt.Rows[0]["quantidade_params"]);
                }
            }
            catch (Exception ex)
            {
                quantidade = 0;
            }

            return quantidade;
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

            parametro.setRazaoSocial(row["razao"].ToString());
            parametro.setFantasia(row["fantasia"].ToString());
            parametro.setCnpj(row["cnpj"].ToString());
            parametro.setInscEstadual(row["inscricao_estadual"].ToString());
            parametro.setLogoMenor(row["logo_menor"].ToString());
            parametro.setLogoMaior(row["logo_maior"].ToString());
            parametro.setEmail(row["email"].ToString());
            parametro.setSite(row["site"].ToString());

            return parametro;
        }
    }
}

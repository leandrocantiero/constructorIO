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
                            logo_menor = @logo_menor,
                            logo_maior = @logo_maior,
                            email = @email,
                            site = @site,
                            cod_endereco = @cod_endereco, 
                            cod_contato = @cod_contato 
                        where cnpj = @cnpj RETURNING 0;";
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

        public Model.Param obterParam()
        {
            Model.Param parametro = null;

            string sql = @"select * from parametro";

            try
            {
                DataTable dt = bd.executeSelect(sql);

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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class EnderecoDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public EnderecoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.Endereco endereco)
        {
            bool sucesso;
            var param = bd.getParams();
            string sql;

            if (endereco.getCod() == 0)
            {
                sql = @"insert into endereco 
                        (cep, logradouro, rua, numero, bairro, cod_cidade) 
                        values (@cep, @logradouro, @rua, @numero, @bairro, @cod_cidade) RETURNING COD;";
            }
            else
            {
                sql = @"update endereco 
                        set 
                           cep=@cep, 
                            logradouro=@logradouro, 
                            rua=@rua, numero=@numero, 
                            bairro=@bairro, 
                            cod_cidade=@cod_cidade 
                        where cod = @cod RETURNING COD;";
            }

            param.Add("@cod", endereco.getCod());
            param.Add("@cep", endereco.getCep());
            param.Add("@logradouro", endereco.getLogradouro());
            param.Add("@rua", endereco.getRua());
            param.Add("@numero", endereco.getNumero());
            param.Add("@bairro", endereco.getBairro());
            param.Add("@cod_cidade", endereco.getCidade().getCod());

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
                endereco.setCod(bd.getUltimoCod());
            }
            catch(Exception ex)
            {
                sucesso = false;
            }

            return sucesso;
        }

        public bool remover(int cod)
        {
            bool sucesso;

            var param = bd.getParams();
            string sql = @"delete from endereco 
                           where cod = @cod RETURNING COD;";

            param.Add("@cod", cod);

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
            }
            catch(Exception ex)
            {
                sucesso = false;
            }

            return sucesso;
        }



        public List<Model.Endereco> obterTodos()
        {
            List<Model.Endereco> enderecos = null;
            var param = bd.getParams();
            string sql = @"select 
                                endereco.cod as end_cod, 
                                cep,
                                logradouro,
                                rua,
                                numero,
                                bairro,
                                cidade.cod as cid_cod,
                                cidade.nome as cid_nome,
                                estado.uf as est_uf,
                                estado.nome as est_nome 
                           from endereco, cidade, estado  
                           where 
                                cod_cidade = cidade.cod and
                                cidade.uf_estado = estado.uf";

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    enderecos = new List<Model.Endereco>();

                    foreach (DataRow row in dt.Rows)
                    {
                        enderecos.Add(map(row));
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return enderecos;
        }

        public Model.Endereco obterUm(int cod)
        {
            Model.Endereco endereco = null;
            var param = bd.getParams();

            string sql = @"select 
                                endereco.cod as end_cod, 
                                cep,
                                logradouro,
                                rua,
                                numero,
                                bairro,
                                cidade.cod as cid_cod,
                                cidade.nome as cid_nome,
                                estado.uf as est_uf,
                                estado.nome as est_nome 
                           from endereco, cidade, estado  
                           where 
                                cod_cidade = cidade.cod and
                                cidade.uf_estado = estado.uf and 
                                endereco.cod = @cod";

            param.Add("@cod", cod);
            
            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if(dt.Rows.Count > 0)
                {
                    endereco = map(dt.Rows[0]);
                }
            }
            catch(Exception ex)
            {

            }

            return endereco;
        }

        internal Model.Endereco map(DataRow row)
        {
            Model.Endereco endereco = new Model.Endereco();
            Model.Cidade cidade = new Model.Cidade();
            Model.Estado estado = new Model.Estado();


            estado.setUf(row["est_uf"].ToString());
            estado.setNome(row["est_nome"].ToString());

            cidade.setCod(Convert.ToInt32(row["cid_cod"]));
            cidade.setNome(row["cid_nome"].ToString());
            cidade.setEstado(estado);

            endereco.setCod(Convert.ToInt32(row["end_cod"]));
            endereco.setCep(row["cep"].ToString());
            endereco.setLogradouro(row["logradouro"].ToString());
            endereco.setRua(row["rua"].ToString());
            endereco.setNumero(Convert.ToInt32(row["numero"]));
            endereco.setBairro(row["bairro"].ToString());
            endereco.setCidade(cidade);

            return endereco;
        }
    }
}

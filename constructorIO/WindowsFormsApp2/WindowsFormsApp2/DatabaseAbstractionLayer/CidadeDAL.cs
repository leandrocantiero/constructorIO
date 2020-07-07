using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class CidadeDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public CidadeDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public List<Model.Cidade> obterTodos(string uf)
        {
            List<Model.Cidade> cidades = null;
            var param = bd.getParams();

            string sql = @"select 
                                cod, 
                                cidade.nome as cid_nome,
                                estado.uf as est_uf, 
                                estado.nome as est_nome 
                           from 
                                cidade, estado 
                           where 
                                cidade.uf_estado = estado.uf and
                                cidade.uf_estado = @uf;";

            param.Add("@uf", uf);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if(dt.Rows.Count > 0)
                {
                    cidades = new List<Model.Cidade>();

                    foreach(DataRow row in dt.Rows)
                    {
                        cidades.Add(map(row));
                    }

                }
            }
            catch(Exception)
            {

            }

            return cidades;
        }

        public Model.Cidade obterUm(int cod)
        {
            Model.Cidade cidade = null;
            var param = bd.getParams();

            string sql = @"select 
                                cod, 
                                cidade.nome as cid_nome,
                                estado.uf as est_uf, 
                                estado.nome as est_nome 
                           from 
                                cidade, estado 
                           where 
                                cidade.uf_estado = estado.uf and
                                cidade.cod = @cod;";

            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    cidade = map(dt.Rows[0]);
                }
            }
            catch (Exception)
            {

            }

            return cidade;
        }

        internal Model.Cidade map(DataRow row)
        {
            Model.Cidade cidade = new Model.Cidade();
            Model.Estado estado = new Model.Estado();

            estado.setUf(row["est_uf"].ToString());
            estado.setNome(row["est_nome"].ToString());

            cidade.setCod(Convert.ToInt32(row["cod"]));
            cidade.setNome(row["cid_nome"].ToString());
            cidade.setEstado(estado);


            return cidade;
        }
    }
}

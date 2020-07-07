using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ServicoDAL
    {

        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public ServicoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public List<Model.Servico> obterTodas(string nome = null)
        {
            List<Model.Servico> servicos = null;
            string sql = @"select 
                                cod, 
                                nome, 
                                quant_homem, 
                                observacao
                           from servico ";
            var param = bd.getParams();


            if (nome != null)
            {
                sql += " where ";
                sql += " nome like @nome ";
                param.Add("@nome", "%" + nome + "%");
            }

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    servicos = new List<Model.Servico>();

                    foreach (DataRow row in dt.Rows)
                    {
                        servicos.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return servicos;
        }

        public Model.Servico obterUm(int cod)
        {
            Model.Servico servico = null;
            string sql = @"select 
                                cod, 
                                nome, 
                                quant_homem, 
                                observacao
                            from servico 
                            where cod=@cod;";
            
            var param = bd.getParams();
            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count == 1)
                {
                    servico = map(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {

            }


            return servico;
        }

        internal Model.Servico map(DataRow row)
        {
            Model.Servico servico = new Model.Servico();

            servico.setCod(Convert.ToInt32(row["cod"]));
            servico.setNome(row["nome"].ToString());
            servico.setQuantidadeHomem(Convert.ToInt32(row["quant_homem"]));
            servico.setObservacao(row["observacao"].ToString());

            return servico;
        }
    }
}

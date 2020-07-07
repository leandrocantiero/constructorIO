using System;
using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public  class StatusDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public StatusDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }


        public List<Model.Status> obterTodos()
        {
            List<Model.Status> status = null;
            string sql = @"select cod, descricao
                           from status;";

            try
            {
                DataTable dt = bd.executeSelect(sql);

                if (dt.Rows.Count > 0)
                {
                    status = new List<Model.Status>();

                    foreach (DataRow row in dt.Rows)
                    {
                        status.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return status;
        }

        public Model.Status obterUm(string descricao)
        {
            Model.Status status = null;
            string sql = @"select cod, descricao
                           from status 
                          where descricao=@descricao;";

            var param = bd.getParams();
            param.Add("@descricao", descricao);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    status = map(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {

            }

            return status;
        }

        internal Model.Status map(DataRow row)
        {
            Model.Status status = new Model.Status();

            status.setCod(Convert.ToInt32(row["cod"]));
            status.setDescricao(row["descricao"].ToString());

            return status;
        }
    }
}
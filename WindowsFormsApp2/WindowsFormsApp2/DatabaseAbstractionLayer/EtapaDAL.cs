using System;
using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class EtapaDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public EtapaDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public List<Model.Etapa> obterTodas(string nome = null)
        {
            List<Model.Etapa> etapas = null;
            string sql = @"select * from etapa ";
            var param = bd.getParams();

            if (nome != null)
            {
                sql += " where ";
                sql += " descricao like @descricao";
                param.Add("@descricao", "%" + nome + "%");

            }

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    etapas = new List<Model.Etapa>();

                    foreach (DataRow row in dt.Rows)
                    {
                        etapas.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return etapas;
        }

        internal Model.Etapa map(DataRow row)
        {
            Model.Etapa etapa= new Model.Etapa();
            etapa.Cod = Convert.ToInt32(row["cod"]);
            etapa.Descricao = row["descricao"].ToString();

            return etapa;
        }
    }
}
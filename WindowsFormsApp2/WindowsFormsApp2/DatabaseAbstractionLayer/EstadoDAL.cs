using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class EstadoDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public EstadoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public List<Model.Estado> obterTodos()
        {
            List<Model.Estado> estados = null;
            string sql = @"select * from estado;";
            DataTable dt = bd.executeSelect(sql);

            if(dt.Rows.Count > 0)
            {
                estados = new List<Model.Estado>();
                
                foreach(DataRow row in dt.Rows)
                {
                    estados.Add(map(row));
                }
            }

            return estados;
        }

        internal Model.Estado map(DataRow row)
        {
            Model.Estado estado = new Model.Estado();
            estado.setNome(row["nome"].ToString());
            estado.setUf(row["uf"].ToString());

            return estado;
        }
    }
}

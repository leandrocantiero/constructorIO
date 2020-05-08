using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ObraDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;
        DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = null;

        public ObraDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();

            // DALs auxiliares para (obter, remover e etc) os funcionarios
            enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
        }

        //public bool inserir(Model.Obra obra)
        //{
        //    bool operacao = false;
        //    string sql = "";




        //}
    }
}

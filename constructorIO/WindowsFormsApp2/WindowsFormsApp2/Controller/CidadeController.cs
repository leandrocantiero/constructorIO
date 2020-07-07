using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class CidadeController
    {

        public List<object> obterTodos(string uf)
        {
            DatabaseAbstractionLayer.CidadeDAL cidadeDAL = null;
            List<Model.Cidade> cidades = null;

            if (uf != null )
            {
                cidadeDAL = new DatabaseAbstractionLayer.CidadeDAL();
                cidades = cidadeDAL.obterTodos(uf);
            }
            
            return new List<object>(cidades);
        }
    }
}

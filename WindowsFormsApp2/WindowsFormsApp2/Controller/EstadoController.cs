using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class EstadoController
    {
        public List<object> obterTodos()
        {
            DatabaseAbstractionLayer.EstadoDAL estadoDAL = new DatabaseAbstractionLayer.EstadoDAL();

            List<Model.Estado> estados = estadoDAL.obterTodos();

            return new List<object>(estados);
        }
    }
}

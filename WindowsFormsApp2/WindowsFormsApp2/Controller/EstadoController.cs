using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class EstadoController
    {
        public List<Model.Estado> obterTodos()
        {
            DatabaseAbstractionLayer.EstadoDAL estadoDAL = new DatabaseAbstractionLayer.EstadoDAL();

            List<Model.Estado> estados = estadoDAL.obterTodos();

            return estados;
        }
    }
}

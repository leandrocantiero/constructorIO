using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class MaterialController
    {
        public List<object> obterTodos(string nome = null)
        {
            DatabaseAbstractionLayer.MaterialDAL materialDAL = new DatabaseAbstractionLayer.MaterialDAL();
            List<Model.Material> materiais = materialDAL.obterTodas(nome);

            if(materiais == null)
            {
                return new List<object>();
            }
            return new List<object>(materiais);
        }

        public Model.Material obterUm(int codMaterial)
        {
            DatabaseAbstractionLayer.MaterialDAL materialDAL = new DatabaseAbstractionLayer.MaterialDAL();
            Model.Material material = materialDAL.obterUm(codMaterial);

            return material;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class ServicoController
    {
        public List<object> obterTodos(string nome = null)
        {
            DatabaseAbstractionLayer.ServicoDAL servicoDAL = new DatabaseAbstractionLayer.ServicoDAL();
            List<Model.Servico> servicos = servicoDAL.obterTodas(nome);

            if (servicos == null)
            {
                return new List<object>();
            }
            return new List<object>(servicos);
        }
    }
}

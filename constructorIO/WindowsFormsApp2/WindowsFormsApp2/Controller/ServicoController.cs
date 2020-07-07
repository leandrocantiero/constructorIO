using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class ServicoController
    {
        public List<Model.Servico> obterTodos(string nome = null)
        {
            DatabaseAbstractionLayer.ServicoDAL servicoDAL = new DatabaseAbstractionLayer.ServicoDAL();
            List<Model.Servico> servicos = servicoDAL.obterTodas(nome);

            if (servicos == null)
            {
                return new List<Model.Servico>();
            }
            return new List<Model.Servico>(servicos);
        }
    }
}

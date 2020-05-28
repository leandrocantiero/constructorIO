using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Controller
{
    public class ControllerConsumoMaterialServico
    {
        public void cadastrar(Model.Obra obraTela, List<Model.ConsumoMaterial> consumoMateriais, List<Model.ConsumoServico> consumoServicos, DateTime data)
        {
            DatabaseAbstractionLayer.MaterialDAL materialDAL = new DatabaseAbstractionLayer.MaterialDAL();
            DatabaseAbstractionLayer.ConsumoMaterialDAL consumoMaterialDAL = new DatabaseAbstractionLayer.ConsumoMaterialDAL();
            DatabaseAbstractionLayer.ConsumoServicoDAL consumoServicoDAL = new DatabaseAbstractionLayer.ConsumoServicoDAL();
            DatabaseAbstractionLayer.ConsumoMaterialServicoDAL materialServicoDAL = new DatabaseAbstractionLayer.ConsumoMaterialServicoDAL();
            Model.Material materialBuscado = null;
            Model.ConsumoMaterialServico consumoMaterialServico = new Model.ConsumoMaterialServico();


            consumoMaterialServico.setObra(obraTela);
            consumoMaterialServico.setData(data);
            if(materialServicoDAL.inserir(consumoMaterialServico))
            {
                if(consumoMateriais != null) {
                    foreach (var material in consumoMateriais)
                    {
                        //decrementar estoque
                        materialBuscado = materialDAL.obterUm(material.getMaterial().getCod());
                        materialBuscado.setEstoque(materialBuscado.getEstoque() - material.getQuantidadeMaterial());
                        materialDAL.atualizar(materialBuscado);

                        //inserir
                        material.setConsumoMaterialServico(consumoMaterialServico);
                        material.setData(data);

                        consumoMaterialDAL.inserir(material);
                    }
                }

                if(consumoServicos != null)
                {
                    foreach (var servico in consumoServicos)
                    {
                        //inserir
                        servico.setData(data);
                        servico.setConsumoMaterialServico(consumoMaterialServico);
                        consumoServicoDAL.inserir(servico);
                    }
                }
            }
        }

        public List<Model.ConsumoMaterialServico> obterTodos(DateTime data, bool isDate)
        {
            List<Model.ConsumoMaterialServico> consumoMaterialServicos = new List<ConsumoMaterialServico>();
            DatabaseAbstractionLayer.ConsumoMaterialServicoDAL consumoMaterialServicoDAL = new DatabaseAbstractionLayer.ConsumoMaterialServicoDAL();
            DatabaseAbstractionLayer.ConsumoMaterialDAL consumoMaterialDAL = new DatabaseAbstractionLayer.ConsumoMaterialDAL();
            DatabaseAbstractionLayer.ConsumoServicoDAL consumoServicoDAL = new DatabaseAbstractionLayer.ConsumoServicoDAL();


            consumoMaterialServicos = consumoMaterialServicoDAL.obterTodos(data, isDate);

            foreach(var cms in consumoMaterialServicos)
            {
                cms.setMateriais(consumoMaterialDAL.obterTodosByConsumoMatServ(cms.getCod()));
                cms.setServicos(consumoServicoDAL.obterTodosByConsumoMatServ(cms.getCod()));
            }

            return consumoMaterialServicos;
        }

        public Model.ConsumoServico getConsumoServico()
        {
            return new Model.ConsumoServico();
        }

        public  ConsumoMaterial getConsumoMaterial()
        {
            return new Model.ConsumoMaterial();
        }

        internal bool removerMatServTela(int codConsumoMatServ)
        {
            DatabaseAbstractionLayer.ConsumoMaterialServicoDAL consumoMaterialServicoDAL = 
                new DatabaseAbstractionLayer.ConsumoMaterialServicoDAL();

            DatabaseAbstractionLayer.ConsumoMaterialDAL consumoMaterialDAL = new DatabaseAbstractionLayer.ConsumoMaterialDAL();
            DatabaseAbstractionLayer.ConsumoServicoDAL consumoServicoDAL = new DatabaseAbstractionLayer.ConsumoServicoDAL();

            consumoMaterialDAL.remover(codConsumoMatServ);
            consumoServicoDAL.remover(codConsumoMatServ);

            return consumoMaterialServicoDAL.remover(codConsumoMatServ);
        }
    }
}

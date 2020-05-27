using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Controller
{
    public class ControllerConsumoMaterialServico
    {
        public void cadastrar(Model.Obra obraTela, Model.Tarefa tarefa, 
            List<Model.Material> materiais, List<Model.ConsumoServico> consumoServicos, DateTime data)
        {
            DatabaseAbstractionLayer.MaterialDAL materialDAL = new DatabaseAbstractionLayer.MaterialDAL();
            DatabaseAbstractionLayer.ConsumoMaterialDAL consumoMaterialDAL = new DatabaseAbstractionLayer.ConsumoMaterialDAL();
            DatabaseAbstractionLayer.ConsumoServicoDAL consumoServicoDAL = new DatabaseAbstractionLayer.ConsumoServicoDAL();
            DatabaseAbstractionLayer.ConsumoMaterialServicoDAL materialServicoDAL = new DatabaseAbstractionLayer.ConsumoMaterialServicoDAL();
            Model.Material materialBuscado = null;
            Model.ConsumoMaterialServico consumoMaterialServico = new Model.ConsumoMaterialServico();


            consumoMaterialServico.setObra(obraTela);
            consumoMaterialServico.setTarefa(tarefa);
            consumoMaterialServico.setData(data);
            if(materialServicoDAL.inserir(consumoMaterialServico))
            {
                if(materiais != null) {
                    foreach (var material in materiais)
                    {
                        materialBuscado = materialDAL.obterUm(material.getCod());
                        materialBuscado.setEstoque(materialBuscado.getEstoque() - material.getEstoque());

                        materialDAL.atualizar(materialBuscado);

                        Model.ConsumoMaterial consumoMaterial = new Model.ConsumoMaterial();
                        consumoMaterial.setConsumoMaterialServico(consumoMaterialServico);
                        consumoMaterial.setMaterial(material);
                        consumoMaterial.setQuantidadeMaterial(material.getEstoque());
                        consumoMaterial.setData(DateTime.Now);

                        consumoMaterialDAL.inserir(consumoMaterial);
                    }
                }

                if(consumoServicos != null)
                {
                    foreach (var servico in consumoServicos)
                    {
                        servico.setData(DateTime.Now);
                        servico.setConsumoMaterialServico(consumoMaterialServico);
                        consumoServicoDAL.inserir(servico);
                    }
                }
            }
        }

        public Model.ConsumoServico getConsumoServico()
        {
            return new Model.ConsumoServico();
        }
    }
}

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
        public void cadastrar(Model.ConsumoMaterialServico consumoMaterialServico, 
            List<Model.Material> materiais, List<Model.ConsumoServico> servicos)
        {
            DatabaseAbstractionLayer.MaterialDAL materialDAL = new DatabaseAbstractionLayer.MaterialDAL();
            DatabaseAbstractionLayer.ConsumoMaterialDAL consumoMaterialDAL = new DatabaseAbstractionLayer.ConsumoMaterialDAL();
            DatabaseAbstractionLayer.ConsumoServicoDAL consumoServicoDAL = new DatabaseAbstractionLayer.ConsumoServicoDAL();
            DatabaseAbstractionLayer.ConsumoMaterialServicoDAL materialServicoDAL = new DatabaseAbstractionLayer.ConsumoMaterialServicoDAL();
            Model.Material materialBuscado = null;

            if (materiais.Count == 0 || servicos.Count == 0)
            {
                MessageBox.Show("Escolha pelo menos um serviço ou material.");
                return;
            }

            materialServicoDAL.inserir(consumoMaterialServico);

            foreach(var material in materiais)
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

            foreach(var servico in servicos)
            {
                servico.setData(DateTime.Now);
                consumoServicoDAL.inserir(servico);
            }
        }
    }
}

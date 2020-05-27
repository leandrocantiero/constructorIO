using System;

namespace WindowsFormsApp2.Model
{
    public class ConsumoMaterial
    {
        private int _quantidadeMaterial;
        private Model.Material _material;
        private Model.ConsumoMaterialServico _consumoMaterialServico;

        public void setQuantidadeMaterial(int quantidadeMaterial)
        {
            this._quantidadeMaterial = quantidadeMaterial;
        }

        public int getQuantidadeMaterial()
        {
            return this._quantidadeMaterial;
        }

        public void setMaterial(Model.Material material)
        {
            this._material = material;
        }

        public Model.Material getMaterial()
        {
            return this._material;
        }

        public void setConsumoMaterialServico(Model.ConsumoMaterialServico consumoMaterialServico)
        {
            this._consumoMaterialServico = consumoMaterialServico;
        }

        public Model.ConsumoMaterialServico getConsumoMaterialServico()
        {
            return this._consumoMaterialServico;
        }
    }
}
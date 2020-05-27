using System;

namespace WindowsFormsApp2.Model
{
    public class ConsumoMaterial
    {
        private int _quantidadeMaterial;
        private Model.Material _material;
        private Model.ConsumoMaterialServico _consumoMaterialServico;
        private DateTime _data;


        public DateTime Data { get => _data; set => _data = value; }
        public int QuantidadeMaterial { get => _quantidadeMaterial; set => _quantidadeMaterial = value; }
        public Material Material { get => _material; set => _material = value; }
        public ConsumoMaterialServico ConsumoMaterialServico { get => _consumoMaterialServico; set => _consumoMaterialServico = value; }

        public void setData(DateTime data)
        {
            this._data = data;
        }

        public DateTime getData()
        {
            return this._data;
        }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class ConsumoServico
    {
        private Model.Servico _servico;
        private int _quantidadeHomem;
        private int _metrosQuadrados;
        private Model.ConsumoMaterialServico _consumoMaterialServico;


        public int QuantidadeHomem { get => _quantidadeHomem; set => _quantidadeHomem = value; }
        public int MetrosQuadrados { get => _metrosQuadrados; set => _metrosQuadrados = value; }
        public Servico Servico { get => _servico; set => _servico = value; }
        public ConsumoMaterialServico ConsumoMaterialServico { get => _consumoMaterialServico; set => _consumoMaterialServico = value; }

        public void setConsumoMaterialServico(Model.ConsumoMaterialServico consumoMaterialServico)
        {
            this._consumoMaterialServico = consumoMaterialServico;
        }

        public Model.ConsumoMaterialServico getConsumoMaterialServico()
        {
            return this._consumoMaterialServico;
        }


        public void setServico(Model.Servico servico)
        {
            this._servico = servico;
        }

        public Model.Servico getServico()
        {
            return this._servico;
        }

        public void setQuantidadeHomem(int quantidadeHomem)
        {
            this._quantidadeHomem = quantidadeHomem;
        }

        public int getQuantidadeHomem()
        {
            return this._quantidadeHomem;
        }

        public void setMetrosQuadrados(int metrosQuadrados)
        {
            this._metrosQuadrados = metrosQuadrados;
        }

        public int getMetrosQuadrados()
        {
            return this._metrosQuadrados;
        }
    }
}

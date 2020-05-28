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
        private decimal _metrosQuadrados;
        private DateTime _data;
        private Model.ConsumoMaterialServico _consumoMaterialServico;
        private Model.Tarefa _tarefa;


        public int QuantidadeHomem { get => _quantidadeHomem; set => _quantidadeHomem = value; }
        public decimal MetrosQuadrados { get => _metrosQuadrados; set => _metrosQuadrados = value; }
        public Servico Servico { get => _servico; set => _servico = value; }
        public ConsumoMaterialServico ConsumoMaterialServico { get => _consumoMaterialServico; set => _consumoMaterialServico = value; }
        public DateTime Data { get => _data; set => _data = value; }

        public Tarefa Tarefa { get => _tarefa; set => _tarefa = value; }

        public void setTarefa(Model.Tarefa tarefa)
        {
            this._tarefa = tarefa;
        }

        public Model.Tarefa getTarefa()
        {
            return this._tarefa;
        }

        public void setData(DateTime data)
        {
            this._data = data;
        }

        public DateTime getData()
        {
            return this._data;
        }


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

        public void setMetrosQuadrados(decimal metrosQuadrados)
        {
            this._metrosQuadrados = metrosQuadrados;
        }

        public decimal getMetrosQuadrados()
        {
            return this._metrosQuadrados;
        }

        /// <summary>
        /// USADO PARA MOSTRAR NA GRID. NAO DELETE ISSO
        /// </summary>
        /// 

        private string _MostraTelaEtapa;
        public string MostraTelaEtapa { get => _MostraTelaEtapa; set => _MostraTelaEtapa = value; }
    }
}

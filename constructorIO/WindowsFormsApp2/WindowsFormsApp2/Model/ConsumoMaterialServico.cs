using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class ConsumoMaterialServico
    {
        private int _cod;
        private DateTime _data;
        private Model.Obra _obra;


        private List<Model.ConsumoServico> _consumoServicoLista;
        private List<Model.ConsumoMaterial> _consumoMaterialLista;

        public ConsumoMaterialServico()
        {
            this._consumoMaterialLista = null;
            this._consumoServicoLista = null;
        }

        public int Cod { get => _cod; set => _cod = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public Obra Obra { get => _obra; set => _obra = value; }

        public void setCod(int cod)
        {
            this._cod = cod;
        }

        public int getCod()
        {
            return this._cod;
        }

        public void setCod(DateTime data)
        {
            this._data = data;
        }

        public DateTime getData()
        {
            return this._data;
        }

        public void setData(DateTime data)
        {
            this._data = data;
        }

        public void setObra(Model.Obra obra)
        {
            this._obra = obra;
        }

        public Model.Obra getObra()
        {
            return this._obra;
        }

        public List<Model.ConsumoMaterial> getMateriais()
        {
            return this._consumoMaterialLista;
        }

        public List<Model.ConsumoServico> getServicos()
        {
            return this._consumoServicoLista;
        }

        public void setMateriais(List<Model.ConsumoMaterial> consumoMaterialLista)
        {
            this._consumoMaterialLista = consumoMaterialLista;
        }

        public void setServicos(List<Model.ConsumoServico> consumoServicos)
        {
            this._consumoServicoLista = consumoServicos;
        }
    }
}

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
        private Model.Tarefa _tarefa;

        public int Cod { get => _cod; set => _cod = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public Obra Obra { get => _obra; set => _obra = value; }
        public Tarefa Tarefa { get => _tarefa; set => _tarefa = value; }

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

        public void setObra(Model.Obra obra)
        {
            this._obra = obra;
        }

        public Model.Obra getObra()
        {
            return this._obra;
        }
        
        public void setTarefa(Model.Tarefa tarefa)
        {
            this._tarefa = tarefa;
        }

        public Model.Tarefa getTarefa()
        {
            return this._tarefa;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Tarefa
    {
        private int _cod;
        private string _descricao;
        private Etapa _etapa;

        public int Cod { get => _cod; set => _cod = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public Etapa Etapa { get => _etapa; set => _etapa = value; }

        public Tarefa()
        {
            _cod = 0;
            _descricao = "";
            _etapa = null;
        }

        public Tarefa(int cod, string descricao, Etapa etapa)
        {
            _cod = cod;
            _descricao = descricao;
            _etapa = etapa;
        }

        public void setCod(int cod)
        {
            this._cod = cod;
        }

        public int getCod()
        {
            return this._cod;
        }

        public string setDescricao()
        {
            return this._descricao;
        }

        public void setDescricao(string descricao)
        {
            this._descricao = descricao;
        }

        public Etapa getEtapa()
        {
            return this._etapa;
        }

        public void setEtapa(Etapa etapa)
        {
            this._etapa = etapa;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != typeof(Model.Tarefa))
                return false;

            return ((Model.Tarefa)obj).getCod() == this.getCod();
        }
    }
}

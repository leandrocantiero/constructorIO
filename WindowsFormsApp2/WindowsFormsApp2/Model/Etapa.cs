using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Etapa
    {
        private int _cod;
        private string _descricao;

        public int Cod { get => _cod; set => _cod = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        public Etapa()
        {
            _cod = 0;
            _descricao = "";
        }

        public Etapa(int cod, string descricao)
        {
            _cod = cod;
            _descricao = descricao;
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
    }
}

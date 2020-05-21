using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Categoria
    {
        private int _cod;
        private string _descricao;

        public int Cod { get => _cod; set => _cod = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        public Categoria()
        {
            this._cod = 0;
            this._descricao = "";
        }

        public void setCod(int cod)
        {
            this._cod = cod;
        }

        public int getCod()
        {
            return this._cod;
        }

        public void setDescricao(string descricao)
        {
            this._descricao = descricao;
        }

        public string getDescricao()
        {
            return this._descricao;
        }
    }
}

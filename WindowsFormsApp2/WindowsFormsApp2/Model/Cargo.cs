using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Cargo
    {
        private int cod;
        private string descricao;

        public int Cod { get => cod; set => cod = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Cargo()
        {
            this.cod = 0;
            this.descricao = "";
        }

        public Cargo(string descricao)
        {
            this.cod = 0;
            this.descricao = descricao;
        }

        public Cargo(int cod, string descricao)
        {
            this.cod = cod;
            this.descricao = descricao;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public int getCod()
        {
            return this.cod;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public override string ToString()
        {
            return this.descricao;
        }

        public override bool Equals(object obj)
        {
            return obj is Cargo cargo &&
                   cod == cargo.cod;
        }
    }
}

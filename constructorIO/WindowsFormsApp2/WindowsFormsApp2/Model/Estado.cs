using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Estado
    {
        private string uf;
        private string nome;

        public string Uf { get => uf; set => uf = value; }
        public string Nome { get => nome; set => nome = value; }

        public Estado()
        {
            this.uf = "";
            this.nome = "";
        }

        public Estado(string uf, string nome)
        {
            this.uf = uf;
            this.nome = nome;
        }

        public string getUf()
        {
            return this.uf;
        }

        public void setUf(string uf)
        {
            this.uf = uf;
        }

        public string getNome()
        { 
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.uf + " - " + this.nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Estado estado &&
                   uf == estado.uf;
        }
    }
}

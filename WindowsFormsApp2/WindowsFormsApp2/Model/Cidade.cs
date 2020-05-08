using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Cidade
    {
        private int cod;
        private string nome;
        private Model.Estado estado;

        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
        public Estado Estado { get => estado; set => estado = value; }

        public Cidade()
        {
            this.cod = 0;
            this.nome = "";
            this.estado = null;
        }

        public Cidade(int cod, string nome, Estado estado)
        {
            this.cod = cod;
            this.nome = nome;
            this.estado = estado;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public int getCod()
        {
            return this.cod;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setEstado(Model.Estado estado)
        {
            this.estado = estado;
        }

        public Model.Estado getEstado()
        {
            return this.estado;
        }

        public override string ToString()
        {
            return this.nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Cidade cidade &&
                   cod == cidade.cod;
        }
    }
}

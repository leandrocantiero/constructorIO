using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Contato
    {
        private int cod;
        private Model.NumeroContato numeroPadrao;
        private Model.NumeroContato numeroAlt;

        public int Cod { get => cod; set => cod = value; }
        public NumeroContato NumeroPadrao { get => numeroPadrao; set => numeroPadrao = value; }
        public NumeroContato NumeroAlt { get => numeroAlt; set => numeroAlt = value; }

        public Contato()
        {
            this.cod = 0;
            this.numeroPadrao = null;
            this.numeroAlt = null;
        }

        public Contato(NumeroContato numeroPadrao, NumeroContato numeroAlt)
        {
            this.cod = 0;
            this.numeroPadrao = numeroPadrao;
            this.numeroAlt = numeroAlt;
        }

        public Contato(int cod, NumeroContato numeroPadrao, NumeroContato numeroAlt)
        {
            this.cod = cod;
            this.numeroPadrao = numeroPadrao;
            this.numeroAlt = numeroAlt;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public int getCod()
        {
            return this.cod;
        }

        public NumeroContato getNumeroPadrao()
        {
            return this.numeroPadrao;
        }

        public void setNumeroPadrao(Model.NumeroContato numero)
        {
            this.numeroPadrao = numero;
        }

        public NumeroContato getNumeroAlt()
        {
            return this.numeroAlt;
        }

        public void setNumeroAlt(Model.NumeroContato numero)
        {
            this.numeroAlt = numero;
        }

        public override string ToString()
        {
            return this.NumeroPadrao.getDdd() + "-" + 
                this.NumeroPadrao.getNumero() + 
                this.numeroAlt.getDdd() + "-" + 
                this.numeroAlt.getNumero();
        }

        public override bool Equals(object obj)
        {
            return obj is Contato contato &&
                   cod == contato.cod;
        }
    }
}

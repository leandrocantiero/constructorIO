using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class NumeroContato
    {
        private string numero;
        private string ddd;

        public string Numero { get => numero; set => numero = value; }
        public string Ddd { get => ddd; set => ddd = value; }

        public NumeroContato()
        {
            this.numero = "";
            this.ddd = "";
        }

        public NumeroContato(string ddd, string numero)
        {
            this.numero = numero;
            this.ddd = ddd;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }

        public string getNumero()
        {
            return this.numero;
        }

        public void setDdd(string ddd)
        {
            this.ddd = ddd;
        }

        public string getDdd()
        {
            return this.ddd;
        }
    }
}

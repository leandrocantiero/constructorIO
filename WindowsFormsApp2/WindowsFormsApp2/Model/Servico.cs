using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Servico
    {
        private int _cod;
        private string _nome;
        private int _quantidadeHomem;
        private string _observacao;

        public void setCod(int cod)
        {
            this._cod = cod;
        }

        public int getCod()
        {
            return this._cod;
        }

        public void setNome(string nome)
        {
            this._nome = nome;
        }

        public string getNome()
        {
            return this._nome;
        }

        public void setQuantidadeHomem(int quantidadeHomem)
        {
            this._quantidadeHomem = quantidadeHomem;
        }

        public int getQuantidadeHomem()
        {
            return this._quantidadeHomem;
        }

        public void setObservacao(string observacao)
        {
            this._observacao = observacao;
        }

        public string getObservacao()
        {
            return this._observacao;
        }

    }
}

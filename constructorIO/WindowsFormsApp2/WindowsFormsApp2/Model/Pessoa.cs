using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Pessoa
    {
        private int cod;
        private string nome;
        private string registro;
        private DateTime dtNascimento;
        private Model.Endereco endereco;
        private Model.Contato contatos;

        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Registro { get => registro; set => registro = value; }
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
        public Contato Contatos { get => contatos; set => contatos = value; }

        public Pessoa()
        {
            this.cod = 0;
            this.nome = "";
            this.registro = "";
            this.dtNascimento = new DateTime();
            this.endereco = null;
            this.contatos = null;
        }

        public Pessoa(int cod, string nome, string registro,
            DateTime dtNascimento, Endereco endereco, Model.Contato contatos)
        {
            this.cod = cod;
            this.nome = nome;
            this.registro = registro;
            this.dtNascimento = dtNascimento;
            this.endereco = endereco;
            this.contatos = contatos;
        }


        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setRegistro(string registro)
        {
            this.registro = registro;
        }

        public void setDtNascimento(DateTime dataNasc)
        {
            this.dtNascimento= dataNasc;
        }
        
        public void setEndereco(Model.Endereco endereco)
        {
            this.endereco = endereco;
        }

        
        public int getCod()
        {
            return this.cod;
        }


        public string getNome()
        {
            return this.nome;
        }

        public string getRegistro()
        {
            return this.registro;
        }

        public DateTime getDtNascimento()
        {
            return this.dtNascimento;
        }

        public Model.Endereco setDtNascimento()
        {
            return this.endereco;
        }


        public Model.Endereco getEndereco()
        {
            return this.endereco;
        }

        public void setContato(Model.Contato contatos)
        {
            this.contatos = contatos;
        }

        public Model.Contato getContato()
        {
            return this.contatos;
        }
    }
}

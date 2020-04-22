using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class Param
    {
        private int cod;
        private string razaoSocial, fantasia, cnpj, inscEstadual;
        private Model.Endereco endereco;
        private Model.Contato contatos;

        public int Cod { get => cod; set => cod = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscEstadual { get => inscEstadual; set => inscEstadual = value; }

        public Param()
        {
            this.cod = 0;
            this.razaoSocial = "";
            this.fantasia = "";
            this.cnpj = "";
            this.inscEstadual = "";
            this.endereco = null;
            this.contatos = null;
        }

        public Param(int cod, string razaoSocial, string fantasia, string cnpj, string inscEstadual, Model.Endereco endereco, Model.Contato contatos) 
        {
            this.cod = cod;
            this.razaoSocial = razaoSocial;
            this.fantasia = fantasia;
            this.cnpj = cnpj;
            this.inscEstadual = inscEstadual;
            this.endereco = endereco;
            this.contatos = contatos;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public void setRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }

        public void setFantasia(string fantasia)
        {
            this.fantasia = fantasia;
        }

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public void setInscEstadual(string inscEstadual)
        {
            this.inscEstadual = inscEstadual;
        }

        public void setEndereco(Model.Endereco endereco)
        {
            this.endereco = endereco;
        }


        public int getCod()
        {
            return this.cod;
        }


        public string getRazaoSocial()
        {
            return this.razaoSocial;
        }

        public string getFantasia()
        {
            return this.fantasia;
        }

        public string getCnpj()
        {
            return this.cnpj;
        }

        public string getInscEstadual()
        {
            return this.inscEstadual;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class Cliente : Model.Pessoa
    {
        private string cpf_cnpj;
        private string email;

        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Email { get => email; set => email = value; }


        public Cliente() : base()
        {
            this.cpf_cnpj = null;
            this.email = null;
        }

        public Cliente(string cpf_cnpj, string email) : base()
        {
            this.cpf_cnpj = cpf_cnpj;
            this.email = email;
        }

        public void setCpfCnpj(string cpf_cnpj)
        {
            this.cpf_cnpj = cpf_cnpj;
        }

        public string getCpfCnpj()
        {
            return this.cpf_cnpj;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Cliente : Model.Pessoa
    {
        private string email;
        private bool ativo;

        public string Email { get => email; set => email = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public Cliente() : base()
        {
            this.email = null;
        }

        public Cliente(string cpf_cnpj, string email) : base()
        {
            this.email = email;
        }


        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }

        public bool getAtivo()
        {
            return this.ativo;
        }

        public override string ToString()
        {
            return this.Nome + ".";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class Param
    {
        private string razaoSocial, fantasia, cnpj, inscEstadual, logoMenor, logoMaior, email, site;
        private Model.Endereco endereco;
        private Model.Contato contatos;

        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscEstadual { get => inscEstadual; set => inscEstadual = value; }
        public string LogoMenor { get => logoMenor; set => logoMenor = value; }
        public string LogoMaior { get => logoMaior; set => logoMaior = value; }
        public string Email { get => email; set => email = value; }
        public string Site { get => site; set => site = value; }

        public Param()
        {
            this.razaoSocial = "";
            this.fantasia = "";
            this.cnpj = "";
            this.inscEstadual = "";
            this.logoMenor = "";
            this.logoMaior = "";
            this.email = "";
            this.site = "";
            this.endereco = null;
            this.contatos = null;
        }

        public Param(string razaoSocial, string fantasia, string cnpj, string inscEstadual, string logoMenor, string logoMaior, string email, string site, Model.Endereco endereco, Model.Contato contatos) 
        {
            this.razaoSocial = razaoSocial;
            this.fantasia = fantasia;
            this.cnpj = cnpj;
            this.inscEstadual = inscEstadual;
            this.logoMenor = logoMenor;
            this.logoMaior = logoMenor;
            this.email = email;
            this.site = site;
            this.endereco = endereco;
            this.contatos = contatos;
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

        public string getLogoMenor()
        {
            return this.logoMenor;
        }

        public string getLogoMaior()
        {
            return this.logoMaior;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getSite()
        {
            return this.site;
        }

        public void setLogoMenor(string logoMenor)
        {
            this.logoMenor = logoMenor;
        }

        public void setLogoMaior(string logoMaior)
        {
            this.logoMaior = logoMaior;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setSite(string site)
        {
            this.site = site;
        }
    }
}

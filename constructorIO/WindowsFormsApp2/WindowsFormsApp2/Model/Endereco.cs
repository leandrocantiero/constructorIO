﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Endereco
    {
        private int cod;
        private string cep;
        private string complemento;
        private string rua;
        private int numero;
        private string bairro;
        private Model.Cidade cidade;

        public int Cod { get => cod; set => cod = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }

        public Endereco()
        {
            this.cod = 0;
            this.cep = "";
            this.complemento = "";
            this.rua = "";
            this.numero = 0;
            this.bairro = "";
            this.cidade = null;
        }

        public Endereco(string cep, string complemento, string rua,
            int numero, string bairro, Model.Cidade cidade)
        {
            this.cod = 0;
            this.cep = cep;
            this.complemento = complemento;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
        }


        public Endereco(int cod, string cep, string complemento, string rua, 
            int numero, string bairro, Model.Cidade cidade)
        {
            this.cod = cod;
            this.cep = cep;
            this.complemento = complemento;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public int getCod()
        {
            return this.cod;
        }

        public string getCep()
        {
            return this.cep;
        }

        public string getComplemento()
        {
            return this.complemento;
        }

        public string getRua()
        {
            return this.rua;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public string getBairro()
        {
            return this.bairro;
        }

        public Model.Cidade getCidade()
        {
            return this.cidade;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public void setCidade(Model.Cidade cidade)
        {
            this.cidade = cidade;
        }

        public override string ToString()
        {
            return this.rua + ", " + this.numero;
        }
    }
}

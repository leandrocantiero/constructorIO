using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Material
    {
        private int _cod;
        private string _unidade;
        private string _descricao;
        private int _estoque;
        private string _nome;
        private decimal _valor;
        private Categoria _categoria;

        public int Cod { get => _cod; set => _cod = value; }
        public string Unidade { get => _unidade; set => _unidade = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Estoque { get => _estoque; set => _estoque = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public Model.Categoria Categoria { get => _categoria; set => _categoria = value; }

        public Material()
        {
            _cod = 0;
            _unidade = "";
            _descricao = "";
            _estoque = 0;
            _nome = "";
            _valor = 0;
        }

        public void setCod(int cod)
        {
            this._cod = cod;
        }

        public int getCod()
        {
            return this._cod;
        }

        public void setUnidade(string unidade)
        {
            this._unidade = unidade;
        }

        public string getUnidade()
        {
            return this._unidade;
        }

        public void setDescricao(string descricao)
        {
            this._descricao = descricao;
        }

        public string getDescricao()
        {
            return this._descricao;
        }

        public void setEstoque(int estoque)
        {
            this._estoque = estoque;
        }

        public int getEstoque()
        {
            return this._estoque;
        }

        public void setNome(string nome)
        {
            this._nome = nome;
        }

        public string getNome()
        {
            return this._nome;
        }

        public void setValor(decimal valor)
        {
            this._valor = valor;
        }

        public decimal getValor()
        {
            return this._valor;
        }

        public void setCategoria(Model.Categoria categoria)
        {
            this._categoria = categoria;
        }

        public Model.Categoria getCategoria()
        {
            return this._categoria;
        }
    }
}

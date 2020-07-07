using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class ControleAcesso
    {
        private int cod;
        private string login;
        private string senha;
        private bool usuarioAtivo;
        private int nivelAcesso;

        public int Cod { get => cod; set => cod = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool UsuarioAtivo { get => usuarioAtivo; set => usuarioAtivo = value; }
        public int NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }

        public ControleAcesso()
        {
            this.cod = 0;
            this.login = "";
            this.senha = "";
            this.usuarioAtivo = false;
            this.nivelAcesso = -1;
        }

        public ControleAcesso(string login, string senha,
            bool usuarioAtivo, int nivelAcesso)
        {
            this.cod = 0;
            this.login = login;
            this.senha = senha;
            this.usuarioAtivo = usuarioAtivo;
            this.nivelAcesso = nivelAcesso;
        }

        public ControleAcesso(int cod, string login, string senha, 
            bool usuarioAtivo, int nivelAcesso)
        {
            this.cod = cod;
            this.login = login;
            this.senha = senha;
            this.usuarioAtivo = usuarioAtivo;
            this.nivelAcesso = nivelAcesso;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public void setLogin(string login)
        {
            this.login = login;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public void setUsuarioAtivo(bool ativo)
        {
            this.usuarioAtivo = ativo;
        }

        public void setNivelAcesso(int nivel)
        {
            this.nivelAcesso = nivel;
        }

        public int getCod()
        {
            return this.cod;
        }

        public string getLogin()
        {
            return this.login;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public bool getUsuarioAtivo()
        {
            return this.usuarioAtivo;
        }

        public int getNivelAcesso()
        {
            return this.nivelAcesso;
        }

        public override string ToString()
        {
            return this.login;
        }
    }
}

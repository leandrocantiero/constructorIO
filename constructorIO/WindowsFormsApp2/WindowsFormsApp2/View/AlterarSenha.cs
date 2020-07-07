using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    public partial class AlterarSenha : MaterialSkin.Controls.MaterialForm
    {
        private Model.Funcionario funcAlterado;

        public AlterarSenha()
        {
            InitializeComponent();
            mostrarLogin();
            funcAlterado = null;
        }

        private void mostrarLogin()
        {
            string loginStr = "";

            if (Principal.FUNCIONARIO_LOGADO != null)
            {
                if (Principal.FUNCIONARIO_LOGADO.getNome() != null && Principal.FUNCIONARIO_LOGADO.getNome().Length > 0)
                {
                    loginStr += " " + Principal.FUNCIONARIO_LOGADO.getNome();
                }
                else if (Principal.FUNCIONARIO_LOGADO.getControleAcesso() != null &&
                        Principal.FUNCIONARIO_LOGADO.getControleAcesso().getLogin().Length > 0)
                {
                    loginStr += " " + Principal.FUNCIONARIO_LOGADO.getControleAcesso().getLogin();
                }
            }
            else
            {
                loginStr += " Você está sem Login, o software pode apresentar problemas, favor entrar em contato com a TI";
                txtSenhaAtual.Hide();
                txtSenhaNova.Hide();
            }

            txtLogin.Text = loginStr;
        }

        private void btnAlterarSenha(object sender, EventArgs e)
        {
            if(txtSenhaAtual.Text != null && txtSenhaNova.Text != null && txtSenhaNovaConfirmar.Text != null)
            {

                if(txtSenhaNova.Text.ToString() == txtSenhaNovaConfirmar.Text.ToString())
                {
                    //tentar alterar//
                    Controller.LogarController logarController = new Controller.LogarController();
                    funcAlterado = logarController.trocarSenha(txtSenhaAtual.Text, txtSenhaNova.Text, View.Principal.FUNCIONARIO_LOGADO);
                
                    if(funcAlterado != null)
                    {
                        MessageBox.Show("Alterado com sucesso!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        View.Principal.FUNCIONARIO_LOGADO.getControleAcesso().setSenha(txtSenhaNova.Text);
                    
                        txtSenhaAtual.Text = "";
                        txtSenhaNova.Text = "";
                        txtSenhaNovaConfirmar.Text = "";
                    }
                   
                }
                else
                {
                    MessageBox.Show("Nova senha e nova senha para confirmação não são iguais!!", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSenhaNovaConfirmar.Text = "";
                }
            }
        }

        public Model.Funcionario getFuncionarioAlterado()
        {
            return this.funcAlterado;
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

        }

        private void AlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaNovaConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaNova_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaAtual_Click(object sender, EventArgs e)
        {

        }
    }
}

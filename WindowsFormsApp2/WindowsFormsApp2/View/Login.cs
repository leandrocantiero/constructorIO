using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();


            gerarUsuarioInicial();
        }

        private void btnLogar(object sender, EventArgs e)
        {
            Controller.LogarController logarCtr = new Controller.LogarController();
            Controller.ParamController paramController = new Controller.ParamController();
            
            Model.Funcionario func = null;
            Model.ControleAcesso ctrAccess = new Model.ControleAcesso();

            if (paramController.obterQuantidade() == 0)
            {
                MessageBox.Show("O sistema não possui parâmetros configurados, favor configurar!",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Hide();

                View.Param paramView = new View.Param();
                paramView.Show();

                this.Show();

            }
            else
            {
                if (txtLogin.Text.Length > 0 && txtSenha.Text.Length > 0)
                {
                    ctrAccess.setLogin(txtLogin.Text);
                    ctrAccess.setSenha(txtSenha.Text);
                    func = logarCtr.logar(ctrAccess);

                    if (func != null)
                    {
                        this.Hide();
                        View.Principal.FUNCIONARIO_LOGADO = func;
                        var form2 = new View.Principal();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Vefifique o login ou a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        public void gerarUsuarioInicial()
        {

            Controller.FuncionarioController funcController = new Controller.FuncionarioController();
            if (funcController.getQuantUserNivelUm() == 0)
            {
                MessageBox.Show(@"
                    Foi gerado um usuário Master inicial.
                    Utilize para criar o primeiro funcionário do sistema.

                    Login: ADM
                    Senha: 1234

                    Não se esqueça de mudar a senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                funcController.gerarUsuarioInicial();
            }


        }


    }
}

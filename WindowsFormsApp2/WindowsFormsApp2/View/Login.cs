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
        }


        private void btnLogar(object sender, EventArgs e)
        {
            Model.Funcionario func = null;
            Controller.LogarController logarCtr = new Controller.LogarController();
            Model.ControleAcesso ctrAccess = new Model.ControleAcesso();

            if (txtLogin.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                ctrAccess.setLogin(txtLogin.Text);
                ctrAccess.setSenha(txtSenha.Text);
                func = logarCtr.logar(ctrAccess);

                if (func != null)
                {
                    this.Hide();
                    var form2 = new View.Principal();
                    View.Principal.FUNCIONARIO_LOGADO = func;
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
}

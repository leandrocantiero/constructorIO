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
            funcAlterado = null;
        }

        private void btnAlterarSenha(object sender, EventArgs e)
        {
            if(txtSenhaAtual.Text != null && txtSenhaAtual.Text != null)
            {
                Controller.LogarController logarController = new Controller.LogarController();
                funcAlterado = logarController.trocarSenha(txtSenhaAtual.Text, txtSenhaNova.Text, View.Principal.FUNCIONARIO_LOGADO);
                
                if(funcAlterado != null)
                {
                    MessageBox.Show("Alterado com sucesso!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    View.Principal.FUNCIONARIO_LOGADO.getControleAcesso().setSenha(txtSenhaNova.Text);
                    
                    txtSenhaAtual.Text = "";
                    txtSenhaNova.Text = "";
                }
            }
        }

        public Model.Funcionario getFuncionarioAlterado()
        {
            return this.funcAlterado;
        }
    }
}

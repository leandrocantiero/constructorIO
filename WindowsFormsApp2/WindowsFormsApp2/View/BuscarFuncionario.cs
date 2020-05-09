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
    public partial class BuscarFuncionario : MaterialSkin.Controls.MaterialForm
    {
        Controller.FuncionarioController funcionarioController;
        BindingList<object> funcionarios;
        Form iniciarObra;

        public BuscarFuncionario(Form iniciarObra = null)
        {
            InitializeComponent();

            funcionarioController = new Controller.FuncionarioController();
            funcionarios = new BindingList<object>();
            dgvFuncionarios.DataSource = funcionarios;

            this.iniciarObra = iniciarObra;

            this.Load += new EventHandler(carregarDadosIniciais);
        }

        private void carregarDadosIniciais(System.Object sender, System.EventArgs e)
        {
            List<object> clientes = new List<object>(funcionarioController.obterTodos());
            this.configGridFuncionarios(clientes);
        }

        public void configGridFuncionarios(List<object> funcionarios)
        {
            dgvFuncionarios.DataSource = null;
            this.funcionarios.Clear();

            if (funcionarios.Count > 0)
            {
                this.funcionarios = new BindingList<object>(funcionarios);
            }
            
            dgvFuncionarios.DataSource = this.funcionarios;

            ///config grid depois

        }

        private void onCLickSelecionarFuncionario(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentRow?.DataBoundItem != null)
            {
                var funcionarioSelecionado = dgvFuncionarios.CurrentRow?.DataBoundItem;

                ((View.IniciarObra)iniciarObra).setarFuncionarioTela(funcionarioSelecionado);

                MessageBox.Show("Funcionarios carregados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("É preciso ter um funcionário selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            List<object> funcionarios;

            if(txtNomeCliente.Text.Length == 0)
            {
                funcionarios = new List<object>(funcionarioController.obterTodos());
                this.configGridFuncionarios(funcionarios);
            }
            else
            {
                funcionarios = new List<object>(funcionarioController.obterTodos(txtNomeCliente.Text));

                if (funcionarios.Count == 0)
                {
                    MessageBox.Show("Funcionarios não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.configGridFuncionarios(funcionarios);
                }
            }

          
        }
    }
}

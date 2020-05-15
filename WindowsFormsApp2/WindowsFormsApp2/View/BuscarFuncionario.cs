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

            if(this.funcionarios.Count > 0)
            {
                ///config grid depois
                ///   dgvClientes.Columns["Nome"].HeaderText = "Nome Completo";
                dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvFuncionarios.Columns["Cod"].Visible = false;

                dgvFuncionarios.Columns["Nome"].HeaderText = "Nome Completo";
                dgvFuncionarios.Columns["Nome"].DisplayIndex = 1;
                dgvFuncionarios.Columns["Nome"].ReadOnly = true;

                dgvFuncionarios.Columns["Registro"].HeaderText = "Registro (CAU/CREA)";
                dgvFuncionarios.Columns["Registro"].DisplayIndex = 2;
                dgvFuncionarios.Columns["Registro"].ReadOnly = true;

                dgvFuncionarios.Columns["Cpf"].HeaderText = "CPF";
                dgvFuncionarios.Columns["Cpf"].DisplayIndex = 3;
                dgvFuncionarios.Columns["Cpf"].ReadOnly = true;

                dgvFuncionarios.Columns["Rg"].HeaderText = "RG";
                dgvFuncionarios.Columns["Rg"].DisplayIndex = 4;
                dgvFuncionarios.Columns["Rg"].ReadOnly = true;

                dgvFuncionarios.Columns["Cargo"].HeaderText = "Cargo";
                dgvFuncionarios.Columns["Cargo"].DisplayIndex = 5;
                dgvFuncionarios.Columns["Cargo"].ReadOnly = true;

                dgvFuncionarios.Columns["Contatos"].HeaderText = "Celular/Telefone Fix";
                dgvFuncionarios.Columns["Contatos"].DisplayIndex = 6;
                dgvFuncionarios.Columns["Contatos"].ReadOnly = true;

                dgvFuncionarios.Columns["Endereco"].HeaderText = "Endereco Completo";
                dgvFuncionarios.Columns["Endereco"].DisplayIndex = 7;
                dgvFuncionarios.Columns["Endereco"].ReadOnly = true;

                dgvFuncionarios.Columns["DtNascimento"].HeaderText = "Data de Nascimento";
                dgvFuncionarios.Columns["DtNascimento"].DisplayIndex = 8;
                dgvFuncionarios.Columns["DtNascimento"].ReadOnly = true;

                dgvFuncionarios.Columns["ControleAcesso"].HeaderText = "Login";
                dgvFuncionarios.Columns["ControleAcesso"].DisplayIndex = 9;
                dgvFuncionarios.Columns["ControleAcesso"].ReadOnly = true;

                dgvFuncionarios.Columns["DtAdmissao"].HeaderText = "Data de Admissao";
                dgvFuncionarios.Columns["DtAdmissao"].DisplayIndex = 10;
                dgvFuncionarios.Columns["DtAdmissao"].ReadOnly = true;

                dgvFuncionarios.Columns["DtDemissao"].HeaderText = "Data de Demissao";
                dgvFuncionarios.Columns["DtDemissao"].DisplayIndex = 11;
                dgvFuncionarios.Columns["DtDemissao"].ReadOnly = true;
            }

        }

        private void onCLickSelecionarFuncionario(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentRow?.DataBoundItem != null)
            {
                var funcionarioSelecionado = dgvFuncionarios.CurrentRow?.DataBoundItem;

                ((View.IniciarObra)iniciarObra).setarFuncionarioTela(funcionarioSelecionado);

                MessageBox.Show("Funcionario carregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

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
    public partial class BuscarCliente : MaterialSkin.Controls.MaterialForm
    {
        Controller.ClienteController clienteController;
        BindingList<object> clientes;

        Form iniciarObra;

        public BuscarCliente(Form iniciarObra = null)
        {
            InitializeComponent();

            clienteController = new Controller.ClienteController();
            clientes = null;
            this.iniciarObra = iniciarObra;

            this.Load += new EventHandler(carregarDadosIniciais);
        }


        private void carregarDadosIniciais(System.Object sender, System.EventArgs e)
        {
            List<object> clientes = new List<object>(clienteController.obterTodos());
            this.configGridClientes(clientes);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            List<object> clientes;

            if(txtNomeCliente.Text.Length == 0)
            {
                clientes = new List<object>(clienteController.obterTodos());
                this.configGridClientes(clientes);
            }
            else
            {
                clientes = new List<object>(clienteController.obterTodos(txtNomeCliente.Text, null));
                if (clientes.Count == 0)
                {
                    MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.configGridClientes(clientes);
                }
            }
        }

       
        public void configGridClientes(List<object> clientes)
        {
            dgvClientes.DataSource = null;

            this.clientes = new BindingList<object>(clientes);

            dgvClientes.DataSource = this.clientes;

            if (this.clientes.Count > 0)
            {

                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvClientes.Columns["Cod"].Visible = false;

                dgvClientes.Columns["Nome"].HeaderText = "Nome Completo";
                dgvClientes.Columns["Nome"].DisplayIndex = 1;
                dgvClientes.Columns["Nome"].ReadOnly = true;

                dgvClientes.Columns["Registro"].HeaderText = "CPF/CNPJ";
                dgvClientes.Columns["Registro"].DisplayIndex = 2;
                dgvClientes.Columns["Registro"].ReadOnly = true;


                dgvClientes.Columns["DtNascimento"].HeaderText = "Data de nascimento";
                dgvClientes.Columns["DtNascimento"].DisplayIndex = 3;
                dgvClientes.Columns["DtNascimento"].ReadOnly = true;


                dgvClientes.Columns["Contatos"].HeaderText = "Contatos";
                dgvClientes.Columns["Contatos"].DisplayIndex = 4;
                dgvClientes.Columns["Contatos"].ReadOnly = true;


                dgvClientes.Columns["Endereco"].HeaderText = "Endereço";
                dgvClientes.Columns["Endereco"].DisplayIndex = 5;
                dgvClientes.Columns["Endereco"].ReadOnly = true;

                dgvClientes.Columns["Email"].HeaderText = "Email";
                dgvClientes.Columns["Email"].DisplayIndex = 6;
                dgvClientes.Columns["Email"].ReadOnly = true;

                dgvClientes.Columns["Ativo"].HeaderText = "Ativo";
                dgvClientes.Columns["Ativo"].DisplayIndex = 7;
                dgvClientes.Columns["Ativo"].ReadOnly = true;
            }
        }

        private void onClickSelecionarCliente(object sender, EventArgs e)
        {
            if ((Model.Cliente)dgvClientes.CurrentRow?.DataBoundItem != null)
            {
                var cliente = dgvClientes.CurrentRow?.DataBoundItem;

                ((View.IniciarObra)iniciarObra).setarClienteTela(cliente);

                MessageBox.Show("Cliente carregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("É preciso ter um cliente selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }


    }
}

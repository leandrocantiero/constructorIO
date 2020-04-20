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
    public partial class Principal : MaterialSkin.Controls.MaterialForm
    {
        public static Model.Funcionario FUNCIONARIO_LOGADO = null;

        public Principal()
        {
            InitializeComponent();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            Obras form = new Obras();
            form.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores form = new Fornecedores();
            form.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios form = new Funcionarios();
            form.Show();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            ContasPagar form = new ContasPagar();
            form.Show();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            ContasReceber form = new ContasReceber();
            form.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //Pedidos form = new Pedidos();
            //form.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            //Compras form = new Compras();
            //form.Show();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            Agendamentos form = new Agendamentos();
            form.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            //Relatorios form = new Relatorios();
            //form.Show();
        }
    }
}

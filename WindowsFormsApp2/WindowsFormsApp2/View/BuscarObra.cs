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
    public partial class BuscarObra : MaterialSkin.Controls.MaterialForm
    {
        private Controller.ObrasController obrasController;
        private BindingList<object> obras;

        private Form lancarMateriaisServicos;

        public BuscarObra(Form lancarMateriaisServicos = null)
        {
            InitializeComponent();

            obrasController = new Controller.ObrasController();
            obras = new BindingList<object>();

            this.lancarMateriaisServicos = lancarMateriaisServicos;

            this.Load += new EventHandler(carregarDadosIniciais);
        }

        private void carregarDadosIniciais(System.Object sender, System.EventArgs e)
        {
            List<object> obras = new List<object>(obrasController.obterTodas());
            this.configObrasTela(obras);
        }


        public void configObrasTela(List<object> obras)
        {
            if (obras == null)
            {
                obras = new List<object>(obrasController.obterTodas());
            }

            this.obras = null;
            this.obras = new BindingList<object>(obras);

            //configurar colunas depois

            this.dgvObras.DataSource = null;
            this.dgvObras.DataSource = this.obras;

            if (this.obras.Count > 0)
            {
                dgvObras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvObras.Columns["Cod"].Visible = false;
                dgvObras.Columns["Descricao"].Visible = false;


                dgvObras.Columns["Cliente"].HeaderText = "Cliente";
                dgvObras.Columns["Cliente"].DisplayIndex = 1;
                dgvObras.Columns["Cliente"].ReadOnly = true;


                dgvObras.Columns["Funcionario"].HeaderText = "Funcionário";
                dgvObras.Columns["Funcionario"].DisplayIndex = 2;
                dgvObras.Columns["Funcionario"].ReadOnly = true;


                dgvObras.Columns["Endereco"].HeaderText = "Endereço";
                dgvObras.Columns["Endereco"].DisplayIndex = 3;
                dgvObras.Columns["Endereco"].ReadOnly = true;
                dgvObras.Columns["Endereco"].ReadOnly = true;

                dgvObras.Columns["Valor"].HeaderText = "Valor";
                dgvObras.Columns["Valor"].DisplayIndex = 4;
                dgvObras.Columns["Valor"].ReadOnly = true;

                dgvObras.Columns["Status"].HeaderText = "Status da obra";
                dgvObras.Columns["Status"].DisplayIndex = 5;
                dgvObras.Columns["Status"].ReadOnly = true;


                dgvObras.Columns["DtInicio"].HeaderText = "Data de início";
                dgvObras.Columns["DtInicio"].DisplayIndex = 6;
                dgvObras.Columns["DtInicio"].ReadOnly = true;


                dgvObras.Columns["DtPrevFim"].HeaderText = "Data de Previsão Fim";
                dgvObras.Columns["DtPrevFim"].DisplayIndex = 7;
                dgvObras.Columns["DtPrevFim"].ReadOnly = true;


                dgvObras.Columns["DtFim"].HeaderText = "Data finalizada";
                dgvObras.Columns["DtFim"].DisplayIndex = 7;
                dgvObras.Columns["DtFim"].ReadOnly = true;

            }
        }

        private void btnBuscarObra_Click(object sender, EventArgs e)
        {
            List<object> obras;

            if (txtBuscaEnderecoObra.Text.Length == 0)
            {
                carregarDadosIniciais(null, null);
            }
            else
            {
                obras = new List<object>(this.obrasController.obterTodas(txtBuscaEnderecoObra.Text, null));
                if (obras.Count == 0)
                {
                    MessageBox.Show("Obra não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.configObrasTela(obras);
                }
            }
        }

        private void btnSelecionarObra_Click(object sender, EventArgs e)
        {

            if ((Model.Obra)dgvObras.CurrentRow?.DataBoundItem != null)
            {
                var obra = dgvObras.CurrentRow?.DataBoundItem;

                ((View.LancarMateriaisServicos)this.lancarMateriaisServicos).setarObraTela(obra);

                MessageBox.Show("Obra carregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("É preciso ter uma obra selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
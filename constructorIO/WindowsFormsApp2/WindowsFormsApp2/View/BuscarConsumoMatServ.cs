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
    public partial class BuscarConsumoMatServ : MaterialSkin.Controls.MaterialForm
    {
        private Form TelaCosumoMatServ;
        private Controller.ControllerConsumoMaterialServico controllerConsumoMaterialServico;
        private BindingList<Model.ConsumoMaterialServico> consumoMatServList;
        private Model.ConsumoMaterialServico consumoMatServTela;

        public BuscarConsumoMatServ(Form TelaCosumoMatServ = null)
        {
            InitializeComponent();

            this.TelaCosumoMatServ = TelaCosumoMatServ;
            controllerConsumoMaterialServico = new Controller.ControllerConsumoMaterialServico();
            consumoMatServTela = null;

            var listaConsuMatServ = controllerConsumoMaterialServico.obterTodos(dtpLançamento.Value, false);
            configGrid(listaConsuMatServ);
        }

        private void btnBuscarConsumoMatServ_Click(object sender, EventArgs e)
        {
            if(dtpLançamento.Value == null || dtpLançamento.Value.ToString() == "")
            {
                MessageBox.Show("Informe uma data válida.", "Aviso");
            }
            else
            {

                var listaConsuMatServ = controllerConsumoMaterialServico.obterTodos(dtpLançamento.Value, true);
                configGrid(listaConsuMatServ);
            }
        }

        private void configGrid(List<Model.ConsumoMaterialServico> consumoMaterialServicos)
        {
            /*
             
        public int Cod { get => _cod; set => _cod = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public Obra Obra { get => _obra; set => _obra = value; }

             */


            consumoMatServList = new BindingList<Model.ConsumoMaterialServico>(consumoMaterialServicos);
            dgvConsumoMatServ.DataSource = null;

            if (consumoMatServList.Count > 0)
            {
                dgvConsumoMatServ.DataSource = this.consumoMatServList;

                dgvConsumoMatServ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvConsumoMatServ.Columns["Cod"].Visible = false;

                dgvConsumoMatServ.Columns["Data"].HeaderText = "Data do lançamento";
                dgvConsumoMatServ.Columns["Data"].DisplayIndex = 1;
                dgvConsumoMatServ.Columns["Data"].ReadOnly = true;

                dgvConsumoMatServ.Columns["Obra"].HeaderText = "Obra referente ao lançamento";
                dgvConsumoMatServ.Columns["Obra"].DisplayIndex = 2;
                dgvConsumoMatServ.Columns["Obra"].ReadOnly = true;
            }
        }

        private void btnSelecionarConsumoMatServ_Click(object sender, EventArgs e)
        {
            if(this.consumoMatServTela != null)
            {
                ((View.LancarMateriaisServicos)this.TelaCosumoMatServ).setarConsumoMatServ(this.consumoMatServTela);
                MessageBox.Show("Lançamento selecionado", "Aviso");
            }
        }

        private void dgvConsumoMatServ_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var consumoMatServSelected = (Model.ConsumoMaterialServico)dgvConsumoMatServ.CurrentRow?.DataBoundItem;

            if(consumoMatServSelected != null)
            {
                this.consumoMatServTela = consumoMatServSelected;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var listaConsuMatServ = controllerConsumoMaterialServico.obterTodos(dtpLançamento.Value, false);
            configGrid(listaConsuMatServ);
        }
    }
}

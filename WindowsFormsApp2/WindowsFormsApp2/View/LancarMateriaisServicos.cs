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
    public partial class LancarMateriaisServicos : MaterialSkin.Controls.MaterialForm
    {
        public LancarMateriaisServicos()
        {
            InitializeComponent();
            configurarFormsIniciais();

            this.Load += new EventHandler(afterLoadView);
        }

        private void afterLoadView(System.Object sender, System.EventArgs e)
        {
            configurarFormsIniciais();
        }

        private void configurarFormsIniciais()
        {
            modoInserir();
        }

        private void modoInserir()
        {
            objObraSelecionada.Enabled = false;
            objTarefa.Enabled = false;
            
            objProdutoSelecionado.Enabled = false;
            txtUnidadeProduto.Enabled = false;

            objServicoSelecionado.Enabled = false;


        }

        private void txtBuscarTarefa_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEtapaTarefa_Click(object sender, EventArgs e)
        {

        }
    }
}

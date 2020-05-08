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
    public partial class IniciarObra : MaterialSkin.Controls.MaterialForm
    {
        public IniciarObra()
        {
            InitializeComponent();

            //this.Load += new EventHandler(InitializeTreeView);
        }

        private void InitializeTreeView(System.Object sender, System.EventArgs e)
        {
            //this.tv1.BorderStyle = BorderStyle.None;
            //this.tv1.BackColor = this.BackColor;
            //this.tv1.Scrollable = false;
            //this.tv1.Scrollable = true;
            //this.tv1.CheckBoxes = true;

            //this.tv1.HideSelection = false;

            //this.tv1.ShowRootLines = false;
            //this.tv1.ShowLines = false;

            //// Add the nodes.
            //this.tv1.Nodes.AddRange(new TreeNode[] {
            //        new TreeNode("etapa1",
            //            new TreeNode[]{
            //                new TreeNode("tarefa1"),
            //                new TreeNode("tarefa2"),
            //                new TreeNode("tarefa3") 
            //            }
            //       )
            //    }
            //);

            //this.tv1.Nodes[0].Nodes["etapa1"].Nodes["tarefa1"].Nodes.Add();

            //// Set the tab index and add the TreeView to the form.
            //this.tv1.TabIndex = 0;
            //this.Controls.Add(this.tv1);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

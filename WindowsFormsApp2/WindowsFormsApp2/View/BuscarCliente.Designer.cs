namespace WindowsFormsApp2.View
{
    partial class BuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNomeCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 140);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(922, 290);
            this.dgvClientes.TabIndex = 0;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Depth = 0;
            this.txtNomeCliente.Hint = "Nome do cliente";
            this.txtNomeCliente.Location = new System.Drawing.Point(19, 108);
            this.txtNomeCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PasswordChar = '\0';
            this.txtNomeCliente.SelectedText = "";
            this.txtNomeCliente.SelectionLength = 0;
            this.txtNomeCliente.SelectionStart = 0;
            this.txtNomeCliente.Size = new System.Drawing.Size(354, 23);
            this.txtNomeCliente.TabIndex = 9;
            this.txtNomeCliente.UseSystemPasswordChar = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Location = new System.Drawing.Point(709, 95);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = false;
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarCliente.TabIndex = 10;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(784, 95);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "Selecionar cliente";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.onClickSelecionarCliente);
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 442);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dgvClientes);
            this.Name = "BuscarCliente";
            this.Text = "Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNomeCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 290);
            this.dataGridView1.TabIndex = 0;
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
            this.txtNomeCliente.Size = new System.Drawing.Size(431, 23);
            this.txtNomeCliente.TabIndex = 9;
            this.txtNomeCliente.UseSystemPasswordChar = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Location = new System.Drawing.Point(457, 95);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = false;
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarCliente.TabIndex = 10;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 442);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarCliente";
            this.Text = "Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarCliente;
    }
}
namespace WindowsFormsApp2.View
{
    partial class BuscarObra
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
            this.btnSelecionarObra = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBuscaEnderecoObra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarObra = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvObras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarObra
            // 
            this.btnSelecionarObra.AutoSize = true;
            this.btnSelecionarObra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelecionarObra.Depth = 0;
            this.btnSelecionarObra.Location = new System.Drawing.Point(784, 74);
            this.btnSelecionarObra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelecionarObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarObra.Name = "btnSelecionarObra";
            this.btnSelecionarObra.Primary = false;
            this.btnSelecionarObra.Size = new System.Drawing.Size(132, 36);
            this.btnSelecionarObra.TabIndex = 15;
            this.btnSelecionarObra.Text = "Selecionar Obra";
            this.btnSelecionarObra.UseVisualStyleBackColor = true;
            this.btnSelecionarObra.Click += new System.EventHandler(this.btnSelecionarObra_Click);
            // 
            // txtBuscaEnderecoObra
            // 
            this.txtBuscaEnderecoObra.Depth = 0;
            this.txtBuscaEnderecoObra.Hint = "Rua da obra";
            this.txtBuscaEnderecoObra.Location = new System.Drawing.Point(19, 87);
            this.txtBuscaEnderecoObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscaEnderecoObra.Name = "txtBuscaEnderecoObra";
            this.txtBuscaEnderecoObra.PasswordChar = '\0';
            this.txtBuscaEnderecoObra.SelectedText = "";
            this.txtBuscaEnderecoObra.SelectionLength = 0;
            this.txtBuscaEnderecoObra.SelectionStart = 0;
            this.txtBuscaEnderecoObra.Size = new System.Drawing.Size(354, 23);
            this.txtBuscaEnderecoObra.TabIndex = 13;
            this.txtBuscaEnderecoObra.UseSystemPasswordChar = false;
            // 
            // btnBuscarObra
            // 
            this.btnBuscarObra.AutoSize = true;
            this.btnBuscarObra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarObra.Depth = 0;
            this.btnBuscarObra.Location = new System.Drawing.Point(709, 74);
            this.btnBuscarObra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Primary = false;
            this.btnBuscarObra.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarObra.TabIndex = 14;
            this.btnBuscarObra.Text = "Buscar";
            this.btnBuscarObra.UseVisualStyleBackColor = true;
            this.btnBuscarObra.Click += new System.EventHandler(this.btnBuscarObra_Click);
            // 
            // dgvObras
            // 
            this.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObras.Location = new System.Drawing.Point(12, 119);
            this.dgvObras.Name = "dgvObras";
            this.dgvObras.Size = new System.Drawing.Size(922, 319);
            this.dgvObras.TabIndex = 12;
            // 
            // BuscarObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 455);
            this.Controls.Add(this.btnSelecionarObra);
            this.Controls.Add(this.txtBuscaEnderecoObra);
            this.Controls.Add(this.btnBuscarObra);
            this.Controls.Add(this.dgvObras);
            this.Name = "BuscarObra";
            this.Text = "BuscarObra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnSelecionarObra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscaEnderecoObra;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarObra;
        private System.Windows.Forms.DataGridView dgvObras;
    }
}
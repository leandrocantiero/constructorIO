namespace WindowsFormsApp2.View
{
    partial class BuscarConsumoMatServ
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
            this.btnSelecionarConsumoMatServ = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscarConsumoMatServ = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvConsumoMatServ = new System.Windows.Forms.DataGridView();
            this.dtpLançamento = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumoMatServ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarConsumoMatServ
            // 
            this.btnSelecionarConsumoMatServ.AutoSize = true;
            this.btnSelecionarConsumoMatServ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelecionarConsumoMatServ.Depth = 0;
            this.btnSelecionarConsumoMatServ.Location = new System.Drawing.Point(167, 413);
            this.btnSelecionarConsumoMatServ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelecionarConsumoMatServ.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarConsumoMatServ.Name = "btnSelecionarConsumoMatServ";
            this.btnSelecionarConsumoMatServ.Primary = false;
            this.btnSelecionarConsumoMatServ.Size = new System.Drawing.Size(188, 36);
            this.btnSelecionarConsumoMatServ.TabIndex = 18;
            this.btnSelecionarConsumoMatServ.Text = "Selecionar Lançamento";
            this.btnSelecionarConsumoMatServ.UseVisualStyleBackColor = true;
            this.btnSelecionarConsumoMatServ.Click += new System.EventHandler(this.btnSelecionarConsumoMatServ_Click);
            // 
            // btnBuscarConsumoMatServ
            // 
            this.btnBuscarConsumoMatServ.AutoSize = true;
            this.btnBuscarConsumoMatServ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarConsumoMatServ.Depth = 0;
            this.btnBuscarConsumoMatServ.Location = new System.Drawing.Point(79, 413);
            this.btnBuscarConsumoMatServ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarConsumoMatServ.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarConsumoMatServ.Name = "btnBuscarConsumoMatServ";
            this.btnBuscarConsumoMatServ.Primary = false;
            this.btnBuscarConsumoMatServ.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarConsumoMatServ.TabIndex = 17;
            this.btnBuscarConsumoMatServ.Text = "Buscar";
            this.btnBuscarConsumoMatServ.UseVisualStyleBackColor = true;
            this.btnBuscarConsumoMatServ.Click += new System.EventHandler(this.btnBuscarConsumoMatServ_Click);
            // 
            // dgvConsumoMatServ
            // 
            this.dgvConsumoMatServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumoMatServ.Location = new System.Drawing.Point(12, 148);
            this.dgvConsumoMatServ.Name = "dgvConsumoMatServ";
            this.dgvConsumoMatServ.Size = new System.Drawing.Size(347, 262);
            this.dgvConsumoMatServ.TabIndex = 15;
            this.dgvConsumoMatServ.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsumoMatServ_CellMouseClick);
            // 
            // dtpLançamento
            // 
            this.dtpLançamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLançamento.Location = new System.Drawing.Point(184, 124);
            this.dtpLançamento.Name = "dtpLançamento";
            this.dtpLançamento.Size = new System.Drawing.Size(108, 20);
            this.dtpLançamento.TabIndex = 19;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 124);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(144, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Data do lançamento";
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(13, 413);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = false;
            this.btnListar.Size = new System.Drawing.Size(58, 36);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // BuscarConsumoMatServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtpLançamento);
            this.Controls.Add(this.btnSelecionarConsumoMatServ);
            this.Controls.Add(this.btnBuscarConsumoMatServ);
            this.Controls.Add(this.dgvConsumoMatServ);
            this.Name = "BuscarConsumoMatServ";
            this.Text = "Buscar lançamentos de materiais e serviços";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumoMatServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnSelecionarConsumoMatServ;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarConsumoMatServ;
        private System.Windows.Forms.DataGridView dgvConsumoMatServ;
        private System.Windows.Forms.DateTimePicker dtpLançamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
    }
}
namespace WindowsFormsApp2.View
{
    partial class Param
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
            this.btnClose = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.txtCEP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLogradouro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDdd2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDdd1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContato2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContato1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRazaoSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFantasia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCnpj = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtInscEstadual = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.Location = new System.Drawing.Point(944, 416);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Primary = false;
            this.btnClose.Size = new System.Drawing.Size(64, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(1016, 416);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(63, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(311, 299);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(110, 21);
            this.cbbCidade.TabIndex = 75;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(307, 265);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(55, 19);
            this.materialLabel16.TabIndex = 74;
            this.materialLabel16.Text = "Cidade";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(181, 300);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(115, 21);
            this.cbbEstado.TabIndex = 73;
            // 
            // txtCEP
            // 
            this.txtCEP.Depth = 0;
            this.txtCEP.Hint = "";
            this.txtCEP.Location = new System.Drawing.Point(18, 299);
            this.txtCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.Size = new System.Drawing.Size(142, 23);
            this.txtCEP.TabIndex = 72;
            this.txtCEP.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(14, 267);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(37, 19);
            this.materialLabel13.TabIndex = 71;
            this.materialLabel13.Text = "CEP";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Depth = 0;
            this.txtLogradouro.Hint = "";
            this.txtLogradouro.Location = new System.Drawing.Point(657, 298);
            this.txtLogradouro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PasswordChar = '\0';
            this.txtLogradouro.SelectedText = "";
            this.txtLogradouro.SelectionLength = 0;
            this.txtLogradouro.SelectionStart = 0;
            this.txtLogradouro.Size = new System.Drawing.Size(264, 23);
            this.txtLogradouro.TabIndex = 70;
            this.txtLogradouro.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(653, 266);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(86, 19);
            this.materialLabel12.TabIndex = 69;
            this.materialLabel12.Text = "Logradouro";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(182, 266);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(56, 19);
            this.materialLabel11.TabIndex = 68;
            this.materialLabel11.Text = "Estado";
            // 
            // txtBairro
            // 
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(445, 297);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(191, 23);
            this.txtBairro.TabIndex = 67;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(441, 265);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 66;
            this.materialLabel9.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(942, 297);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(120, 23);
            this.txtNumero.TabIndex = 65;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(938, 265);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(63, 19);
            this.materialLabel8.TabIndex = 64;
            this.materialLabel8.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Depth = 0;
            this.txtRua.Hint = "";
            this.txtRua.Location = new System.Drawing.Point(18, 363);
            this.txtRua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRua.Name = "txtRua";
            this.txtRua.PasswordChar = '\0';
            this.txtRua.SelectedText = "";
            this.txtRua.SelectionLength = 0;
            this.txtRua.SelectionStart = 0;
            this.txtRua.Size = new System.Drawing.Size(293, 23);
            this.txtRua.TabIndex = 63;
            this.txtRua.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(14, 331);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(34, 19);
            this.materialLabel7.TabIndex = 62;
            this.materialLabel7.Text = "Rua";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(11, 237);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1061, 2);
            this.materialDivider1.TabIndex = 76;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(867, 79);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 82;
            this.materialLabel5.Text = "Contato 2";
            // 
            // txtDdd2
            // 
            this.txtDdd2.Depth = 0;
            this.txtDdd2.Hint = "";
            this.txtDdd2.Location = new System.Drawing.Point(871, 113);
            this.txtDdd2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDdd2.Name = "txtDdd2";
            this.txtDdd2.PasswordChar = '\0';
            this.txtDdd2.SelectedText = "";
            this.txtDdd2.SelectionLength = 0;
            this.txtDdd2.SelectionStart = 0;
            this.txtDdd2.Size = new System.Drawing.Size(31, 23);
            this.txtDdd2.TabIndex = 81;
            this.txtDdd2.UseSystemPasswordChar = false;
            // 
            // txtDdd1
            // 
            this.txtDdd1.Depth = 0;
            this.txtDdd1.Hint = "";
            this.txtDdd1.Location = new System.Drawing.Point(663, 113);
            this.txtDdd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDdd1.Name = "txtDdd1";
            this.txtDdd1.PasswordChar = '\0';
            this.txtDdd1.SelectedText = "";
            this.txtDdd1.SelectionLength = 0;
            this.txtDdd1.SelectionStart = 0;
            this.txtDdd1.Size = new System.Drawing.Size(31, 23);
            this.txtDdd1.TabIndex = 80;
            this.txtDdd1.UseSystemPasswordChar = false;
            // 
            // txtContato2
            // 
            this.txtContato2.Depth = 0;
            this.txtContato2.Hint = "";
            this.txtContato2.Location = new System.Drawing.Point(912, 112);
            this.txtContato2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.PasswordChar = '\0';
            this.txtContato2.SelectedText = "";
            this.txtContato2.SelectionLength = 0;
            this.txtContato2.SelectionStart = 0;
            this.txtContato2.Size = new System.Drawing.Size(150, 23);
            this.txtContato2.TabIndex = 79;
            this.txtContato2.UseSystemPasswordChar = false;
            // 
            // txtContato1
            // 
            this.txtContato1.Depth = 0;
            this.txtContato1.Hint = "";
            this.txtContato1.Location = new System.Drawing.Point(700, 112);
            this.txtContato1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.PasswordChar = '\0';
            this.txtContato1.SelectedText = "";
            this.txtContato1.SelectionLength = 0;
            this.txtContato1.SelectionStart = 0;
            this.txtContato1.Size = new System.Drawing.Size(156, 23);
            this.txtContato1.TabIndex = 78;
            this.txtContato1.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(661, 78);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(75, 19);
            this.materialLabel17.TabIndex = 77;
            this.materialLabel17.Text = "Contato 1";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Depth = 0;
            this.txtRazaoSocial.Hint = "";
            this.txtRazaoSocial.Location = new System.Drawing.Point(18, 112);
            this.txtRazaoSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.PasswordChar = '\0';
            this.txtRazaoSocial.SelectedText = "";
            this.txtRazaoSocial.SelectionLength = 0;
            this.txtRazaoSocial.SelectionStart = 0;
            this.txtRazaoSocial.Size = new System.Drawing.Size(307, 23);
            this.txtRazaoSocial.TabIndex = 84;
            this.txtRazaoSocial.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Razão social";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Depth = 0;
            this.txtFantasia.Hint = "";
            this.txtFantasia.Location = new System.Drawing.Point(342, 113);
            this.txtFantasia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.PasswordChar = '\0';
            this.txtFantasia.SelectedText = "";
            this.txtFantasia.SelectionLength = 0;
            this.txtFantasia.SelectionStart = 0;
            this.txtFantasia.Size = new System.Drawing.Size(305, 23);
            this.txtFantasia.TabIndex = 86;
            this.txtFantasia.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(338, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 85;
            this.materialLabel2.Text = "Fantasia";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Depth = 0;
            this.txtCnpj.Hint = "";
            this.txtCnpj.Location = new System.Drawing.Point(18, 182);
            this.txtCnpj.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.PasswordChar = '\0';
            this.txtCnpj.SelectedText = "";
            this.txtCnpj.SelectionLength = 0;
            this.txtCnpj.SelectionStart = 0;
            this.txtCnpj.Size = new System.Drawing.Size(307, 23);
            this.txtCnpj.TabIndex = 88;
            this.txtCnpj.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 150);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 87;
            this.materialLabel3.Text = "CNPJ";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Depth = 0;
            this.txtInscEstadual.Hint = "";
            this.txtInscEstadual.Location = new System.Drawing.Point(342, 182);
            this.txtInscEstadual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.PasswordChar = '\0';
            this.txtInscEstadual.SelectedText = "";
            this.txtInscEstadual.SelectionLength = 0;
            this.txtInscEstadual.SelectionStart = 0;
            this.txtInscEstadual.Size = new System.Drawing.Size(307, 23);
            this.txtInscEstadual.TabIndex = 90;
            this.txtInscEstadual.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(338, 150);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(132, 19);
            this.materialLabel4.TabIndex = 89;
            this.materialLabel4.Text = "Inscrição estadual";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 467);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtDdd2);
            this.Controls.Add(this.txtDdd1);
            this.Controls.Add(this.txtContato2);
            this.Controls.Add(this.txtContato1);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cbbCidade);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "Param";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnClose;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private System.Windows.Forms.ComboBox cbbCidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox cbbEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCEP;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogradouro;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDdd2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDdd1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContato2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContato1;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRazaoSocial;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFantasia;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCnpj;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInscEstadual;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
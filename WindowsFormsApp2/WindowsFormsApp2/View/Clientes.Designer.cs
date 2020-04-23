namespace WindowsFormsApp2.View
{
    partial class Clientes
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
            this.btnAtivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCPFCNPJ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.txtCEP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComplemento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRemove = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDdd2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDdd1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContato2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContato1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Depth = 0;
            this.btnAtivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnAtivo.Location = new System.Drawing.Point(263, 175);
            this.btnAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Ripple = true;
            this.btnAtivo.Size = new System.Drawing.Size(62, 30);
            this.btnAtivo.TabIndex = 0;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(998, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(63, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(16, 113);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(143, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Código";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(176, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(180, 113);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(240, 23);
            this.txtNome.TabIndex = 5;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(440, 81);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "CPF/CNPJ";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Depth = 0;
            this.txtCPFCNPJ.Hint = "";
            this.txtCPFCNPJ.Location = new System.Drawing.Point(444, 113);
            this.txtCPFCNPJ.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.PasswordChar = '\0';
            this.txtCPFCNPJ.SelectedText = "";
            this.txtCPFCNPJ.SelectionLength = 0;
            this.txtCPFCNPJ.SelectionStart = 0;
            this.txtCPFCNPJ.Size = new System.Drawing.Size(190, 23);
            this.txtCPFCNPJ.TabIndex = 7;
            this.txtCPFCNPJ.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(652, 81);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(656, 113);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(195, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(14, 526);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1047, 277);
            this.dgvClientes.TabIndex = 13;
            this.dgvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseClick);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 160);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(143, 19);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Data de nascimento";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(16, 192);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(221, 20);
            this.dtNascimento.TabIndex = 14;
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(310, 303);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(110, 21);
            this.cbbCidade.TabIndex = 61;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(306, 269);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(55, 19);
            this.materialLabel16.TabIndex = 60;
            this.materialLabel16.Text = "Cidade";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(180, 304);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(115, 21);
            this.cbbEstado.TabIndex = 59;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // txtCEP
            // 
            this.txtCEP.Depth = 0;
            this.txtCEP.Hint = "";
            this.txtCEP.Location = new System.Drawing.Point(17, 303);
            this.txtCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.Size = new System.Drawing.Size(142, 23);
            this.txtCEP.TabIndex = 58;
            this.txtCEP.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(13, 271);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(37, 19);
            this.materialLabel13.TabIndex = 57;
            this.materialLabel13.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Hint = "";
            this.txtComplemento.Location = new System.Drawing.Point(17, 367);
            this.txtComplemento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.Size = new System.Drawing.Size(264, 23);
            this.txtComplemento.TabIndex = 56;
            this.txtComplemento.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(13, 335);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(104, 19);
            this.materialLabel12.TabIndex = 55;
            this.materialLabel12.Text = "Complemento";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(181, 270);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(56, 19);
            this.materialLabel11.TabIndex = 54;
            this.materialLabel11.Text = "Estado";
            // 
            // txtBairro
            // 
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(444, 301);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(191, 23);
            this.txtBairro.TabIndex = 53;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(440, 269);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 52;
            this.materialLabel9.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(941, 301);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(120, 23);
            this.txtNumero.TabIndex = 51;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(937, 269);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(63, 19);
            this.materialLabel8.TabIndex = 50;
            this.materialLabel8.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Depth = 0;
            this.txtRua.Hint = "";
            this.txtRua.Location = new System.Drawing.Point(656, 301);
            this.txtRua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRua.Name = "txtRua";
            this.txtRua.PasswordChar = '\0';
            this.txtRua.SelectedText = "";
            this.txtRua.SelectionLength = 0;
            this.txtRua.SelectionStart = 0;
            this.txtRua.Size = new System.Drawing.Size(262, 23);
            this.txtRua.TabIndex = 49;
            this.txtRua.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(652, 269);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(34, 19);
            this.materialLabel7.TabIndex = 48;
            this.materialLabel7.Text = "Rua";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(8, 245);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1061, 2);
            this.materialDivider1.TabIndex = 62;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(176, 460);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 19);
            this.materialLabel10.TabIndex = 66;
            this.materialLabel10.Text = "Nome";
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(180, 492);
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(266, 23);
            this.materialSingleLineTextField6.TabIndex = 65;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(12, 460);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(57, 19);
            this.materialLabel14.TabIndex = 64;
            this.materialLabel14.Text = "Código";
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Hint = "";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(16, 492);
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(142, 23);
            this.materialSingleLineTextField7.TabIndex = 63;
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(455, 479);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton3.TabIndex = 67;
            this.materialFlatButton3.Text = "Buscar";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(3, 428);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1061, 2);
            this.materialDivider2.TabIndex = 68;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Depth = 0;
            this.btnRemove.Location = new System.Drawing.Point(837, 476);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = false;
            this.btnRemove.Size = new System.Drawing.Size(66, 36);
            this.btnRemove.TabIndex = 69;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // txtDdd2
            // 
            this.txtDdd2.Depth = 0;
            this.txtDdd2.Hint = "";
            this.txtDdd2.Location = new System.Drawing.Point(870, 183);
            this.txtDdd2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDdd2.Name = "txtDdd2";
            this.txtDdd2.PasswordChar = '\0';
            this.txtDdd2.SelectedText = "";
            this.txtDdd2.SelectionLength = 0;
            this.txtDdd2.SelectionStart = 0;
            this.txtDdd2.Size = new System.Drawing.Size(31, 23);
            this.txtDdd2.TabIndex = 74;
            this.txtDdd2.UseSystemPasswordChar = false;
            // 
            // txtDdd1
            // 
            this.txtDdd1.Depth = 0;
            this.txtDdd1.Hint = "";
            this.txtDdd1.Location = new System.Drawing.Point(868, 114);
            this.txtDdd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDdd1.Name = "txtDdd1";
            this.txtDdd1.PasswordChar = '\0';
            this.txtDdd1.SelectedText = "";
            this.txtDdd1.SelectionLength = 0;
            this.txtDdd1.SelectionStart = 0;
            this.txtDdd1.Size = new System.Drawing.Size(31, 23);
            this.txtDdd1.TabIndex = 73;
            this.txtDdd1.UseSystemPasswordChar = false;
            // 
            // txtContato2
            // 
            this.txtContato2.Depth = 0;
            this.txtContato2.Hint = "";
            this.txtContato2.Location = new System.Drawing.Point(911, 182);
            this.txtContato2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.PasswordChar = '\0';
            this.txtContato2.SelectedText = "";
            this.txtContato2.SelectionLength = 0;
            this.txtContato2.SelectionStart = 0;
            this.txtContato2.Size = new System.Drawing.Size(150, 23);
            this.txtContato2.TabIndex = 72;
            this.txtContato2.UseSystemPasswordChar = false;
            // 
            // txtContato1
            // 
            this.txtContato1.Depth = 0;
            this.txtContato1.Hint = "";
            this.txtContato1.Location = new System.Drawing.Point(905, 113);
            this.txtContato1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.PasswordChar = '\0';
            this.txtContato1.SelectedText = "";
            this.txtContato1.SelectionLength = 0;
            this.txtContato1.SelectionStart = 0;
            this.txtContato1.Size = new System.Drawing.Size(156, 23);
            this.txtContato1.TabIndex = 71;
            this.txtContato1.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(866, 79);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(75, 19);
            this.materialLabel17.TabIndex = 70;
            this.materialLabel17.Text = "Contato 1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(866, 149);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 75;
            this.materialLabel5.Text = "Contato 2";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(911, 476);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 816);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtDdd2);
            this.Controls.Add(this.txtDdd1);
            this.Controls.Add(this.txtContato2);
            this.Controls.Add(this.txtContato1);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialSingleLineTextField6);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialSingleLineTextField7);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cbbCidade);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCPFCNPJ);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAtivo);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox btnAtivo;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCPFCNPJ;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.ComboBox cbbCidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox cbbEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCEP;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialFlatButton btnRemove;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDdd2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDdd1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContato2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContato1;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
    }
}
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
            this.cbAtivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNomeBusca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRemove = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDdd2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDdd1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContato1 = new System.Windows.Forms.MaskedTextBox();
            this.txtContato2 = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.rdCPF = new System.Windows.Forms.RadioButton();
            this.rdCNPJ = new System.Windows.Forms.RadioButton();
            this.rdCNPJBusca = new System.Windows.Forms.RadioButton();
            this.rdCPFBusca = new System.Windows.Forms.RadioButton();
            this.txtCNPJBusca = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFBusca = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Depth = 0;
            this.cbAtivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbAtivo.Location = new System.Drawing.Point(263, 175);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.cbAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Ripple = true;
            this.cbAtivo.Size = new System.Drawing.Size(62, 30);
            this.cbAtivo.TabIndex = 0;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
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
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(16, 113);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(143, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseSystemPasswordChar = false;
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
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Nome*";
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
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "CPF/CNPJ*";
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
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "E-mail*";
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
            this.materialLabel10.Location = new System.Drawing.Point(235, 441);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 19);
            this.materialLabel10.TabIndex = 66;
            this.materialLabel10.Text = "Nome";
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Depth = 0;
            this.txtNomeBusca.Hint = "";
            this.txtNomeBusca.Location = new System.Drawing.Point(239, 499);
            this.txtNomeBusca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.PasswordChar = '\0';
            this.txtNomeBusca.SelectedText = "";
            this.txtNomeBusca.SelectionLength = 0;
            this.txtNomeBusca.SelectionStart = 0;
            this.txtNomeBusca.Size = new System.Drawing.Size(266, 23);
            this.txtNomeBusca.TabIndex = 65;
            this.txtNomeBusca.UseSystemPasswordChar = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(512, 486);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton3.TabIndex = 67;
            this.materialFlatButton3.Text = "Buscar";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
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
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(866, 79);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(81, 19);
            this.materialLabel17.TabIndex = 70;
            this.materialLabel17.Text = "Contato 1*";
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
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(17, 304);
            this.txtCEP.Mask = "#####-###";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(142, 20);
            this.txtCEP.TabIndex = 77;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(306, 267);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(61, 19);
            this.materialLabel16.TabIndex = 83;
            this.materialLabel16.Text = "Cidade*";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(13, 269);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(43, 19);
            this.materialLabel13.TabIndex = 82;
            this.materialLabel13.Text = "CEP*";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(176, 268);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(62, 19);
            this.materialLabel11.TabIndex = 81;
            this.materialLabel11.Text = "Estado*";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(440, 267);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(55, 19);
            this.materialLabel9.TabIndex = 80;
            this.materialLabel9.Text = "Bairro*";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(937, 267);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 19);
            this.materialLabel8.TabIndex = 79;
            this.materialLabel8.Text = "Número*";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(652, 267);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(40, 19);
            this.materialLabel7.TabIndex = 78;
            this.materialLabel7.Text = "Rua*";
            // 
            // txtContato1
            // 
            this.txtContato1.Location = new System.Drawing.Point(911, 116);
            this.txtContato1.Mask = "#####-####";
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.Size = new System.Drawing.Size(142, 20);
            this.txtContato1.TabIndex = 84;
            // 
            // txtContato2
            // 
            this.txtContato2.Location = new System.Drawing.Point(911, 185);
            this.txtContato2.Mask = "#####-####";
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.Size = new System.Drawing.Size(142, 20);
            this.txtContato2.TabIndex = 85;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(441, 142);
            this.txtCPF.Mask = "###.###.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(190, 20);
            this.txtCPF.TabIndex = 86;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(441, 142);
            this.txtCNPJ.Mask = "##.###.###/####-##";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(190, 20);
            this.txtCNPJ.TabIndex = 87;
            // 
            // rdCPF
            // 
            this.rdCPF.AutoSize = true;
            this.rdCPF.Checked = true;
            this.rdCPF.Location = new System.Drawing.Point(440, 116);
            this.rdCPF.Name = "rdCPF";
            this.rdCPF.Size = new System.Drawing.Size(89, 17);
            this.rdCPF.TabIndex = 88;
            this.rdCPF.TabStop = true;
            this.rdCPF.Text = "Pessoa física";
            this.rdCPF.UseVisualStyleBackColor = true;
            this.rdCPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // rdCNPJ
            // 
            this.rdCNPJ.AutoSize = true;
            this.rdCNPJ.Location = new System.Drawing.Point(538, 116);
            this.rdCNPJ.Name = "rdCNPJ";
            this.rdCNPJ.Size = new System.Drawing.Size(98, 17);
            this.rdCNPJ.TabIndex = 89;
            this.rdCNPJ.Text = "Pessoa jurídica";
            this.rdCNPJ.UseVisualStyleBackColor = true;
            this.rdCNPJ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // rdCNPJBusca
            // 
            this.rdCNPJBusca.AutoSize = true;
            this.rdCNPJBusca.Location = new System.Drawing.Point(114, 473);
            this.rdCNPJBusca.Name = "rdCNPJBusca";
            this.rdCNPJBusca.Size = new System.Drawing.Size(98, 17);
            this.rdCNPJBusca.TabIndex = 94;
            this.rdCNPJBusca.Text = "Pessoa jurídica";
            this.rdCNPJBusca.UseVisualStyleBackColor = true;
            this.rdCNPJBusca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdCNPJBusca_MouseClick);
            // 
            // rdCPFBusca
            // 
            this.rdCPFBusca.AutoSize = true;
            this.rdCPFBusca.Checked = true;
            this.rdCPFBusca.Location = new System.Drawing.Point(19, 473);
            this.rdCPFBusca.Name = "rdCPFBusca";
            this.rdCPFBusca.Size = new System.Drawing.Size(89, 17);
            this.rdCPFBusca.TabIndex = 93;
            this.rdCPFBusca.TabStop = true;
            this.rdCPFBusca.Text = "Pessoa física";
            this.rdCPFBusca.UseVisualStyleBackColor = true;
            this.rdCPFBusca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdCPFBusca_MouseClick);
            // 
            // txtCNPJBusca
            // 
            this.txtCNPJBusca.Location = new System.Drawing.Point(21, 500);
            this.txtCNPJBusca.Mask = "##.###.###/####-##";
            this.txtCNPJBusca.Name = "txtCNPJBusca";
            this.txtCNPJBusca.Size = new System.Drawing.Size(190, 20);
            this.txtCNPJBusca.TabIndex = 92;
            // 
            // txtCPFBusca
            // 
            this.txtCPFBusca.Location = new System.Drawing.Point(21, 502);
            this.txtCPFBusca.Mask = "###.###.###-##";
            this.txtCPFBusca.Name = "txtCPFBusca";
            this.txtCPFBusca.Size = new System.Drawing.Size(190, 20);
            this.txtCPFBusca.TabIndex = 91;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(20, 441);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(86, 19);
            this.materialLabel15.TabIndex = 90;
            this.materialLabel15.Text = "CPF/CNPJ*";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 816);
            this.Controls.Add(this.rdCNPJBusca);
            this.Controls.Add(this.rdCPFBusca);
            this.Controls.Add(this.txtCNPJBusca);
            this.Controls.Add(this.txtCPFBusca);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.rdCNPJ);
            this.Controls.Add(this.rdCPF);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtContato2);
            this.Controls.Add(this.txtContato1);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtDdd2);
            this.Controls.Add(this.txtDdd1);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtNomeBusca);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cbbCidade);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbAtivo);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox cbAtivo;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeBusca;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialFlatButton btnRemove;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDdd2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDdd1;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.MaskedTextBox txtContato1;
        private System.Windows.Forms.MaskedTextBox txtContato2;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.RadioButton rdCPF;
        private System.Windows.Forms.RadioButton rdCNPJ;
        private System.Windows.Forms.RadioButton rdCNPJBusca;
        private System.Windows.Forms.RadioButton rdCPFBusca;
        private System.Windows.Forms.MaskedTextBox txtCNPJBusca;
        private System.Windows.Forms.MaskedTextBox txtCPFBusca;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
    }
}
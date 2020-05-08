namespace WindowsFormsApp2.View
{
    partial class GerenciarFuncionarios
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegistro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblDtDemissao = new MaterialSkin.Controls.MaterialLabel();
            this.dtDemissao = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.cbUserAtivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.rdNivel1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdNivel2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComplemento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.btnInsert = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnBuscar2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBuscarRegistro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.cbDemitir = new MaterialSkin.Controls.MaterialCheckBox();
            this.gbNivelAcesso = new System.Windows.Forms.GroupBox();
            this.cbbCargo = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtBuscarNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtContato1 = new System.Windows.Forms.MaskedTextBox();
            this.txtContato2 = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDdd1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDdd2 = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtRg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbNivelAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(19, 125);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(281, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Depth = 0;
            this.txtRegistro.Hint = "";
            this.txtRegistro.Location = new System.Drawing.Point(337, 125);
            this.txtRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.PasswordChar = '\0';
            this.txtRegistro.SelectedText = "";
            this.txtRegistro.SelectionLength = 0;
            this.txtRegistro.SelectionStart = 0;
            this.txtRegistro.Size = new System.Drawing.Size(175, 23);
            this.txtRegistro.TabIndex = 2;
            this.txtRegistro.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(333, 99);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(153, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Registro (CAU/CREA)";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(337, 219);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(92, 22);
            this.dtNascimento.TabIndex = 5;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(333, 193);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(143, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Data de nascimento";
            // 
            // lblDtDemissao
            // 
            this.lblDtDemissao.AutoSize = true;
            this.lblDtDemissao.Depth = 0;
            this.lblDtDemissao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDtDemissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtDemissao.Location = new System.Drawing.Point(847, 346);
            this.lblDtDemissao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtDemissao.Name = "lblDtDemissao";
            this.lblDtDemissao.Size = new System.Drawing.Size(130, 19);
            this.lblDtDemissao.TabIndex = 9;
            this.lblDtDemissao.Text = "Data da demissão";
            // 
            // dtDemissao
            // 
            this.dtDemissao.Enabled = false;
            this.dtDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDemissao.Location = new System.Drawing.Point(852, 371);
            this.dtDemissao.Name = "dtDemissao";
            this.dtDemissao.Size = new System.Drawing.Size(163, 22);
            this.dtDemissao.TabIndex = 24;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(656, 345);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(130, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Data de admissão";
            // 
            // dtAdmissao
            // 
            this.dtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdmissao.Location = new System.Drawing.Point(661, 371);
            this.dtAdmissao.Name = "dtAdmissao";
            this.dtAdmissao.Size = new System.Drawing.Size(163, 22);
            this.dtAdmissao.TabIndex = 23;
            // 
            // cbUserAtivo
            // 
            this.cbUserAtivo.AutoSize = true;
            this.cbUserAtivo.Depth = 0;
            this.cbUserAtivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbUserAtivo.Location = new System.Drawing.Point(401, 456);
            this.cbUserAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.cbUserAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbUserAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbUserAtivo.Name = "cbUserAtivo";
            this.cbUserAtivo.Ripple = true;
            this.cbUserAtivo.Size = new System.Drawing.Size(123, 30);
            this.cbUserAtivo.TabIndex = 100;
            this.cbUserAtivo.Text = "Usuário Ativo ?";
            this.cbUserAtivo.UseVisualStyleBackColor = true;
            // 
            // rdNivel1
            // 
            this.rdNivel1.AutoSize = true;
            this.rdNivel1.Depth = 0;
            this.rdNivel1.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdNivel1.Location = new System.Drawing.Point(7, 18);
            this.rdNivel1.Margin = new System.Windows.Forms.Padding(0);
            this.rdNivel1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNivel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdNivel1.Name = "rdNivel1";
            this.rdNivel1.Ripple = true;
            this.rdNivel1.Size = new System.Drawing.Size(72, 30);
            this.rdNivel1.TabIndex = 100;
            this.rdNivel1.TabStop = true;
            this.rdNivel1.Text = "Master";
            this.rdNivel1.UseVisualStyleBackColor = true;
            // 
            // rdNivel2
            // 
            this.rdNivel2.AutoSize = true;
            this.rdNivel2.Depth = 0;
            this.rdNivel2.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdNivel2.Location = new System.Drawing.Point(104, 18);
            this.rdNivel2.Margin = new System.Windows.Forms.Padding(0);
            this.rdNivel2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNivel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdNivel2.Name = "rdNivel2";
            this.rdNivel2.Ripple = true;
            this.rdNivel2.Size = new System.Drawing.Size(74, 30);
            this.rdNivel2.TabIndex = 100;
            this.rdNivel2.TabStop = true;
            this.rdNivel2.Text = "Normal";
            this.rdNivel2.UseVisualStyleBackColor = true;
            // 
            // txtRua
            // 
            this.txtRua.Depth = 0;
            this.txtRua.Hint = "";
            this.txtRua.Location = new System.Drawing.Point(766, 124);
            this.txtRua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRua.Name = "txtRua";
            this.txtRua.PasswordChar = '\0';
            this.txtRua.SelectedText = "";
            this.txtRua.SelectionLength = 0;
            this.txtRua.SelectionStart = 0;
            this.txtRua.Size = new System.Drawing.Size(301, 23);
            this.txtRua.TabIndex = 11;
            this.txtRua.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(764, 99);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(34, 19);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(1094, 124);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(79, 23);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(1090, 99);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(63, 19);
            this.materialLabel8.TabIndex = 20;
            this.materialLabel8.Text = "Número";
            // 
            // txtBairro
            // 
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(768, 190);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(160, 23);
            this.txtBairro.TabIndex = 13;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(764, 164);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Bairro";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(903, 242);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(56, 19);
            this.materialLabel11.TabIndex = 26;
            this.materialLabel11.Text = "Estado";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Hint = "";
            this.txtComplemento.Location = new System.Drawing.Point(964, 189);
            this.txtComplemento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.Size = new System.Drawing.Size(209, 23);
            this.txtComplemento.TabIndex = 14;
            this.txtComplemento.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(963, 164);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(104, 19);
            this.materialLabel12.TabIndex = 28;
            this.materialLabel12.Text = "Complemento";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(764, 242);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(37, 19);
            this.materialLabel13.TabIndex = 30;
            this.materialLabel13.Text = "CEP";
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Depth = 0;
            this.btnInsert.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(660, 421);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = false;
            this.btnInsert.Size = new System.Drawing.Size(91, 36);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Cadastrar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnCadastrar);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Depth = 0;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1043, 464);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(59, 36);
            this.btnEdit.TabIndex = 90;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEditar);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Depth = 0;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1043, 506);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = false;
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 91;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemover);
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.AutoSize = true;
            this.BtnBuscar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar2.Depth = 0;
            this.BtnBuscar2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar2.Location = new System.Drawing.Point(660, 509);
            this.BtnBuscar2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.BtnBuscar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Primary = false;
            this.BtnBuscar2.Size = new System.Drawing.Size(65, 36);
            this.BtnBuscar2.TabIndex = 82;
            this.BtnBuscar2.Text = "Buscar";
            this.BtnBuscar2.UseVisualStyleBackColor = true;
            this.BtnBuscar2.Click += new System.EventHandler(this.btnBuscar);
            // 
            // txtBuscarRegistro
            // 
            this.txtBuscarRegistro.Depth = 0;
            this.txtBuscarRegistro.Hint = "Buscar por Registro (CAU/CREA)";
            this.txtBuscarRegistro.Location = new System.Drawing.Point(339, 522);
            this.txtBuscarRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarRegistro.Name = "txtBuscarRegistro";
            this.txtBuscarRegistro.PasswordChar = '\0';
            this.txtBuscarRegistro.SelectedText = "";
            this.txtBuscarRegistro.SelectionLength = 0;
            this.txtBuscarRegistro.SelectionStart = 0;
            this.txtBuscarRegistro.Size = new System.Drawing.Size(289, 23);
            this.txtBuscarRegistro.TabIndex = 81;
            this.txtBuscarRegistro.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "";
            this.txtLogin.Location = new System.Drawing.Point(21, 385);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(341, 23);
            this.txtLogin.TabIndex = 18;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(21, 360);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(46, 19);
            this.materialLabel14.TabIndex = 37;
            this.materialLabel14.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(19, 464);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(341, 23);
            this.txtSenha.TabIndex = 19;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(21, 438);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(50, 19);
            this.materialLabel15.TabIndex = 39;
            this.materialLabel15.Text = "Senha";
            // 
            // cbDemitir
            // 
            this.cbDemitir.AutoSize = true;
            this.cbDemitir.Depth = 0;
            this.cbDemitir.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbDemitir.Location = new System.Drawing.Point(563, 456);
            this.cbDemitir.Margin = new System.Windows.Forms.Padding(0);
            this.cbDemitir.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbDemitir.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbDemitir.Name = "cbDemitir";
            this.cbDemitir.Ripple = true;
            this.cbDemitir.Size = new System.Drawing.Size(75, 30);
            this.cbDemitir.TabIndex = 23;
            this.cbDemitir.Text = "Demitir";
            this.cbDemitir.UseVisualStyleBackColor = true;
            // 
            // gbNivelAcesso
            // 
            this.gbNivelAcesso.Controls.Add(this.rdNivel2);
            this.gbNivelAcesso.Controls.Add(this.rdNivel1);
            this.gbNivelAcesso.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.gbNivelAcesso.Location = new System.Drawing.Point(394, 359);
            this.gbNivelAcesso.Name = "gbNivelAcesso";
            this.gbNivelAcesso.Size = new System.Drawing.Size(201, 65);
            this.gbNivelAcesso.TabIndex = 20;
            this.gbNivelAcesso.TabStop = false;
            this.gbNivelAcesso.Text = "Nível de acesso";
            // 
            // cbbCargo
            // 
            this.cbbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.Location = new System.Drawing.Point(12, 295);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.Size = new System.Drawing.Size(140, 23);
            this.cbbCargo.TabIndex = 6;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(11, 271);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(49, 19);
            this.materialLabel6.TabIndex = 44;
            this.materialLabel6.Text = "Cargo";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(905, 268);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(140, 23);
            this.cbbEstado.TabIndex = 16;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(1075, 266);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(140, 23);
            this.cbbCidade.TabIndex = 17;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(1073, 241);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(55, 19);
            this.materialLabel16.TabIndex = 46;
            this.materialLabel16.Text = "Cidade";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(193, 266);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(92, 19);
            this.materialLabel17.TabIndex = 48;
            this.materialLabel17.Text = "Num Celular";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(14, 556);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(1226, 193);
            this.dgvFuncionarios.TabIndex = 54;
            this.dgvFuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuncionarios_CellMouseClick);
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Depth = 0;
            this.txtBuscarNome.Hint = "Buscar por Nome...";
            this.txtBuscarNome.Location = new System.Drawing.Point(21, 522);
            this.txtBuscarNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.PasswordChar = '\0';
            this.txtBuscarNome.SelectedText = "";
            this.txtBuscarNome.SelectionLength = 0;
            this.txtBuscarNome.SelectionStart = 0;
            this.txtBuscarNome.Size = new System.Drawing.Size(264, 23);
            this.txtBuscarNome.TabIndex = 80;
            this.txtBuscarNome.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(1144, 508);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(1144, 464);
            this.btnListar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = false;
            this.btnListar.Size = new System.Drawing.Size(58, 36);
            this.btnListar.TabIndex = 59;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.listarFuncionarios);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(765, 268);
            this.txtCEP.Mask = "#####-###";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(116, 22);
            this.txtCEP.TabIndex = 15;
            // 
            // txtContato1
            // 
            this.txtContato1.Location = new System.Drawing.Point(237, 295);
            this.txtContato1.Mask = "#####-####";
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.Size = new System.Drawing.Size(84, 22);
            this.txtContato1.TabIndex = 8;
            // 
            // txtContato2
            // 
            this.txtContato2.Location = new System.Drawing.Point(389, 292);
            this.txtContato2.Mask = "####-####";
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.Size = new System.Drawing.Size(75, 22);
            this.txtContato2.TabIndex = 10;
            this.txtContato2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtContato2_MaskInputRejected);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(15, 220);
            this.txtCpf.Mask = "###.###.###-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(124, 22);
            this.txtCpf.TabIndex = 3;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(10, 194);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(36, 19);
            this.materialLabel18.TabIndex = 64;
            this.materialLabel18.Text = "CPF";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(154, 194);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(28, 19);
            this.materialLabel19.TabIndex = 66;
            this.materialLabel19.Text = "RG";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(345, 263);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(127, 19);
            this.materialLabel20.TabIndex = 67;
            this.materialLabel20.Text = "Num Telefone Fix";
            // 
            // txtDdd1
            // 
            this.txtDdd1.Location = new System.Drawing.Point(198, 295);
            this.txtDdd1.Mask = "###";
            this.txtDdd1.Name = "txtDdd1";
            this.txtDdd1.Size = new System.Drawing.Size(32, 22);
            this.txtDdd1.TabIndex = 7;
            // 
            // txtDdd2
            // 
            this.txtDdd2.Location = new System.Drawing.Point(349, 292);
            this.txtDdd2.Mask = "###";
            this.txtDdd2.Name = "txtDdd2";
            this.txtDdd2.Size = new System.Drawing.Size(32, 22);
            this.txtDdd2.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Location = new System.Drawing.Point(660, 464);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = false;
            this.btnLimpar.Size = new System.Drawing.Size(62, 36);
            this.btnLimpar.TabIndex = 70;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.limparTela);
            // 
            // txtRg
            // 
            this.txtRg.Depth = 0;
            this.txtRg.Hint = "";
            this.txtRg.Location = new System.Drawing.Point(158, 219);
            this.txtRg.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRg.Name = "txtRg";
            this.txtRg.PasswordChar = '\0';
            this.txtRg.SelectedText = "";
            this.txtRg.SelectionLength = 0;
            this.txtRg.SelectionStart = 0;
            this.txtRg.Size = new System.Drawing.Size(115, 23);
            this.txtRg.TabIndex = 4;
            this.txtRg.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(346, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 93;
            this.label1.Text = "[ Campo não obrigatório ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(334, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 14);
            this.label2.TabIndex = 94;
            this.label2.Text = "[ Campo não obrigatório ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(964, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 14);
            this.label3.TabIndex = 101;
            this.label3.Text = "[ Campo não obrigatório ]";
            // 
            // GerenciarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 763);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDdd2);
            this.Controls.Add(this.txtDdd1);
            this.Controls.Add(this.materialLabel20);
            this.Controls.Add(this.materialLabel19);
            this.Controls.Add(this.materialLabel18);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtContato2);
            this.Controls.Add(this.txtContato1);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.cbbCidade);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.cbbCargo);
            this.Controls.Add(this.gbNivelAcesso);
            this.Controls.Add(this.cbDemitir);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.txtBuscarRegistro);
            this.Controls.Add(this.BtnBuscar2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
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
            this.Controls.Add(this.cbUserAtivo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dtAdmissao);
            this.Controls.Add(this.lblDtDemissao);
            this.Controls.Add(this.dtDemissao);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.Name = "GerenciarFuncionarios";
            this.Text = "Gerenciar Funcionarios";
            this.gbNivelAcesso.ResumeLayout(false);
            this.gbNivelAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegistro;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblDtDemissao;
        private System.Windows.Forms.DateTimePicker dtDemissao;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtAdmissao;
        private MaterialSkin.Controls.MaterialCheckBox cbUserAtivo;
        private MaterialSkin.Controls.MaterialRadioButton rdNivel1;
        private MaterialSkin.Controls.MaterialRadioButton rdNivel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialFlatButton btnInsert;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnRemove;
        private MaterialSkin.Controls.MaterialFlatButton BtnBuscar2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarRegistro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialCheckBox cbDemitir;
        private System.Windows.Forms.GroupBox gbNivelAcesso;
        private System.Windows.Forms.ComboBox cbbCargo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarNome;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtContato1;
        private System.Windows.Forms.MaskedTextBox txtContato2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private System.Windows.Forms.MaskedTextBox txtDdd1;
        private System.Windows.Forms.MaskedTextBox txtDdd2;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
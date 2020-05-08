namespace WindowsFormsApp2.View
{
    partial class IniciarObra
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
            this.objCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvBuscarEtapas = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvTarefasBuscadas = new System.Windows.Forms.DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvObras = new System.Windows.Forms.DataGridView();
            this.btnBuscarEngenheiro = new MaterialSkin.Controls.MaterialFlatButton();
            this.objEngenheiro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDataPrevTermino = new System.Windows.Forms.DateTimePicker();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComplemento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvTarefasSelecionadas = new System.Windows.Forms.DataGridView();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescricaoObra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEtapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasBuscadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasSelecionadas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // objCliente
            // 
            this.objCliente.Depth = 0;
            this.objCliente.Hint = "Cliente da obra";
            this.objCliente.Location = new System.Drawing.Point(26, 19);
            this.objCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.objCliente.Name = "objCliente";
            this.objCliente.PasswordChar = '\0';
            this.objCliente.SelectedText = "";
            this.objCliente.SelectionLength = 0;
            this.objCliente.SelectionStart = 0;
            this.objCliente.Size = new System.Drawing.Size(281, 23);
            this.objCliente.TabIndex = 7;
            this.objCliente.UseSystemPasswordChar = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Location = new System.Drawing.Point(314, 6);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = false;
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dgvBuscarEtapas
            // 
            this.dgvBuscarEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarEtapas.Location = new System.Drawing.Point(13, 47);
            this.dgvBuscarEtapas.Name = "dgvBuscarEtapas";
            this.dgvBuscarEtapas.Size = new System.Drawing.Size(201, 150);
            this.dgvBuscarEtapas.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(262, 25);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Tarefas";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Nome da etapa";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(13, 21);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(139, 23);
            this.materialSingleLineTextField1.TabIndex = 13;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // dgvTarefasBuscadas
            // 
            this.dgvTarefasBuscadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasBuscadas.Location = new System.Drawing.Point(221, 47);
            this.dgvTarefasBuscadas.Name = "dgvTarefasBuscadas";
            this.dgvTarefasBuscadas.Size = new System.Drawing.Size(149, 150);
            this.dgvTarefasBuscadas.TabIndex = 14;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(455, 27);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(153, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Tarefas selecionadas";
            // 
            // dgvObras
            // 
            this.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObras.Location = new System.Drawing.Point(16, 438);
            this.dgvObras.Name = "dgvObras";
            this.dgvObras.Size = new System.Drawing.Size(732, 116);
            this.dgvObras.TabIndex = 21;
            // 
            // btnBuscarEngenheiro
            // 
            this.btnBuscarEngenheiro.AutoSize = true;
            this.btnBuscarEngenheiro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEngenheiro.Depth = 0;
            this.btnBuscarEngenheiro.Location = new System.Drawing.Point(314, 44);
            this.btnBuscarEngenheiro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarEngenheiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEngenheiro.Name = "btnBuscarEngenheiro";
            this.btnBuscarEngenheiro.Primary = false;
            this.btnBuscarEngenheiro.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarEngenheiro.TabIndex = 23;
            this.btnBuscarEngenheiro.Text = "Buscar";
            this.btnBuscarEngenheiro.UseVisualStyleBackColor = true;
            // 
            // objEngenheiro
            // 
            this.objEngenheiro.Depth = 0;
            this.objEngenheiro.Hint = "Engenheiro da obra";
            this.objEngenheiro.Location = new System.Drawing.Point(26, 57);
            this.objEngenheiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.objEngenheiro.Name = "objEngenheiro";
            this.objEngenheiro.PasswordChar = '\0';
            this.objEngenheiro.SelectedText = "";
            this.objEngenheiro.SelectionLength = 0;
            this.objEngenheiro.SelectionStart = 0;
            this.objEngenheiro.Size = new System.Drawing.Size(281, 23);
            this.objEngenheiro.TabIndex = 22;
            this.objEngenheiro.UseSystemPasswordChar = false;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(169, 44);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpDataInicio.TabIndex = 24;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(165, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Data de início";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(506, 22);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 27;
            this.materialLabel6.Text = "Data de fim";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(511, 44);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(103, 20);
            this.dtpDataFim.TabIndex = 26;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(296, 22);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(199, 19);
            this.materialLabel7.TabIndex = 29;
            this.materialLabel7.Text = "Data prevista para o término";
            // 
            // dtpDataPrevTermino
            // 
            this.dtpDataPrevTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrevTermino.Location = new System.Drawing.Point(300, 44);
            this.dtpDataPrevTermino.Name = "dtpDataPrevTermino";
            this.dtpDataPrevTermino.Size = new System.Drawing.Size(103, 20);
            this.dtpDataPrevTermino.TabIndex = 28;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(13, 27);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbbStatus.TabIndex = 30;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(9, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(89, 19);
            this.materialLabel8.TabIndex = 31;
            this.materialLabel8.Text = "Status atual";
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(434, 402);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton5.TabIndex = 33;
            this.materialFlatButton5.Text = "Buscar";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Filtro por endereço";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(17, 409);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(193, 23);
            this.materialSingleLineTextField3.TabIndex = 32;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "Filtro por nome de cliente";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(218, 409);
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(198, 23);
            this.materialSingleLineTextField4.TabIndex = 34;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(594, 402);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(71, 36);
            this.materialFlatButton6.TabIndex = 35;
            this.materialFlatButton6.Text = "Alterar";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Location = new System.Drawing.Point(523, 402);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton7.TabIndex = 36;
            this.materialFlatButton7.Text = "Inserir";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(209, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 14);
            this.label3.TabIndex = 116;
            this.label3.Text = "[ Campo não obrigatório ]";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(10, 179);
            this.txtCEP.Mask = "#####-###";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(116, 20);
            this.txtCEP.TabIndex = 106;
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(322, 178);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(140, 21);
            this.cbbCidade.TabIndex = 108;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(318, 153);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(55, 19);
            this.materialLabel16.TabIndex = 115;
            this.materialLabel16.Text = "Cidade";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(150, 179);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(140, 21);
            this.cbbEstado.TabIndex = 107;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(9, 153);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(37, 19);
            this.materialLabel13.TabIndex = 114;
            this.materialLabel13.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Hint = "";
            this.txtComplemento.Location = new System.Drawing.Point(209, 100);
            this.txtComplemento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.Size = new System.Drawing.Size(209, 23);
            this.txtComplemento.TabIndex = 105;
            this.txtComplemento.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(208, 75);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(104, 19);
            this.materialLabel12.TabIndex = 113;
            this.materialLabel12.Text = "Complemento";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(148, 153);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(56, 19);
            this.materialLabel11.TabIndex = 112;
            this.materialLabel11.Text = "Estado";
            // 
            // txtBairro
            // 
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(13, 101);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(160, 23);
            this.txtBairro.TabIndex = 104;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(9, 75);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 111;
            this.materialLabel9.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(339, 35);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(79, 23);
            this.txtNumero.TabIndex = 103;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(335, 10);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 110;
            this.materialLabel4.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Depth = 0;
            this.txtRua.Hint = "";
            this.txtRua.Location = new System.Drawing.Point(11, 35);
            this.txtRua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRua.Name = "txtRua";
            this.txtRua.PasswordChar = '\0';
            this.txtRua.SelectedText = "";
            this.txtRua.SelectionLength = 0;
            this.txtRua.SelectionStart = 0;
            this.txtRua.Size = new System.Drawing.Size(301, 23);
            this.txtRua.TabIndex = 102;
            this.txtRua.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(9, 10);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(34, 19);
            this.materialLabel10.TabIndex = 109;
            this.materialLabel10.Text = "Rua";
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(149, 10);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton8.TabIndex = 117;
            this.materialFlatButton8.Text = "Buscar";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            // 
            // dgvTarefasSelecionadas
            // 
            this.dgvTarefasSelecionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasSelecionadas.Location = new System.Drawing.Point(457, 47);
            this.dgvTarefasSelecionadas.Name = "dgvTarefasSelecionadas";
            this.dgvTarefasSelecionadas.Size = new System.Drawing.Size(151, 150);
            this.dgvTarefasSelecionadas.TabIndex = 118;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Location = new System.Drawing.Point(666, 402);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(82, 36);
            this.materialFlatButton9.TabIndex = 119;
            this.materialFlatButton9.Text = "Cancelar";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 120;
            this.button1.Text = "Inserir >>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 121;
            this.button2.Text = "<< Remover";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.objCliente);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.objEngenheiro);
            this.panel1.Controls.Add(this.btnBuscarEngenheiro);
            this.panel1.Location = new System.Drawing.Point(17, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 92);
            this.panel1.TabIndex = 122;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.txtRua);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.materialLabel11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.materialLabel12);
            this.panel2.Controls.Add(this.txtCEP);
            this.panel2.Controls.Add(this.txtComplemento);
            this.panel2.Controls.Add(this.cbbCidade);
            this.panel2.Controls.Add(this.materialLabel13);
            this.panel2.Controls.Add(this.materialLabel16);
            this.panel2.Controls.Add(this.cbbEstado);
            this.panel2.Location = new System.Drawing.Point(17, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 222);
            this.panel2.TabIndex = 123;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialLabel14);
            this.panel3.Controls.Add(this.materialSingleLineTextField2);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.dtpDataInicio);
            this.panel3.Controls.Add(this.dtpDataFim);
            this.panel3.Controls.Add(this.materialLabel6);
            this.panel3.Controls.Add(this.dtpDataPrevTermino);
            this.panel3.Controls.Add(this.materialLabel7);
            this.panel3.Controls.Add(this.cbbStatus);
            this.panel3.Controls.Add(this.materialLabel8);
            this.panel3.Location = new System.Drawing.Point(523, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 92);
            this.panel3.TabIndex = 124;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.materialSingleLineTextField1);
            this.panel4.Controls.Add(this.dgvBuscarEtapas);
            this.panel4.Controls.Add(this.materialLabel3);
            this.panel4.Controls.Add(this.dgvTarefasBuscadas);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.materialLabel5);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.materialFlatButton8);
            this.panel4.Controls.Add(this.dgvTarefasSelecionadas);
            this.panel4.Location = new System.Drawing.Point(523, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(618, 222);
            this.panel4.TabIndex = 125;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(786, 410);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 127;
            this.materialLabel2.Text = "Descrição da obra";
            // 
            // txtDescricaoObra
            // 
            this.txtDescricaoObra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescricaoObra.Location = new System.Drawing.Point(778, 438);
            this.txtDescricaoObra.Multiline = true;
            this.txtDescricaoObra.Name = "txtDescricaoObra";
            this.txtDescricaoObra.Size = new System.Drawing.Size(363, 102);
            this.txtDescricaoObra.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(780, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 117;
            this.label1.Text = "[ Campo não obrigatório ]";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(9, 61);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(45, 19);
            this.materialLabel14.TabIndex = 112;
            this.materialLabel14.Text = "Valor";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(60, 57);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(79, 23);
            this.materialSingleLineTextField2.TabIndex = 111;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // IniciarObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricaoObra);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialFlatButton9);
            this.Controls.Add(this.materialFlatButton7);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.dgvObras);
            this.Name = "IniciarObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEtapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasBuscadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasSelecionadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField objCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvBuscarEtapas;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.DataGridView dgvTarefasBuscadas;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgvObras;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarEngenheiro;
        private MaterialSkin.Controls.MaterialSingleLineTextField objEngenheiro;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtpDataPrevTermino;
        private System.Windows.Forms.ComboBox cbbStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.ComboBox cbbCidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox cbbEstado;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private System.Windows.Forms.DataGridView dgvTarefasSelecionadas;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtDescricaoObra;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    }
}
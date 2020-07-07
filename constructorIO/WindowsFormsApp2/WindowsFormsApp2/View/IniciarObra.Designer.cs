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
            this.dgvEtapasDisponiveis = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarEtapa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvTarefasDisponiveis = new System.Windows.Forms.DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarEngenheiro = new MaterialSkin.Controls.MaterialFlatButton();
            this.objFuncionario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataFim = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDataPrevTermino = new System.Windows.Forms.DateTimePicker();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarObra = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBuscarObraEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarObraClienteNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAlterar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInserir = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.btnBuscarEtapa = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvTarefasSelecionadas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoObra = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInserirTarefa = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemoverTarefa = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvObras = new System.Windows.Forms.DataGridView();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapasDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasSelecionadas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).BeginInit();
            this.SuspendLayout();
            // 
            // objCliente
            // 
            this.objCliente.Depth = 0;
            this.objCliente.Enabled = false;
            this.objCliente.Hint = "";
            this.objCliente.Location = new System.Drawing.Point(109, 19);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(397, 6);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = false;
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.onClickBuscarCliente);
            // 
            // dgvEtapasDisponiveis
            // 
            this.dgvEtapasDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapasDisponiveis.Location = new System.Drawing.Point(13, 47);
            this.dgvEtapasDisponiveis.Name = "dgvEtapasDisponiveis";
            this.dgvEtapasDisponiveis.Size = new System.Drawing.Size(253, 150);
            this.dgvEtapasDisponiveis.TabIndex = 9;
            this.dgvEtapasDisponiveis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnClickEtapaDisponiveisGrid);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(353, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Tarefas";
            // 
            // txtBuscarEtapa
            // 
            this.txtBuscarEtapa.Depth = 0;
            this.txtBuscarEtapa.Hint = "Nome da etapa";
            this.txtBuscarEtapa.Location = new System.Drawing.Point(13, 21);
            this.txtBuscarEtapa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEtapa.Name = "txtBuscarEtapa";
            this.txtBuscarEtapa.PasswordChar = '\0';
            this.txtBuscarEtapa.SelectedText = "";
            this.txtBuscarEtapa.SelectionLength = 0;
            this.txtBuscarEtapa.SelectionStart = 0;
            this.txtBuscarEtapa.Size = new System.Drawing.Size(139, 23);
            this.txtBuscarEtapa.TabIndex = 12;
            this.txtBuscarEtapa.UseSystemPasswordChar = false;
            // 
            // dgvTarefasDisponiveis
            // 
            this.dgvTarefasDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasDisponiveis.Location = new System.Drawing.Point(272, 47);
            this.dgvTarefasDisponiveis.Name = "dgvTarefasDisponiveis";
            this.dgvTarefasDisponiveis.Size = new System.Drawing.Size(240, 150);
            this.dgvTarefasDisponiveis.TabIndex = 14;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(577, 25);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(153, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Tarefas selecionadas";
            // 
            // btnBuscarEngenheiro
            // 
            this.btnBuscarEngenheiro.AutoSize = true;
            this.btnBuscarEngenheiro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEngenheiro.Depth = 0;
            this.btnBuscarEngenheiro.Location = new System.Drawing.Point(397, 44);
            this.btnBuscarEngenheiro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarEngenheiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEngenheiro.Name = "btnBuscarEngenheiro";
            this.btnBuscarEngenheiro.Primary = false;
            this.btnBuscarEngenheiro.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarEngenheiro.TabIndex = 2;
            this.btnBuscarEngenheiro.Text = "Buscar";
            this.btnBuscarEngenheiro.UseVisualStyleBackColor = true;
            this.btnBuscarEngenheiro.Click += new System.EventHandler(this.onClickBuscarResponsavel);
            // 
            // objFuncionario
            // 
            this.objFuncionario.Depth = 0;
            this.objFuncionario.Enabled = false;
            this.objFuncionario.Hint = "";
            this.objFuncionario.Location = new System.Drawing.Point(109, 57);
            this.objFuncionario.MouseState = MaterialSkin.MouseState.HOVER;
            this.objFuncionario.Name = "objFuncionario";
            this.objFuncionario.PasswordChar = '\0';
            this.objFuncionario.SelectedText = "";
            this.objFuncionario.SelectionLength = 0;
            this.objFuncionario.SelectionStart = 0;
            this.objFuncionario.Size = new System.Drawing.Size(281, 23);
            this.objFuncionario.TabIndex = 22;
            this.objFuncionario.UseSystemPasswordChar = false;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(194, 47);
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
            this.materialLabel1.Location = new System.Drawing.Point(190, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Data de início";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Depth = 0;
            this.lblDataFim.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataFim.Location = new System.Drawing.Point(485, 25);
            this.lblDataFim.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(86, 19);
            this.lblDataFim.TabIndex = 27;
            this.lblDataFim.Text = "Data de fim";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(490, 47);
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
            this.materialLabel7.Location = new System.Drawing.Point(321, 25);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(148, 19);
            this.materialLabel7.TabIndex = 29;
            this.materialLabel7.Text = "Previsão do Término";
            // 
            // dtpDataPrevTermino
            // 
            this.dtpDataPrevTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrevTermino.Location = new System.Drawing.Point(325, 47);
            this.dtpDataPrevTermino.Name = "dtpDataPrevTermino";
            this.dtpDataPrevTermino.Size = new System.Drawing.Size(103, 20);
            this.dtpDataPrevTermino.TabIndex = 28;
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(615, 44);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(115, 21);
            this.cbbStatus.TabIndex = 30;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(611, 17);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 19);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Status atual";
            // 
            // btnBuscarObra
            // 
            this.btnBuscarObra.AutoSize = true;
            this.btnBuscarObra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarObra.Depth = 0;
            this.btnBuscarObra.Location = new System.Drawing.Point(932, 399);
            this.btnBuscarObra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Primary = false;
            this.btnBuscarObra.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarObra.TabIndex = 33;
            this.btnBuscarObra.Text = "Buscar";
            this.btnBuscarObra.UseVisualStyleBackColor = true;
            this.btnBuscarObra.Click += new System.EventHandler(this.btnBuscarObra_Click);
            // 
            // txtBuscarObraEndereco
            // 
            this.txtBuscarObraEndereco.Depth = 0;
            this.txtBuscarObraEndereco.Hint = "Filtro por endereço";
            this.txtBuscarObraEndereco.Location = new System.Drawing.Point(523, 412);
            this.txtBuscarObraEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarObraEndereco.Name = "txtBuscarObraEndereco";
            this.txtBuscarObraEndereco.PasswordChar = '\0';
            this.txtBuscarObraEndereco.SelectedText = "";
            this.txtBuscarObraEndereco.SelectionLength = 0;
            this.txtBuscarObraEndereco.SelectionStart = 0;
            this.txtBuscarObraEndereco.Size = new System.Drawing.Size(201, 23);
            this.txtBuscarObraEndereco.TabIndex = 32;
            this.txtBuscarObraEndereco.UseSystemPasswordChar = false;
            // 
            // txtBuscarObraClienteNome
            // 
            this.txtBuscarObraClienteNome.Depth = 0;
            this.txtBuscarObraClienteNome.Hint = "Filtro por nome de cliente";
            this.txtBuscarObraClienteNome.Location = new System.Drawing.Point(730, 412);
            this.txtBuscarObraClienteNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarObraClienteNome.Name = "txtBuscarObraClienteNome";
            this.txtBuscarObraClienteNome.PasswordChar = '\0';
            this.txtBuscarObraClienteNome.SelectedText = "";
            this.txtBuscarObraClienteNome.SelectionLength = 0;
            this.txtBuscarObraClienteNome.SelectionStart = 0;
            this.txtBuscarObraClienteNome.Size = new System.Drawing.Size(195, 23);
            this.txtBuscarObraClienteNome.TabIndex = 34;
            this.txtBuscarObraClienteNome.UseSystemPasswordChar = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(1135, 399);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = false;
            this.btnAlterar.Size = new System.Drawing.Size(71, 36);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.AutoSize = true;
            this.btnInserir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserir.Depth = 0;
            this.btnInserir.Location = new System.Drawing.Point(1064, 399);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Primary = false;
            this.btnInserir.Size = new System.Drawing.Size(63, 36);
            this.btnInserir.TabIndex = 36;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.OnClickInserirObra);
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
            this.txtCEP.TabIndex = 7;
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(322, 178);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(140, 21);
            this.cbbCidade.TabIndex = 9;
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
            this.cbbEstado.TabIndex = 8;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
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
            this.txtComplemento.TabIndex = 6;
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
            this.txtBairro.TabIndex = 5;
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
            this.txtNumero.TabIndex = 4;
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
            this.txtRua.TabIndex = 3;
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
            // btnBuscarEtapa
            // 
            this.btnBuscarEtapa.AutoSize = true;
            this.btnBuscarEtapa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEtapa.Depth = 0;
            this.btnBuscarEtapa.Location = new System.Drawing.Point(149, 10);
            this.btnBuscarEtapa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarEtapa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEtapa.Name = "btnBuscarEtapa";
            this.btnBuscarEtapa.Primary = false;
            this.btnBuscarEtapa.Size = new System.Drawing.Size(111, 36);
            this.btnBuscarEtapa.TabIndex = 117;
            this.btnBuscarEtapa.Text = "Buscar Etapa";
            this.btnBuscarEtapa.UseVisualStyleBackColor = true;
            this.btnBuscarEtapa.Click += new System.EventHandler(this.btnOnLickBuscarEtapa);
            // 
            // dgvTarefasSelecionadas
            // 
            this.dgvTarefasSelecionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasSelecionadas.Location = new System.Drawing.Point(518, 47);
            this.dgvTarefasSelecionadas.Name = "dgvTarefasSelecionadas";
            this.dgvTarefasSelecionadas.Size = new System.Drawing.Size(240, 150);
            this.dgvTarefasSelecionadas.TabIndex = 118;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(1207, 399);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.OnClickBtnCancel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel17);
            this.panel1.Controls.Add(this.materialLabel15);
            this.panel1.Controls.Add(this.objCliente);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.objFuncionario);
            this.panel1.Controls.Add(this.btnBuscarEngenheiro);
            this.panel1.Location = new System.Drawing.Point(17, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 92);
            this.panel1.TabIndex = 122;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(12, 57);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(94, 19);
            this.materialLabel17.TabIndex = 112;
            this.materialLabel17.Text = "Responsável";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(40, 22);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(56, 19);
            this.materialLabel15.TabIndex = 111;
            this.materialLabel15.Text = "Cliente";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.txtRua);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.txtDescricaoObra);
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
            this.panel2.Size = new System.Drawing.Size(482, 440);
            this.panel2.TabIndex = 123;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 247);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 127;
            this.materialLabel2.Text = "Descrição da obra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 117;
            this.label1.Text = "[ Campo não obrigatório ]";
            // 
            // txtDescricaoObra
            // 
            this.txtDescricaoObra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescricaoObra.Location = new System.Drawing.Point(6, 270);
            this.txtDescricaoObra.Multiline = true;
            this.txtDescricaoObra.Name = "txtDescricaoObra";
            this.txtDescricaoObra.Size = new System.Drawing.Size(452, 135);
            this.txtDescricaoObra.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtValor);
            this.panel3.Controls.Add(this.materialLabel14);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.dtpDataInicio);
            this.panel3.Controls.Add(this.dtpDataFim);
            this.panel3.Controls.Add(this.lblDataFim);
            this.panel3.Controls.Add(this.dtpDataPrevTermino);
            this.panel3.Controls.Add(this.materialLabel7);
            this.panel3.Controls.Add(this.cbbStatus);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Location = new System.Drawing.Point(523, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 81);
            this.panel3.TabIndex = 124;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(13, 44);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 113;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(9, 19);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(76, 19);
            this.materialLabel14.TabIndex = 112;
            this.materialLabel14.Text = "Valor (R$)";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnInserirTarefa);
            this.panel4.Controls.Add(this.btnRemoverTarefa);
            this.panel4.Controls.Add(this.txtBuscarEtapa);
            this.panel4.Controls.Add(this.dgvEtapasDisponiveis);
            this.panel4.Controls.Add(this.materialLabel3);
            this.panel4.Controls.Add(this.dgvTarefasDisponiveis);
            this.panel4.Controls.Add(this.materialLabel5);
            this.panel4.Controls.Add(this.btnBuscarEtapa);
            this.panel4.Controls.Add(this.dgvTarefasSelecionadas);
            this.panel4.Location = new System.Drawing.Point(523, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 222);
            this.panel4.TabIndex = 125;
            // 
            // btnInserirTarefa
            // 
            this.btnInserirTarefa.AutoSize = true;
            this.btnInserirTarefa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserirTarefa.Depth = 0;
            this.btnInserirTarefa.Location = new System.Drawing.Point(518, 10);
            this.btnInserirTarefa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserirTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserirTarefa.Name = "btnInserirTarefa";
            this.btnInserirTarefa.Primary = false;
            this.btnInserirTarefa.Size = new System.Drawing.Size(26, 36);
            this.btnInserirTarefa.TabIndex = 123;
            this.btnInserirTarefa.Text = ">>";
            this.btnInserirTarefa.UseVisualStyleBackColor = true;
            this.btnInserirTarefa.Click += new System.EventHandler(this.InserirTarefaGridTarefaSelecionada);
            // 
            // btnRemoverTarefa
            // 
            this.btnRemoverTarefa.AutoSize = true;
            this.btnRemoverTarefa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoverTarefa.Depth = 0;
            this.btnRemoverTarefa.Location = new System.Drawing.Point(486, 10);
            this.btnRemoverTarefa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoverTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoverTarefa.Name = "btnRemoverTarefa";
            this.btnRemoverTarefa.Primary = false;
            this.btnRemoverTarefa.Size = new System.Drawing.Size(26, 36);
            this.btnRemoverTarefa.TabIndex = 122;
            this.btnRemoverTarefa.Text = "<<";
            this.btnRemoverTarefa.UseVisualStyleBackColor = true;
            this.btnRemoverTarefa.Click += new System.EventHandler(this.RemoverTarefaGridTarefaSelecionada);
            // 
            // dgvObras
            // 
            this.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObras.Location = new System.Drawing.Point(523, 438);
            this.dgvObras.Name = "dgvObras";
            this.dgvObras.Size = new System.Drawing.Size(766, 156);
            this.dgvObras.TabIndex = 129;
            this.dgvObras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvObras_CellMouseClick_1);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(1004, 399);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(58, 36);
            this.materialFlatButton3.TabIndex = 130;
            this.materialFlatButton3.Text = "Listar";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // IniciarObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 623);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.dgvObras);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtBuscarObraClienteNome);
            this.Controls.Add(this.btnBuscarObra);
            this.Controls.Add(this.txtBuscarObraEndereco);
            this.Name = "IniciarObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapasDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasSelecionadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField objCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvEtapasDisponiveis;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEtapa;
        private System.Windows.Forms.DataGridView dgvTarefasDisponiveis;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarEngenheiro;
        private MaterialSkin.Controls.MaterialSingleLineTextField objFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtpDataPrevTermino;
        private System.Windows.Forms.ComboBox cbbStatus;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarObra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarObraEndereco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarObraClienteNome;
        private MaterialSkin.Controls.MaterialFlatButton btnAlterar;
        private MaterialSkin.Controls.MaterialFlatButton btnInserir;
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
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarEtapa;
        private System.Windows.Forms.DataGridView dgvTarefasSelecionadas;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtDescricaoObra;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialFlatButton btnInserirTarefa;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoverTarefa;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.DataGridView dgvObras;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.MaskedTextBox txtValor;
    }
}
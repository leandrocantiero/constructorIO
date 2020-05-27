namespace WindowsFormsApp2.View
{
    partial class LancarMateriaisServicos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLançarMatServ = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDataLanc = new System.Windows.Forms.DateTimePicker();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.objObraSelecionada = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarObra = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.btnBuscarTarefa = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBuscarTarefa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAlterarMaterial = new MaterialSkin.Controls.MaterialFlatButton();
            this.identificadorSelecionarMateriais = new MaterialSkin.Controls.MaterialLabel();
            this.btnInserirMaterial = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemoverMaterial = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvMateriaisSelecionados = new System.Windows.Forms.DataGridView();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUnidadeProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidadeProdutos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvMateriaisDisponiveis = new System.Windows.Forms.DataGridView();
            this.txtBuscarProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.objProdutoSelecionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarProduto = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.objTarefa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.objEtapa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAlterarServico = new MaterialSkin.Controls.MaterialFlatButton();
            this.identificadorSelecionarServicos = new MaterialSkin.Controls.MaterialLabel();
            this.btnInserirServico = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoverServico = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvServicosSelecionados = new System.Windows.Forms.DataGridView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMetrosQuadrados = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidadeHomens = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvServicosDisponiveis = new System.Windows.Forms.DataGridView();
            this.txtBuscarServico = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.objServicoSelecionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarServico = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.identificadorSelecionarTarefa = new MaterialSkin.Controls.MaterialLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.identificadorSelecionarObra = new MaterialSkin.Controls.MaterialLabel();
            this.identificadorBuscarTarefa = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaisSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaisDisponiveis)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosDisponiveis)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.identificadorSelecionarObra);
            this.panel1.Controls.Add(this.materialLabel15);
            this.panel1.Controls.Add(this.objObraSelecionada);
            this.panel1.Controls.Add(this.btnBuscarObra);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 74);
            this.panel1.TabIndex = 126;
            // 
            // btnLançarMatServ
            // 
            this.btnLançarMatServ.AutoSize = true;
            this.btnLançarMatServ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLançarMatServ.Depth = 0;
            this.btnLançarMatServ.Location = new System.Drawing.Point(345, 18);
            this.btnLançarMatServ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLançarMatServ.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLançarMatServ.Name = "btnLançarMatServ";
            this.btnLançarMatServ.Primary = false;
            this.btnLançarMatServ.Size = new System.Drawing.Size(65, 36);
            this.btnLançarMatServ.TabIndex = 131;
            this.btnLançarMatServ.Text = "Lançar";
            this.btnLançarMatServ.UseVisualStyleBackColor = true;
            this.btnLançarMatServ.Click += new System.EventHandler(this.btnLançarMatServ_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 128;
            this.materialLabel1.Text = "Data de lançamento";
            // 
            // dtpDataLanc
            // 
            this.dtpDataLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLanc.Location = new System.Drawing.Point(15, 34);
            this.dtpDataLanc.Name = "dtpDataLanc";
            this.dtpDataLanc.Size = new System.Drawing.Size(103, 20);
            this.dtpDataLanc.TabIndex = 127;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(15, 37);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(40, 19);
            this.materialLabel15.TabIndex = 111;
            this.materialLabel15.Text = "Obra";
            // 
            // objObraSelecionada
            // 
            this.objObraSelecionada.Depth = 0;
            this.objObraSelecionada.Enabled = false;
            this.objObraSelecionada.Hint = "Não selecionada";
            this.objObraSelecionada.Location = new System.Drawing.Point(70, 33);
            this.objObraSelecionada.MouseState = MaterialSkin.MouseState.HOVER;
            this.objObraSelecionada.Name = "objObraSelecionada";
            this.objObraSelecionada.PasswordChar = '\0';
            this.objObraSelecionada.SelectedText = "";
            this.objObraSelecionada.SelectionLength = 0;
            this.objObraSelecionada.SelectionStart = 0;
            this.objObraSelecionada.Size = new System.Drawing.Size(255, 23);
            this.objObraSelecionada.TabIndex = 7;
            this.objObraSelecionada.UseSystemPasswordChar = false;
            // 
            // btnBuscarObra
            // 
            this.btnBuscarObra.AutoSize = true;
            this.btnBuscarObra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarObra.Depth = 0;
            this.btnBuscarObra.Location = new System.Drawing.Point(332, 26);
            this.btnBuscarObra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Primary = false;
            this.btnBuscarObra.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarObra.TabIndex = 1;
            this.btnBuscarObra.Text = "Buscar";
            this.btnBuscarObra.UseVisualStyleBackColor = true;
            this.btnBuscarObra.Click += new System.EventHandler(this.btnBuscarObra_Click);
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(19, 92);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(395, 233);
            this.dgvTarefas.TabIndex = 123;
            this.dgvTarefas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnClickGridTarefa);
            // 
            // btnBuscarTarefa
            // 
            this.btnBuscarTarefa.AutoSize = true;
            this.btnBuscarTarefa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarTarefa.Depth = 0;
            this.btnBuscarTarefa.Location = new System.Drawing.Point(349, 55);
            this.btnBuscarTarefa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarTarefa.Name = "btnBuscarTarefa";
            this.btnBuscarTarefa.Primary = false;
            this.btnBuscarTarefa.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarTarefa.TabIndex = 125;
            this.btnBuscarTarefa.Text = "Buscar";
            this.btnBuscarTarefa.UseVisualStyleBackColor = true;
            this.btnBuscarTarefa.Click += new System.EventHandler(this.btnBuscarEtapaTarefa_Click);
            // 
            // txtBuscarTarefa
            // 
            this.txtBuscarTarefa.Depth = 0;
            this.txtBuscarTarefa.Hint = "Descrição tarefa";
            this.txtBuscarTarefa.Location = new System.Drawing.Point(65, 63);
            this.txtBuscarTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarTarefa.Name = "txtBuscarTarefa";
            this.txtBuscarTarefa.PasswordChar = '\0';
            this.txtBuscarTarefa.SelectedText = "";
            this.txtBuscarTarefa.SelectionLength = 0;
            this.txtBuscarTarefa.SelectionStart = 0;
            this.txtBuscarTarefa.Size = new System.Drawing.Size(260, 23);
            this.txtBuscarTarefa.TabIndex = 126;
            this.txtBuscarTarefa.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.identificadorBuscarTarefa);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.dgvTarefas);
            this.panel2.Controls.Add(this.txtBuscarTarefa);
            this.panel2.Controls.Add(this.btnBuscarTarefa);
            this.panel2.Location = new System.Drawing.Point(12, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 332);
            this.panel2.TabIndex = 127;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(15, 63);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(44, 19);
            this.materialLabel5.TabIndex = 127;
            this.materialLabel5.Text = "Filtro";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAlterarMaterial);
            this.panel3.Controls.Add(this.identificadorSelecionarMateriais);
            this.panel3.Controls.Add(this.btnInserirMaterial);
            this.panel3.Controls.Add(this.btnRemoverMaterial);
            this.panel3.Controls.Add(this.dgvMateriaisSelecionados);
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.txtUnidadeProduto);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.txtQuantidadeProdutos);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Controls.Add(this.dgvMateriaisDisponiveis);
            this.panel3.Controls.Add(this.txtBuscarProduto);
            this.panel3.Controls.Add(this.objProdutoSelecionado);
            this.panel3.Controls.Add(this.btnBuscarProduto);
            this.panel3.Location = new System.Drawing.Point(479, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 296);
            this.panel3.TabIndex = 128;
            // 
            // btnAlterarMaterial
            // 
            this.btnAlterarMaterial.AutoSize = true;
            this.btnAlterarMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterarMaterial.Depth = 0;
            this.btnAlterarMaterial.Location = new System.Drawing.Point(563, 78);
            this.btnAlterarMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlterarMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterarMaterial.Name = "btnAlterarMaterial";
            this.btnAlterarMaterial.Primary = false;
            this.btnAlterarMaterial.Size = new System.Drawing.Size(71, 36);
            this.btnAlterarMaterial.TabIndex = 136;
            this.btnAlterarMaterial.Text = "Alterar";
            this.btnAlterarMaterial.UseVisualStyleBackColor = true;
            this.btnAlterarMaterial.Click += new System.EventHandler(this.btnAlterarMaterial_Click);
            // 
            // identificadorSelecionarMateriais
            // 
            this.identificadorSelecionarMateriais.AutoSize = true;
            this.identificadorSelecionarMateriais.Depth = 0;
            this.identificadorSelecionarMateriais.Font = new System.Drawing.Font("Roboto", 11F);
            this.identificadorSelecionarMateriais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.identificadorSelecionarMateriais.Location = new System.Drawing.Point(-1, -1);
            this.identificadorSelecionarMateriais.MouseState = MaterialSkin.MouseState.HOVER;
            this.identificadorSelecionarMateriais.Name = "identificadorSelecionarMateriais";
            this.identificadorSelecionarMateriais.Size = new System.Drawing.Size(121, 19);
            this.identificadorSelecionarMateriais.TabIndex = 133;
            this.identificadorSelecionarMateriais.Text = "Lançar Materiais";
            // 
            // btnInserirMaterial
            // 
            this.btnInserirMaterial.AutoSize = true;
            this.btnInserirMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserirMaterial.Depth = 0;
            this.btnInserirMaterial.Location = new System.Drawing.Point(492, 78);
            this.btnInserirMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserirMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserirMaterial.Name = "btnInserirMaterial";
            this.btnInserirMaterial.Primary = false;
            this.btnInserirMaterial.Size = new System.Drawing.Size(63, 36);
            this.btnInserirMaterial.TabIndex = 130;
            this.btnInserirMaterial.Text = "Inserir";
            this.btnInserirMaterial.UseVisualStyleBackColor = true;
            this.btnInserirMaterial.Click += new System.EventHandler(this.btnInserirTarefa_Click);
            // 
            // btnRemoverMaterial
            // 
            this.btnRemoverMaterial.AutoSize = true;
            this.btnRemoverMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoverMaterial.Depth = 0;
            this.btnRemoverMaterial.Location = new System.Drawing.Point(409, 78);
            this.btnRemoverMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoverMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoverMaterial.Name = "btnRemoverMaterial";
            this.btnRemoverMaterial.Primary = false;
            this.btnRemoverMaterial.Size = new System.Drawing.Size(75, 36);
            this.btnRemoverMaterial.TabIndex = 129;
            this.btnRemoverMaterial.Text = "Remover";
            this.btnRemoverMaterial.UseVisualStyleBackColor = true;
            this.btnRemoverMaterial.Click += new System.EventHandler(this.btnRemoverTarefa_Click);
            // 
            // dgvMateriaisSelecionados
            // 
            this.dgvMateriaisSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaisSelecionados.Location = new System.Drawing.Point(409, 116);
            this.dgvMateriaisSelecionados.Name = "dgvMateriaisSelecionados";
            this.dgvMateriaisSelecionados.Size = new System.Drawing.Size(400, 175);
            this.dgvMateriaisSelecionados.TabIndex = 132;
            this.dgvMateriaisSelecionados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterialSelecionadoOnClick);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(590, 17);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(117, 19);
            this.materialLabel4.TabIndex = 131;
            this.materialLabel4.Text = "Tipo de Unidade";
            // 
            // txtUnidadeProduto
            // 
            this.txtUnidadeProduto.Depth = 0;
            this.txtUnidadeProduto.Hint = "";
            this.txtUnidadeProduto.Location = new System.Drawing.Point(594, 39);
            this.txtUnidadeProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnidadeProduto.Name = "txtUnidadeProduto";
            this.txtUnidadeProduto.PasswordChar = '\0';
            this.txtUnidadeProduto.SelectedText = "";
            this.txtUnidadeProduto.SelectionLength = 0;
            this.txtUnidadeProduto.SelectionStart = 0;
            this.txtUnidadeProduto.Size = new System.Drawing.Size(100, 23);
            this.txtUnidadeProduto.TabIndex = 130;
            this.txtUnidadeProduto.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(442, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 19);
            this.materialLabel3.TabIndex = 129;
            this.materialLabel3.Text = "Quantidade";
            // 
            // txtQuantidadeProdutos
            // 
            this.txtQuantidadeProdutos.Depth = 0;
            this.txtQuantidadeProdutos.Hint = "";
            this.txtQuantidadeProdutos.Location = new System.Drawing.Point(446, 39);
            this.txtQuantidadeProdutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuantidadeProdutos.Name = "txtQuantidadeProdutos";
            this.txtQuantidadeProdutos.PasswordChar = '\0';
            this.txtQuantidadeProdutos.SelectedText = "";
            this.txtQuantidadeProdutos.SelectionLength = 0;
            this.txtQuantidadeProdutos.SelectionStart = 0;
            this.txtQuantidadeProdutos.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeProdutos.TabIndex = 128;
            this.txtQuantidadeProdutos.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(149, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 127;
            this.materialLabel2.Text = "Nome";
            // 
            // dgvMateriaisDisponiveis
            // 
            this.dgvMateriaisDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaisDisponiveis.Location = new System.Drawing.Point(3, 116);
            this.dgvMateriaisDisponiveis.Name = "dgvMateriaisDisponiveis";
            this.dgvMateriaisDisponiveis.Size = new System.Drawing.Size(400, 175);
            this.dgvMateriaisDisponiveis.TabIndex = 123;
            this.dgvMateriaisDisponiveis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMateriaisDisponiveis_CellMouseClick);
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Depth = 0;
            this.txtBuscarProduto.Hint = "Nome do material";
            this.txtBuscarProduto.Location = new System.Drawing.Point(19, 84);
            this.txtBuscarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.PasswordChar = '\0';
            this.txtBuscarProduto.SelectedText = "";
            this.txtBuscarProduto.SelectionLength = 0;
            this.txtBuscarProduto.SelectionStart = 0;
            this.txtBuscarProduto.Size = new System.Drawing.Size(180, 23);
            this.txtBuscarProduto.TabIndex = 124;
            this.txtBuscarProduto.UseSystemPasswordChar = false;
            // 
            // objProdutoSelecionado
            // 
            this.objProdutoSelecionado.Depth = 0;
            this.objProdutoSelecionado.Hint = "Não selecionado";
            this.objProdutoSelecionado.Location = new System.Drawing.Point(153, 39);
            this.objProdutoSelecionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.objProdutoSelecionado.Name = "objProdutoSelecionado";
            this.objProdutoSelecionado.PasswordChar = '\0';
            this.objProdutoSelecionado.SelectedText = "";
            this.objProdutoSelecionado.SelectionLength = 0;
            this.objProdutoSelecionado.SelectionStart = 0;
            this.objProdutoSelecionado.Size = new System.Drawing.Size(285, 23);
            this.objProdutoSelecionado.TabIndex = 126;
            this.objProdutoSelecionado.UseSystemPasswordChar = false;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.AutoSize = true;
            this.btnBuscarProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProduto.Depth = 0;
            this.btnBuscarProduto.Location = new System.Drawing.Point(260, 78);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Primary = false;
            this.btnBuscarProduto.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarProduto.TabIndex = 125;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(10, 69);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(52, 19);
            this.materialLabel12.TabIndex = 135;
            this.materialLabel12.Text = "Tarefa";
            // 
            // objTarefa
            // 
            this.objTarefa.Depth = 0;
            this.objTarefa.Enabled = false;
            this.objTarefa.Hint = "Não selecionada";
            this.objTarefa.Location = new System.Drawing.Point(65, 65);
            this.objTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.objTarefa.Name = "objTarefa";
            this.objTarefa.PasswordChar = '\0';
            this.objTarefa.SelectedText = "";
            this.objTarefa.SelectionLength = 0;
            this.objTarefa.SelectionStart = 0;
            this.objTarefa.Size = new System.Drawing.Size(306, 23);
            this.objTarefa.TabIndex = 134;
            this.objTarefa.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(10, 36);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 130;
            this.materialLabel6.Text = "Etapa";
            // 
            // objEtapa
            // 
            this.objEtapa.Depth = 0;
            this.objEtapa.Enabled = false;
            this.objEtapa.Hint = "Não selecionada";
            this.objEtapa.Location = new System.Drawing.Point(65, 32);
            this.objEtapa.MouseState = MaterialSkin.MouseState.HOVER;
            this.objEtapa.Name = "objEtapa";
            this.objEtapa.PasswordChar = '\0';
            this.objEtapa.SelectedText = "";
            this.objEtapa.SelectionLength = 0;
            this.objEtapa.SelectionStart = 0;
            this.objEtapa.Size = new System.Drawing.Size(306, 23);
            this.objEtapa.TabIndex = 129;
            this.objEtapa.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAlterarServico);
            this.panel4.Controls.Add(this.identificadorSelecionarServicos);
            this.panel4.Controls.Add(this.btnInserirServico);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnRemoverServico);
            this.panel4.Controls.Add(this.dgvServicosSelecionados);
            this.panel4.Controls.Add(this.materialLabel7);
            this.panel4.Controls.Add(this.txtMetrosQuadrados);
            this.panel4.Controls.Add(this.materialLabel8);
            this.panel4.Controls.Add(this.txtQuantidadeHomens);
            this.panel4.Controls.Add(this.materialLabel9);
            this.panel4.Controls.Add(this.dgvServicosDisponiveis);
            this.panel4.Controls.Add(this.txtBuscarServico);
            this.panel4.Controls.Add(this.objServicoSelecionado);
            this.panel4.Controls.Add(this.btnBuscarServico);
            this.panel4.Location = new System.Drawing.Point(479, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 296);
            this.panel4.TabIndex = 129;
            // 
            // btnAlterarServico
            // 
            this.btnAlterarServico.AutoSize = true;
            this.btnAlterarServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterarServico.Depth = 0;
            this.btnAlterarServico.Location = new System.Drawing.Point(553, 78);
            this.btnAlterarServico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlterarServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterarServico.Name = "btnAlterarServico";
            this.btnAlterarServico.Primary = false;
            this.btnAlterarServico.Size = new System.Drawing.Size(71, 36);
            this.btnAlterarServico.TabIndex = 137;
            this.btnAlterarServico.Text = "Alterar";
            this.btnAlterarServico.UseVisualStyleBackColor = true;
            this.btnAlterarServico.Click += new System.EventHandler(this.btnAlterarServico_Click);
            // 
            // identificadorSelecionarServicos
            // 
            this.identificadorSelecionarServicos.AutoSize = true;
            this.identificadorSelecionarServicos.Depth = 0;
            this.identificadorSelecionarServicos.Font = new System.Drawing.Font("Roboto", 11F);
            this.identificadorSelecionarServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.identificadorSelecionarServicos.Location = new System.Drawing.Point(2, 0);
            this.identificadorSelecionarServicos.MouseState = MaterialSkin.MouseState.HOVER;
            this.identificadorSelecionarServicos.Name = "identificadorSelecionarServicos";
            this.identificadorSelecionarServicos.Size = new System.Drawing.Size(116, 19);
            this.identificadorSelecionarServicos.TabIndex = 135;
            this.identificadorSelecionarServicos.Text = "Lançar Serviços";
            // 
            // btnInserirServico
            // 
            this.btnInserirServico.AutoSize = true;
            this.btnInserirServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserirServico.Depth = 0;
            this.btnInserirServico.Location = new System.Drawing.Point(492, 78);
            this.btnInserirServico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserirServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserirServico.Name = "btnInserirServico";
            this.btnInserirServico.Primary = false;
            this.btnInserirServico.Size = new System.Drawing.Size(63, 36);
            this.btnInserirServico.TabIndex = 134;
            this.btnInserirServico.Text = "Inserir";
            this.btnInserirServico.UseVisualStyleBackColor = true;
            this.btnInserirServico.Click += new System.EventHandler(this.btnInserirServico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(654, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 14);
            this.label3.TabIndex = 133;
            this.label3.Text = "[ Campo não obrigatório ]";
            // 
            // btnRemoverServico
            // 
            this.btnRemoverServico.AutoSize = true;
            this.btnRemoverServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoverServico.Depth = 0;
            this.btnRemoverServico.Location = new System.Drawing.Point(409, 78);
            this.btnRemoverServico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoverServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoverServico.Name = "btnRemoverServico";
            this.btnRemoverServico.Primary = false;
            this.btnRemoverServico.Size = new System.Drawing.Size(75, 36);
            this.btnRemoverServico.TabIndex = 133;
            this.btnRemoverServico.Text = "Remover";
            this.btnRemoverServico.UseVisualStyleBackColor = true;
            this.btnRemoverServico.Click += new System.EventHandler(this.btnRemoverServico_Click);
            // 
            // dgvServicosSelecionados
            // 
            this.dgvServicosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicosSelecionados.Location = new System.Drawing.Point(409, 116);
            this.dgvServicosSelecionados.Name = "dgvServicosSelecionados";
            this.dgvServicosSelecionados.Size = new System.Drawing.Size(400, 175);
            this.dgvServicosSelecionados.TabIndex = 132;
            this.dgvServicosSelecionados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsumoServicoOnClick);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(653, 19);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(132, 19);
            this.materialLabel7.TabIndex = 131;
            this.materialLabel7.Text = "Metros quadrados";
            // 
            // txtMetrosQuadrados
            // 
            this.txtMetrosQuadrados.Depth = 0;
            this.txtMetrosQuadrados.Hint = "";
            this.txtMetrosQuadrados.Location = new System.Drawing.Point(657, 41);
            this.txtMetrosQuadrados.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetrosQuadrados.Name = "txtMetrosQuadrados";
            this.txtMetrosQuadrados.PasswordChar = '\0';
            this.txtMetrosQuadrados.SelectedText = "";
            this.txtMetrosQuadrados.SelectionLength = 0;
            this.txtMetrosQuadrados.SelectionStart = 0;
            this.txtMetrosQuadrados.Size = new System.Drawing.Size(100, 23);
            this.txtMetrosQuadrados.TabIndex = 130;
            this.txtMetrosQuadrados.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(417, 19);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(226, 19);
            this.materialLabel8.TabIndex = 129;
            this.materialLabel8.Text = "Trabalhadores necessários (UN)";
            // 
            // txtQuantidadeHomens
            // 
            this.txtQuantidadeHomens.Depth = 0;
            this.txtQuantidadeHomens.Hint = "";
            this.txtQuantidadeHomens.Location = new System.Drawing.Point(421, 41);
            this.txtQuantidadeHomens.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuantidadeHomens.Name = "txtQuantidadeHomens";
            this.txtQuantidadeHomens.PasswordChar = '\0';
            this.txtQuantidadeHomens.SelectedText = "";
            this.txtQuantidadeHomens.SelectionLength = 0;
            this.txtQuantidadeHomens.SelectionStart = 0;
            this.txtQuantidadeHomens.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeHomens.TabIndex = 128;
            this.txtQuantidadeHomens.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(112, 19);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(50, 19);
            this.materialLabel9.TabIndex = 127;
            this.materialLabel9.Text = "Nome";
            // 
            // dgvServicosDisponiveis
            // 
            this.dgvServicosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicosDisponiveis.Location = new System.Drawing.Point(3, 116);
            this.dgvServicosDisponiveis.Name = "dgvServicosDisponiveis";
            this.dgvServicosDisponiveis.Size = new System.Drawing.Size(400, 175);
            this.dgvServicosDisponiveis.TabIndex = 123;
            this.dgvServicosDisponiveis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvServicoDisponiveis_OnClick);
            // 
            // txtBuscarServico
            // 
            this.txtBuscarServico.Depth = 0;
            this.txtBuscarServico.Hint = "Nome do serviço";
            this.txtBuscarServico.Location = new System.Drawing.Point(19, 84);
            this.txtBuscarServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarServico.Name = "txtBuscarServico";
            this.txtBuscarServico.PasswordChar = '\0';
            this.txtBuscarServico.SelectedText = "";
            this.txtBuscarServico.SelectionLength = 0;
            this.txtBuscarServico.SelectionStart = 0;
            this.txtBuscarServico.Size = new System.Drawing.Size(180, 23);
            this.txtBuscarServico.TabIndex = 124;
            this.txtBuscarServico.UseSystemPasswordChar = false;
            // 
            // objServicoSelecionado
            // 
            this.objServicoSelecionado.Depth = 0;
            this.objServicoSelecionado.Hint = "Não selecionado";
            this.objServicoSelecionado.Location = new System.Drawing.Point(116, 41);
            this.objServicoSelecionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.objServicoSelecionado.Name = "objServicoSelecionado";
            this.objServicoSelecionado.PasswordChar = '\0';
            this.objServicoSelecionado.SelectedText = "";
            this.objServicoSelecionado.SelectionLength = 0;
            this.objServicoSelecionado.SelectionStart = 0;
            this.objServicoSelecionado.Size = new System.Drawing.Size(285, 23);
            this.objServicoSelecionado.TabIndex = 126;
            this.objServicoSelecionado.UseSystemPasswordChar = false;
            // 
            // btnBuscarServico
            // 
            this.btnBuscarServico.AutoSize = true;
            this.btnBuscarServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarServico.Depth = 0;
            this.btnBuscarServico.Location = new System.Drawing.Point(260, 78);
            this.btnBuscarServico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarServico.Name = "btnBuscarServico";
            this.btnBuscarServico.Primary = false;
            this.btnBuscarServico.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarServico.TabIndex = 125;
            this.btnBuscarServico.Text = "Buscar";
            this.btnBuscarServico.UseVisualStyleBackColor = true;
            this.btnBuscarServico.Click += new System.EventHandler(this.btnBuscarServico_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.identificadorSelecionarTarefa);
            this.panel5.Controls.Add(this.objEtapa);
            this.panel5.Controls.Add(this.materialLabel12);
            this.panel5.Controls.Add(this.materialLabel6);
            this.panel5.Controls.Add(this.objTarefa);
            this.panel5.Location = new System.Drawing.Point(12, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(441, 93);
            this.panel5.TabIndex = 130;
            // 
            // identificadorSelecionarTarefa
            // 
            this.identificadorSelecionarTarefa.AutoSize = true;
            this.identificadorSelecionarTarefa.Depth = 0;
            this.identificadorSelecionarTarefa.Font = new System.Drawing.Font("Roboto", 11F);
            this.identificadorSelecionarTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.identificadorSelecionarTarefa.Location = new System.Drawing.Point(-1, 0);
            this.identificadorSelecionarTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.identificadorSelecionarTarefa.Name = "identificadorSelecionarTarefa";
            this.identificadorSelecionarTarefa.Size = new System.Drawing.Size(141, 19);
            this.identificadorSelecionarTarefa.TabIndex = 134;
            this.identificadorSelecionarTarefa.Text = "Tarefa selecionada.";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnLançarMatServ);
            this.panel6.Controls.Add(this.materialLabel1);
            this.panel6.Controls.Add(this.dtpDataLanc);
            this.panel6.Location = new System.Drawing.Point(12, 615);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(441, 68);
            this.panel6.TabIndex = 132;
            // 
            // identificadorSelecionarObra
            // 
            this.identificadorSelecionarObra.AutoSize = true;
            this.identificadorSelecionarObra.Depth = 0;
            this.identificadorSelecionarObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.identificadorSelecionarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.identificadorSelecionarObra.Location = new System.Drawing.Point(3, 0);
            this.identificadorSelecionarObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.identificadorSelecionarObra.Name = "identificadorSelecionarObra";
            this.identificadorSelecionarObra.Size = new System.Drawing.Size(115, 18);
            this.identificadorSelecionarObra.TabIndex = 135;
            this.identificadorSelecionarObra.Text = "Selecionar Obra";
            // 
            // identificadorBuscarTarefa
            // 
            this.identificadorBuscarTarefa.AutoSize = true;
            this.identificadorBuscarTarefa.Depth = 0;
            this.identificadorBuscarTarefa.Font = new System.Drawing.Font("Roboto", 11F);
            this.identificadorBuscarTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.identificadorBuscarTarefa.Location = new System.Drawing.Point(3, 0);
            this.identificadorBuscarTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.identificadorBuscarTarefa.Name = "identificadorBuscarTarefa";
            this.identificadorBuscarTarefa.Size = new System.Drawing.Size(102, 19);
            this.identificadorBuscarTarefa.TabIndex = 135;
            this.identificadorBuscarTarefa.Text = "Buscar Tarefa";
            // 
            // LancarMateriaisServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 690);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LancarMateriaisServicos";
            this.Text = "Lancar Materiais e Servicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaisSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaisDisponiveis)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosDisponiveis)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField objObraSelecionada;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarObra;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarTarefa;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarTarefa;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpDataLanc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMateriaisDisponiveis;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProduto;
        private MaterialSkin.Controls.MaterialSingleLineTextField objProdutoSelecionado;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvMateriaisSelecionados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnidadeProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidadeProdutos;
        private MaterialSkin.Controls.MaterialFlatButton btnInserirMaterial;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoverMaterial;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvServicosSelecionados;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMetrosQuadrados;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidadeHomens;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataGridView dgvServicosDisponiveis;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarServico;
        private MaterialSkin.Controls.MaterialSingleLineTextField objServicoSelecionado;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarServico;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField objEtapa;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton btnLançarMatServ;
        private MaterialSkin.Controls.MaterialFlatButton btnInserirServico;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoverServico;
        private MaterialSkin.Controls.MaterialLabel identificadorSelecionarMateriais;
        private MaterialSkin.Controls.MaterialLabel identificadorSelecionarServicos;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField objTarefa;
        private MaterialSkin.Controls.MaterialFlatButton btnAlterarMaterial;
        private MaterialSkin.Controls.MaterialFlatButton btnAlterarServico;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialLabel identificadorSelecionarTarefa;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel identificadorSelecionarObra;
        private MaterialSkin.Controls.MaterialLabel identificadorBuscarTarefa;
    }
}
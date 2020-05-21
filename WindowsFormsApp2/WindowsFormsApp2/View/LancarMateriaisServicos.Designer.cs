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
            this.objObraSelecionada = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarObra = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvEtapasTarefas = new System.Windows.Forms.DataGridView();
            this.btnBuscarEtapaTarefa = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarTarefa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDataLanc = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisarProdutoNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.objProdutoSelecionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarProduto = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidadeProdutos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUnidadeProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnInserirTarefa = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemoverTarefa = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMetrosQuadrados = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidadeHomens = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.txtPesquisarServicoNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.objServicoSelecionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarServico = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.objTarefa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapasTarefas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.dtpDataLanc);
            this.panel1.Controls.Add(this.materialLabel15);
            this.panel1.Controls.Add(this.objObraSelecionada);
            this.panel1.Controls.Add(this.btnBuscarObra);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 125);
            this.panel1.TabIndex = 126;
            // 
            // objObraSelecionada
            // 
            this.objObraSelecionada.Depth = 0;
            this.objObraSelecionada.Enabled = false;
            this.objObraSelecionada.Hint = "Não selecionada";
            this.objObraSelecionada.Location = new System.Drawing.Point(70, 13);
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
            this.btnBuscarObra.Location = new System.Drawing.Point(332, 6);
            this.btnBuscarObra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarObra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Primary = false;
            this.btnBuscarObra.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarObra.TabIndex = 1;
            this.btnBuscarObra.Text = "Buscar";
            this.btnBuscarObra.UseVisualStyleBackColor = true;
            // 
            // dgvEtapasTarefas
            // 
            this.dgvEtapasTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapasTarefas.Location = new System.Drawing.Point(19, 57);
            this.dgvEtapasTarefas.Name = "dgvEtapasTarefas";
            this.dgvEtapasTarefas.Size = new System.Drawing.Size(400, 401);
            this.dgvEtapasTarefas.TabIndex = 123;
            // 
            // btnBuscarEtapaTarefa
            // 
            this.btnBuscarEtapaTarefa.AutoSize = true;
            this.btnBuscarEtapaTarefa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEtapaTarefa.Depth = 0;
            this.btnBuscarEtapaTarefa.Location = new System.Drawing.Point(349, 12);
            this.btnBuscarEtapaTarefa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarEtapaTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEtapaTarefa.Name = "btnBuscarEtapaTarefa";
            this.btnBuscarEtapaTarefa.Primary = false;
            this.btnBuscarEtapaTarefa.Size = new System.Drawing.Size(65, 36);
            this.btnBuscarEtapaTarefa.TabIndex = 125;
            this.btnBuscarEtapaTarefa.Text = "Buscar";
            this.btnBuscarEtapaTarefa.UseVisualStyleBackColor = true;
            this.btnBuscarEtapaTarefa.Click += new System.EventHandler(this.btnBuscarEtapaTarefa_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(15, 17);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(40, 19);
            this.materialLabel15.TabIndex = 111;
            this.materialLabel15.Text = "Obra";
            // 
            // txtBuscarTarefa
            // 
            this.txtBuscarTarefa.Depth = 0;
            this.txtBuscarTarefa.Hint = "Descrição tarefa";
            this.txtBuscarTarefa.Location = new System.Drawing.Point(65, 20);
            this.txtBuscarTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarTarefa.Name = "txtBuscarTarefa";
            this.txtBuscarTarefa.PasswordChar = '\0';
            this.txtBuscarTarefa.SelectedText = "";
            this.txtBuscarTarefa.SelectionLength = 0;
            this.txtBuscarTarefa.SelectionStart = 0;
            this.txtBuscarTarefa.Size = new System.Drawing.Size(260, 23);
            this.txtBuscarTarefa.TabIndex = 126;
            this.txtBuscarTarefa.UseSystemPasswordChar = false;
            this.txtBuscarTarefa.Click += new System.EventHandler(this.txtBuscarTarefa_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 128;
            this.materialLabel1.Text = "Data de lançamento";
            // 
            // dtpDataLanc
            // 
            this.dtpDataLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLanc.Location = new System.Drawing.Point(19, 84);
            this.dtpDataLanc.Name = "dtpDataLanc";
            this.dtpDataLanc.Size = new System.Drawing.Size(103, 20);
            this.dtpDataLanc.TabIndex = 127;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.dgvEtapasTarefas);
            this.panel2.Controls.Add(this.txtBuscarTarefa);
            this.panel2.Controls.Add(this.btnBuscarEtapaTarefa);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 469);
            this.panel2.TabIndex = 127;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialLabel10);
            this.panel3.Controls.Add(this.materialLabel6);
            this.panel3.Controls.Add(this.btnInserirTarefa);
            this.panel3.Controls.Add(this.objTarefa);
            this.panel3.Controls.Add(this.btnRemoverTarefa);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.txtUnidadeProduto);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.txtQuantidadeProdutos);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.txtPesquisarProdutoNome);
            this.panel3.Controls.Add(this.objProdutoSelecionado);
            this.panel3.Controls.Add(this.btnBuscarProduto);
            this.panel3.Location = new System.Drawing.Point(479, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 296);
            this.panel3.TabIndex = 128;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 175);
            this.dataGridView1.TabIndex = 123;
            // 
            // txtPesquisarProdutoNome
            // 
            this.txtPesquisarProdutoNome.Depth = 0;
            this.txtPesquisarProdutoNome.Hint = "Nome produto";
            this.txtPesquisarProdutoNome.Location = new System.Drawing.Point(19, 84);
            this.txtPesquisarProdutoNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisarProdutoNome.Name = "txtPesquisarProdutoNome";
            this.txtPesquisarProdutoNome.PasswordChar = '\0';
            this.txtPesquisarProdutoNome.SelectedText = "";
            this.txtPesquisarProdutoNome.SelectionLength = 0;
            this.txtPesquisarProdutoNome.SelectionStart = 0;
            this.txtPesquisarProdutoNome.Size = new System.Drawing.Size(180, 23);
            this.txtPesquisarProdutoNome.TabIndex = 124;
            this.txtPesquisarProdutoNome.UseSystemPasswordChar = false;
            // 
            // objProdutoSelecionado
            // 
            this.objProdutoSelecionado.Depth = 0;
            this.objProdutoSelecionado.Hint = "Não selecionado";
            this.objProdutoSelecionado.Location = new System.Drawing.Point(260, 33);
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
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(256, 11);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 127;
            this.materialLabel2.Text = "Nome";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(549, 11);
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
            this.txtQuantidadeProdutos.Location = new System.Drawing.Point(553, 33);
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
            // txtUnidadeProduto
            // 
            this.txtUnidadeProduto.Depth = 0;
            this.txtUnidadeProduto.Hint = "";
            this.txtUnidadeProduto.Location = new System.Drawing.Point(701, 33);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(409, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(400, 175);
            this.dataGridView2.TabIndex = 132;
            // 
            // btnInserirTarefa
            // 
            this.btnInserirTarefa.AutoSize = true;
            this.btnInserirTarefa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserirTarefa.Depth = 0;
            this.btnInserirTarefa.Location = new System.Drawing.Point(492, 78);
            this.btnInserirTarefa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserirTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserirTarefa.Name = "btnInserirTarefa";
            this.btnInserirTarefa.Primary = false;
            this.btnInserirTarefa.Size = new System.Drawing.Size(63, 36);
            this.btnInserirTarefa.TabIndex = 130;
            this.btnInserirTarefa.Text = "Inserir";
            this.btnInserirTarefa.UseVisualStyleBackColor = true;
            // 
            // btnRemoverTarefa
            // 
            this.btnRemoverTarefa.AutoSize = true;
            this.btnRemoverTarefa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoverTarefa.Depth = 0;
            this.btnRemoverTarefa.Location = new System.Drawing.Point(409, 78);
            this.btnRemoverTarefa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoverTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoverTarefa.Name = "btnRemoverTarefa";
            this.btnRemoverTarefa.Primary = false;
            this.btnRemoverTarefa.Size = new System.Drawing.Size(75, 36);
            this.btnRemoverTarefa.TabIndex = 129;
            this.btnRemoverTarefa.Text = "Remover";
            this.btnRemoverTarefa.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.materialLabel11);
            this.panel4.Controls.Add(this.materialFlatButton1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.materialFlatButton4);
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.materialLabel7);
            this.panel4.Controls.Add(this.txtMetrosQuadrados);
            this.panel4.Controls.Add(this.materialLabel8);
            this.panel4.Controls.Add(this.txtQuantidadeHomens);
            this.panel4.Controls.Add(this.materialLabel9);
            this.panel4.Controls.Add(this.dataGridView4);
            this.panel4.Controls.Add(this.txtPesquisarServicoNome);
            this.panel4.Controls.Add(this.objServicoSelecionado);
            this.panel4.Controls.Add(this.btnBuscarServico);
            this.panel4.Location = new System.Drawing.Point(479, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 296);
            this.panel4.TabIndex = 129;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(409, 116);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(400, 175);
            this.dataGridView3.TabIndex = 132;
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
            this.materialLabel8.Size = new System.Drawing.Size(200, 19);
            this.materialLabel8.TabIndex = 129;
            this.materialLabel8.Text = "Quantidade de trabalhadores";
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
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 116);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(400, 175);
            this.dataGridView4.TabIndex = 123;
            // 
            // txtPesquisarServicoNome
            // 
            this.txtPesquisarServicoNome.Depth = 0;
            this.txtPesquisarServicoNome.Hint = "Nome serviço";
            this.txtPesquisarServicoNome.Location = new System.Drawing.Point(19, 84);
            this.txtPesquisarServicoNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisarServicoNome.Name = "txtPesquisarServicoNome";
            this.txtPesquisarServicoNome.PasswordChar = '\0';
            this.txtPesquisarServicoNome.SelectedText = "";
            this.txtPesquisarServicoNome.SelectionLength = 0;
            this.txtPesquisarServicoNome.SelectionStart = 0;
            this.txtPesquisarServicoNome.Size = new System.Drawing.Size(180, 23);
            this.txtPesquisarServicoNome.TabIndex = 124;
            this.txtPesquisarServicoNome.UseSystemPasswordChar = false;
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
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(15, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(44, 19);
            this.materialLabel5.TabIndex = 127;
            this.materialLabel5.Text = "Filtro";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(697, 11);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 131;
            this.materialLabel4.Text = "Unidade";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(15, 37);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 130;
            this.materialLabel6.Text = "Tarefa";
            // 
            // objTarefa
            // 
            this.objTarefa.Depth = 0;
            this.objTarefa.Enabled = false;
            this.objTarefa.Hint = "Não selecionada";
            this.objTarefa.Location = new System.Drawing.Point(70, 33);
            this.objTarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.objTarefa.Name = "objTarefa";
            this.objTarefa.PasswordChar = '\0';
            this.objTarefa.SelectedText = "";
            this.objTarefa.SelectionLength = 0;
            this.objTarefa.SelectionStart = 0;
            this.objTarefa.Size = new System.Drawing.Size(172, 23);
            this.objTarefa.TabIndex = 129;
            this.objTarefa.UseSystemPasswordChar = false;
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
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(492, 78);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 134;
            this.materialFlatButton1.Text = "Inserir";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(409, 78);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(75, 36);
            this.materialFlatButton4.TabIndex = 133;
            this.materialFlatButton4.Text = "Remover";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(332, 81);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton2.TabIndex = 131;
            this.materialFlatButton2.Text = "Lançar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialLabel10.Location = new System.Drawing.Point(-1, -1);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(116, 19);
            this.materialLabel10.TabIndex = 133;
            this.materialLabel10.Text = "Inserir Produtos";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(-1, -1);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(113, 19);
            this.materialLabel11.TabIndex = 135;
            this.materialLabel11.Text = "Inserir Serviços";
            // 
            // LancarMateriaisServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LancarMateriaisServicos";
            this.Text = "Lancar Materiais e Servicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapasTarefas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField objObraSelecionada;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarObra;
        private System.Windows.Forms.DataGridView dgvEtapasTarefas;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarEtapaTarefa;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarTarefa;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpDataLanc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisarProdutoNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField objProdutoSelecionado;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnidadeProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidadeProdutos;
        private MaterialSkin.Controls.MaterialFlatButton btnInserirTarefa;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoverTarefa;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMetrosQuadrados;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidadeHomens;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisarServicoNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField objServicoSelecionado;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarServico;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField objTarefa;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
    }
}
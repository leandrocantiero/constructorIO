using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    public partial class LancarMateriaisServicos : MaterialSkin.Controls.MaterialForm
    {
        private Model.Obra obraTela;
        private Model.Material materialTela;
        private Model.Servico servicoTela;
        private Model.Tarefa tarefaTela;
        private Model.ConsumoServico consumoServicoTela;
        private Model.ConsumoMaterial consumoMaterialTela;
        private Model.ConsumoMaterialServico consumoMatServTela;

        private Controller.ObrasController obrasController;
        private Controller.MaterialController materialController;
        private Controller.ServicoController servicoController;
        private Controller.ControllerConsumoMaterialServico controllerConsumoMaterialServico;

        private new BindingList<object> tarefasDisponiveis;

        private new BindingList<Model.Material> materiaisDisponiveis;
        private new BindingList<Model.ConsumoMaterial> materiaisSelecionados;
        private new BindingList<Model.Servico> servicosDisponiveis;
        private new BindingList<Model.ConsumoServico> consumoServicosSelecionados;


        

        public LancarMateriaisServicos()
        {
            InitializeComponent();

            this.Load += new EventHandler(afterLoadView);

            obrasController = new Controller.ObrasController();
            materialController = new Controller.MaterialController();
            servicoController = new Controller.ServicoController();
            controllerConsumoMaterialServico = new Controller.ControllerConsumoMaterialServico();
        }

        private void afterLoadView(System.Object sender, System.EventArgs e)
        {
            initTela();
        }

        private void initTela()
        {
            obraTela = null;
            materialTela = null;
            servicoTela = null;
            tarefaTela = null;

            identificadorSelecionarMateriais.ForeColor = Color.Black;
            identificadorSelecionarMateriais.Font = new Font("Roboto", 10, FontStyle.Bold);

            identificadorSelecionarObra.ForeColor = Color.Black;
            identificadorSelecionarObra.Font = new Font("Roboto", 10, FontStyle.Bold);

            identificadorSelecionarServicos.ForeColor = Color.Black;
            identificadorSelecionarServicos.Font = new Font("Roboto", 10, FontStyle.Bold);

            identificadorSelecionarTarefa.ForeColor = Color.Black;
            identificadorSelecionarTarefa.Font = new Font("Roboto", 10, FontStyle.Bold);

            identificadorBuscarTarefa.ForeColor = Color.Black;
            identificadorBuscarTarefa.Font = new Font("Roboto", 10, FontStyle.Bold);
            identificadorBuscarTarefa.Font = new Font("Roboto", 10, FontStyle.Bold);

            this.dgvTarefas.DataSource = null;
            this.dgvMateriaisDisponiveis.DataSource = null;
            this.dgvMateriaisSelecionados.DataSource = null;
            this.dgvServicosDisponiveis.DataSource = null;
            this.dgvServicosSelecionados.DataSource = null;

            tarefasDisponiveis = null;

            materiaisDisponiveis = null;
            materiaisSelecionados = null;
            servicosDisponiveis = null;
            consumoServicosSelecionados = null;
            consumoMatServTela = null;

            obraTela = null;
            materialTela = null;
            servicoTela = null;
            tarefaTela = null;
            consumoServicoTela = null;
            consumoMaterialTela = null;


            limparMaterialTela();
            limparServicoTela();
            limparTarefaSelecionada();
            limparObraSelecionada();

            //b.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            //b.Font = new Font("Roboto", 9, FontStyle.Bold);
            //b.Size = new Size(width, heigh);
            //b.ForeColor = Color.White;
            //b.AutoSize = true;
            //b.TabStop = false;
            //b.FlatStyle = FlatStyle.Flat;
            //b.FlatAppearance.BorderSize = 0;
            //b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);




            configurarFormsIniciais();
            carregarDados();
        }

        private void limparTarefaSelecionada()
        {
            tarefaTela = null;
            objTarefa.Text = "";
            objEtapa.Text = "";
        }

        private void limparObraSelecionada()
        {
            objObraSelecionada.Text = "";
            obraTela = null;
        }

        private void configurarFormsIniciais()
        {
            modoInserir();
            modoInserirMaterial();
            modoInserirServico();
        }

        private void modoInserir()
        {
            objObraSelecionada.Enabled = false;
            objEtapa.Enabled = false;
            
            objProdutoSelecionado.Enabled = false;
            txtUnidadeProduto.Enabled = false;

            objServicoSelecionado.Enabled = false;

            dgvMateriaisSelecionados.Enabled = true;
            dgvServicosSelecionados.Enabled = true;
            dgvMateriaisDisponiveis.Enabled = true;
            dgvServicosDisponiveis.Enabled = true;
            dgvTarefas.Enabled = true;

            btnExcluir.Enabled = false;

            btnBuscarObra.Enabled = true;
            btnLançarMatServ.Enabled = true;
            btnBuscarTarefa.Enabled = true;
            btnBuscarProduto.Enabled = true;
            btnBuscarServico.Enabled = true;
            btnInserirMaterial.Visible = true;
            btnInserirServico.Visible = true;
            btnRemoverMaterial.Visible = true;
            btnRemoverServico.Visible = true;
            txtBuscarTarefa.Enabled = true;
            txtBuscarProduto.Enabled = true;
            txtBuscarServico.Enabled = true;
            txtQuantidadeHomens.Enabled = true;
            txtQuantidadeProdutos.Enabled = true;
            txtMetrosQuadrados.Enabled = true;

            dtpDataLanc.Enabled = true;

            btnCancelarExclusao.Enabled = false;

        }

        private void modoExcluir()
        {
            btnExcluir.Enabled = true;

            dgvMateriaisSelecionados.Enabled = true;
            dgvServicosSelecionados.Enabled = true;
            dgvMateriaisDisponiveis.Enabled = false;
            dgvServicosDisponiveis.Enabled = false;
            dgvTarefas.Enabled = false;

            btnBuscarObra.Enabled = false;
            btnBuscarTarefa.Enabled = false;
            btnBuscarProduto.Enabled = false;
            btnBuscarServico.Enabled = false;
            btnInserirMaterial.Visible = false;
            btnInserirServico.Visible = false;
            btnRemoverMaterial.Visible = false;
            btnRemoverServico.Visible = false;
            txtBuscarTarefa.Enabled = false;
            txtBuscarProduto.Enabled = false;
            txtBuscarServico.Enabled = false;
            txtQuantidadeHomens.Enabled = false;
            txtQuantidadeProdutos.Enabled = false;
            txtMetrosQuadrados.Enabled = false;
            btnLançarMatServ.Enabled = false;

            dtpDataLanc.Enabled = false;

            btnCancelarExclusao.Enabled = true;
        }

        private void modoInserirMaterial()
        {
            btnInserirMaterial.Enabled = true;
            btnRemoverMaterial.Enabled = false;
        }

        private void modoInserirServico()
        {
            btnInserirServico.Enabled = true;
            btnRemoverServico.Enabled = false;

        }

        private void modoAlterarMaterial()
        {
            btnInserirMaterial.Enabled = false;
            btnRemoverMaterial.Enabled = true;

        }

        private void modoAlterarServico()
        {
            btnInserirServico.Enabled = false;
            btnRemoverServico.Enabled = true;

        }

        private void carregarDados()
        {
            carregarMateriais();
            carregarServicos();
        }

        private void carregarMateriais(string nome = null)
        {
            List<Model.Material> produtos = materialController.obterTodos(nome);
            configurarGridMateriaisDisponiveis(produtos);
        }

        private void configurarGridMateriaisDisponiveis(List<Model.Material> produtos = null)
        {
            if(produtos == null)
            {
                carregarMateriais();
            }
            else
            {
                this.materiaisDisponiveis = new BindingList<Model.Material>(produtos);
                this.dgvMateriaisDisponiveis.DataSource = null;
                this.dgvMateriaisDisponiveis.DataSource = this.materiaisDisponiveis;

                if (this.materiaisDisponiveis.Count > 0)
                {
                    dgvMateriaisDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgvMateriaisDisponiveis.Columns["Cod"].Visible = false;
                    dgvMateriaisDisponiveis.Columns["Valor"].Visible = false;

                    dgvMateriaisDisponiveis.Columns["Nome"].HeaderText = "Nome";
                    dgvMateriaisDisponiveis.Columns["Nome"].DisplayIndex = 1;
                    dgvMateriaisDisponiveis.Columns["Nome"].ReadOnly = true;


                    dgvMateriaisDisponiveis.Columns["Estoque"].HeaderText = "Estoque atual";
                    dgvMateriaisDisponiveis.Columns["Estoque"].DisplayIndex = 2;
                    dgvMateriaisDisponiveis.Columns["Estoque"].ReadOnly = true;

                    dgvMateriaisDisponiveis.Columns["Unidade"].HeaderText = "Unidade";
                    dgvMateriaisDisponiveis.Columns["Unidade"].DisplayIndex = 3;
                    dgvMateriaisDisponiveis.Columns["Unidade"].ReadOnly = true;


                    dgvMateriaisDisponiveis.Columns["Categoria"].HeaderText = "Categoria";
                    dgvMateriaisDisponiveis.Columns["Categoria"].DisplayIndex = 4;
                    dgvMateriaisDisponiveis.Columns["Categoria"].ReadOnly = true;


                    //dgvMateriaisDisponiveis.Columns["Valor"].HeaderText = "Valor";
                    //dgvMateriaisDisponiveis.Columns["Valor"].DisplayIndex = 5;
                    //dgvMateriaisDisponiveis.Columns["Valor"].ReadOnly = true;

                    dgvMateriaisDisponiveis.Columns["Descricao"].HeaderText = "Descricao";
                    dgvMateriaisDisponiveis.Columns["Descricao"].DisplayIndex = 6;
                    dgvMateriaisDisponiveis.Columns["Descricao"].ReadOnly = true;
                }
            }
        }

        private void carregarServicos(string nome = null)
        {
            List<Model.Servico> servicos = servicoController.obterTodos(nome);
            configurarGridServicosDisponiveis(servicos);
        }

        private void configurarGridServicosDisponiveis(List<Model.Servico> servicos = null)
        {
            if (servicos == null)
            {
                carregarServicos();
            }
            else
            {
                this.servicosDisponiveis = new BindingList<Model.Servico>(servicos);
                this.dgvServicosDisponiveis.DataSource = null;
                this.dgvServicosDisponiveis.DataSource = this.servicosDisponiveis;

                if (this.servicosDisponiveis.Count > 0)
                {
                    dgvServicosDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgvServicosDisponiveis.Columns["Cod"].Visible = false;

                    dgvServicosDisponiveis.Columns["Nome"].HeaderText = "Nome do serviço";
                    dgvServicosDisponiveis.Columns["Nome"].DisplayIndex = 1;
                    dgvServicosDisponiveis.Columns["Nome"].ReadOnly = true;

                    dgvServicosDisponiveis.Columns["QuantidadeHomem"].HeaderText = "Quantidade de trabalhadores disponíveis";
                    dgvServicosDisponiveis.Columns["QuantidadeHomem"].DisplayIndex = 2;
                    dgvServicosDisponiveis.Columns["QuantidadeHomem"].ReadOnly = true;


                    dgvServicosDisponiveis.Columns["Observacao"].HeaderText = "Observação";
                    dgvServicosDisponiveis.Columns["Observacao"].DisplayIndex = 3;
                    dgvServicosDisponiveis.Columns["Observacao"].ReadOnly = true;
                }
            }
        }


        private void configurarTarefasSelecionadas(int codObra, string descricao = null)
        {
            List<object> tarefas = null;

            tarefas = obrasController.obterTodasTarefasPorObra(codObra, descricao != null && descricao.Length != 0 ? descricao : null);

            if(descricao == null)
            {
                if(tarefas != null && tarefas.Count == 0)
                {
                    MessageBox.Show("Nenhuma tarefa encontrada", "Aviso");
                    return;
                }
            }

            configurarGridTarefasSelecionadas(tarefas);
        }

     

        public void setarObraTela(object obra)
        {
            if(obra != null)
            {
                this.obraTela = (Model.Obra) obra;
                objObraSelecionada.Text = this.obraTela.getEndereco().getRua() + ", " + this.obraTela.getEndereco().getNumero();

                configurarTarefasSelecionadas(this.obraTela.Cod);
            }
        }



        private void configurarGridTarefasSelecionadas(List<object> tarefas)
        {
            this.tarefasDisponiveis = new BindingList<object>(tarefas);

            //configurar colunas depois

            this.dgvTarefas.DataSource = null;
            this.dgvTarefas.DataSource = this.tarefasDisponiveis;

            if (tarefasDisponiveis.Count > 0)
            {
                dgvTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvTarefas.Columns["Cod"].Visible = false;

                dgvTarefas.Columns["Descricao"].HeaderText = "Tarefa";
                dgvTarefas.Columns["Descricao"].DisplayIndex = 1;
                dgvTarefas.Columns["Descricao"].ReadOnly = true;

                dgvTarefas.Columns["Etapa"].HeaderText = "Etapa";
                dgvTarefas.Columns["Etapa"].DisplayIndex = 2;
                dgvTarefas.Columns["Etapa"].ReadOnly = true;
            }
        }


        private void btnBuscarEtapaTarefa_Click(object sender, EventArgs e)
        {
            if(this.obraTela == null)
            {
                MessageBox.Show("Selecione uma obra para buscar sua tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            configurarTarefasSelecionadas(this.obraTela.getCod(), txtBuscarTarefa.Text);

        }

        private void btnBuscarObra_Click(object sender, EventArgs e)
        {
            var buscarObra = new View.BuscarObra(this);
            buscarObra.Show();
        }

        private void OnClickGridTarefa(object sender, DataGridViewCellMouseEventArgs e)
        {
            var tarefa = (Model.Tarefa)dgvTarefas.CurrentRow?.DataBoundItem;
            
            if (tarefa != null)
            {
                this.tarefaTela = tarefa;
                objTarefa.Text = tarefa.getDescricao();
                objEtapa.Text = tarefa.getEtapa().getDescricao();
            }
            else
            {
                MessageBox.Show("É preciso ter uma obra selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            carregarMateriais(txtBuscarProduto.Text);
        }

        private void btnBuscarServico_Click(object sender, EventArgs e)
        {
            carregarServicos(txtBuscarServico.Text);
        }

        private void dgvMateriaisDisponiveis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var material = (Model.Material)dgvMateriaisDisponiveis.CurrentRow?.DataBoundItem;

            if (material != null)
            {
                setarMaterialTela(material, null);
                modoInserirMaterial();
            }
        }

        private void btnInserirTarefa_Click(object sender, EventArgs e)
        {
            if(this.materialTela != null)
            {
                try
                {
                    if (Convert.ToInt32(txtQuantidadeProdutos.Text) <= 0)
                    {
                        MessageBox.Show("Informe uma quantidade maior que 0 para o material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Informe uma quantidade númerica para o material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (this.materiaisSelecionados == null)
                {
                    this.materiaisSelecionados = new BindingList<Model.ConsumoMaterial>();
                }

                if(this.tarefaTela == null)
                {
                    MessageBox.Show("Selecione uma tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //VERIFICAR DUPLICIDADE
                bool contemMaterial = false;
                foreach(var ms in this.materiaisSelecionados)
                {
                    if(ms.getMaterial().getCod() == materialTela.getCod() && 
                        ms.getTarefa().getCod() == this.tarefaTela.getCod() &&
                        ms.getTarefa().getEtapa().getCod() == this.tarefaTela.getEtapa().getCod())
                    {
                        contemMaterial = true;
                        break;
                    }
                }

                if(contemMaterial)
                {
                    MessageBox.Show("Material já inserido na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(this.materialTela.getEstoque() < Convert.ToInt32(txtQuantidadeProdutos.Text))
                {
                    MessageBox.Show("Quantidade não pode ser maior que a disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(this.tarefaTela == null)
                    {
                        MessageBox.Show("Selecione uma tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.consumoMaterialTela = controllerConsumoMaterialServico.getConsumoMaterial();
                    this.consumoMaterialTela.setConsumoMaterialServico(null);
                    this.consumoMaterialTela.setMaterial(this.materialTela);
                    this.consumoMaterialTela.setConsumoMaterialServico(null);
                    this.consumoMaterialTela.setTarefa(this.tarefaTela);
                    this.consumoMaterialTela.setQuantidadeMaterial(Convert.ToInt32(txtQuantidadeProdutos.Text));

                    this.materiaisSelecionados.Add(this.consumoMaterialTela);


                    configurarGridMateriaisSelecionados(new List<Model.ConsumoMaterial>(this.materiaisSelecionados));
                    limparMaterialTela();
                }
            }
        }

        private void configurarGridMateriaisSelecionados(List<Model.ConsumoMaterial> materiais)
        {
            this.materiaisSelecionados = new BindingList<Model.ConsumoMaterial>(materiais);

            //configurar colunas depois

            this.dgvMateriaisSelecionados.DataSource = null;
            this.dgvMateriaisSelecionados.DataSource = this.materiaisSelecionados;

            /*
            public DateTime Data { get => _data; set => _data = value; }
            public int QuantidadeMaterial { get => _quantidadeMaterial; set => _quantidadeMaterial = value; }
            public Material Material { get => _material; set => _material = value; }
            public ConsumoMaterialServico ConsumoMaterialServico { get => _consumoMaterialServico; set => _consumoMaterialServico = value; }
            public Tarefa Tarefa { get => _tarefa; set => _tarefa = value; }
            
                public string MostraTelaEtapa { get => _MostraTelaEtapa; set => _MostraTelaEtapa = value; }
             public string MostraTelaDescricao { get => _MostraTelaDescricao; set => _MostraTelaDescricao = value; }
                public string MostraTelaUnidade { get => _MostraTelaUnidade; set => _MostraTelaUnidade = value; }
             */

            //add atributos a mais para grid
            foreach (var cm in materiais)
            {
                cm.MostraTelaEtapa = cm.getTarefa().getEtapa().getDescricao();
                cm.MostraTelaDescricao = cm.getMaterial().getDescricao();
                cm.MostraTelaUnidade = cm.getMaterial().getUnidade();
            }


            if (this.materiaisSelecionados.Count > 0)
            {
                dgvMateriaisSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvMateriaisSelecionados.Columns["Data"].Visible = false;
                dgvMateriaisSelecionados.Columns["ConsumoMaterialServico"].Visible = false;
                
                dgvMateriaisSelecionados.Columns["Material"].HeaderText = "Nome do material";
                dgvMateriaisSelecionados.Columns["Material"].DisplayIndex = 1;
                dgvMateriaisSelecionados.Columns["Material"].ReadOnly = true;

                dgvMateriaisSelecionados.Columns["QuantidadeMaterial"].HeaderText = "Quantidade de material";
                dgvMateriaisSelecionados.Columns["QuantidadeMaterial"].DisplayIndex = 2;
                dgvMateriaisSelecionados.Columns["QuantidadeMaterial"].ReadOnly = true;

                dgvMateriaisSelecionados.Columns["Tarefa"].HeaderText = "Nome da Tarefa";
                dgvMateriaisSelecionados.Columns["Tarefa"].DisplayIndex = 3;
                dgvMateriaisSelecionados.Columns["Tarefa"].ReadOnly = true;

                dgvMateriaisSelecionados.Columns["MostraTelaEtapa"].HeaderText = "Nome da Etapa";
                dgvMateriaisSelecionados.Columns["MostraTelaEtapa"].DisplayIndex = 4;
                dgvMateriaisSelecionados.Columns["MostraTelaEtapa"].ReadOnly = true;

                dgvMateriaisSelecionados.Columns["MostraTelaDescricao"].HeaderText = "Descrição do produto";
                dgvMateriaisSelecionados.Columns["MostraTelaDescricao"].DisplayIndex = 5;
                dgvMateriaisSelecionados.Columns["MostraTelaDescricao"].ReadOnly = true;

                dgvMateriaisSelecionados.Columns["MostraTelaUnidade"].HeaderText = "Unidade do produto";
                dgvMateriaisSelecionados.Columns["MostraTelaUnidade"].DisplayIndex = 6;
                dgvMateriaisSelecionados.Columns["MostraTelaUnidade"].ReadOnly = true;
            }
        }

        private void limparMaterialTela()
        {
            this.materialTela = null;

            objProdutoSelecionado.Text = "";
            txtUnidadeProduto.Text = "";
            txtQuantidadeProdutos.Text = "";
        }

        private void setarMaterialTela(Model.Material material, Model.ConsumoMaterial consumoMaterial)
        {
            if(material != null)
            {
                this.materialTela = material;

                objProdutoSelecionado.Text = material.getNome();
                txtUnidadeProduto.Text = material.getUnidade();
            }
            else if(consumoMaterial != null)
            {
                this.consumoMaterialTela = consumoMaterial;

                objProdutoSelecionado.Text = this.consumoMaterialTela.getMaterial().getNome();
                txtUnidadeProduto.Text = this.consumoMaterialTela.getMaterial().getUnidade();
                txtQuantidadeProdutos.Text = this.consumoMaterialTela.getQuantidadeMaterial().ToString();
            }
        }

        private void btnRemoverTarefa_Click(object sender, EventArgs e)
        {
            if (this.consumoMaterialTela != null)
            {
                this.materiaisSelecionados.Remove(this.consumoMaterialTela);
                limparMaterialTela();
            }
        }

        private void btnInserirServico_Click(object sender, EventArgs e)
        {
            if (this.servicoTela != null)
            {

                try
                {
                    if (Convert.ToInt32(txtQuantidadeHomens.Text) <= 0)
                    {
                        MessageBox.Show("A quantidade de trabalhores para o serviço tem que ser maior que 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("A quantidade de trabalhores tem que ser númerico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (txtMetrosQuadrados.Text.Length == 0)
                        txtMetrosQuadrados.Text = "0";

                    if (Convert.ToInt32(txtMetrosQuadrados.Text) < 0)
                    {
                        MessageBox.Show("A quantidade de metros quadrados para o serviço tem que ser maior igual ou maior que 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A quantidade de metros quadrados tem que ser númerico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if(Convert.ToInt32(txtQuantidadeHomens.Text) < this.servicoTela.getQuantidadeHomem() )
                {
                    MessageBox.Show("A quantidade de trabalhores para o serviço tem que ser maior ou igual a " + this.servicoTela.getQuantidadeHomem() + ".",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.consumoServicosSelecionados == null)
                        this.consumoServicosSelecionados = new BindingList<Model.ConsumoServico>();


                    if (this.tarefaTela == null)
                    {
                        MessageBox.Show("Selecione uma tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //TRATAR ESSA VERIFICACAO
                    bool contemMaterial = false;
                    foreach(var css in this.consumoServicosSelecionados)
                    {
                        if( css.getServico().getCod() == this.servicoTela.getCod() &&
                            css.getTarefa().getCod() == this.tarefaTela.getCod() &&
                                css.getTarefa().getEtapa().getCod() == this.tarefaTela.getEtapa().getCod())
                        {
                            contemMaterial = true;
                            break;
                        }
                    }

                    if (contemMaterial)
                    {
                        MessageBox.Show("Serviço já inserido na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var consumoServico = controllerConsumoMaterialServico.getConsumoServico();
                        consumoServico.setConsumoMaterialServico(null);
                        consumoServico.setServico(this.servicoTela);

                        if (this.tarefaTela == null)
                        {
                            MessageBox.Show("Selecione uma tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            consumoServico.setTarefa(this.tarefaTela);
                        }

                        try
                        {

                            //inserir qntd homem
                            consumoServico.setQuantidadeHomem(Convert.ToInt32(txtQuantidadeHomens.Text));

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Informe um valor para quantidade de Trabalhadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            //inserir metragem quadrada
                            decimal qntdM2 = Convert.ToDecimal(txtMetrosQuadrados.Text);
                            consumoServico.setMetrosQuadrados(qntdM2);

                        }
                        catch(Exception ex)
                        {
                            consumoServico.setMetrosQuadrados(0);
                        }

                        this.consumoServicosSelecionados.Add(consumoServico);

                        configurarGridServicosSelecionados(new List<Model.ConsumoServico>(this.consumoServicosSelecionados));

                        limparServicoTela();
                    }
                }

            }
        }

        private void configurarGridServicosSelecionados(List<Model.ConsumoServico> servicos)
        {
            this.consumoServicosSelecionados = new BindingList<Model.ConsumoServico>(servicos);
            
            this.dgvServicosSelecionados.DataSource = null;
            this.dgvServicosSelecionados.DataSource = this.consumoServicosSelecionados;


            /*   public int QuantidadeHomem { get => _quantidadeHomem; set => _quantidadeHomem = value; }
        public decimal MetrosQuadrados { get => _metrosQuadrados; set => _metrosQuadrados = value; }
        public Servico Servico { get => _servico; set => _servico = value; }
        public ConsumoMaterialServico ConsumoMaterialServico { get => _consumoMaterialServico; set => _consumoMaterialServico = value; }
        public DateTime Data { get => _data; set => _data = value; }



                public string MostraTelaEtapa { get => _MostraTelaEtapa; set => _MostraTelaEtapa = value; }
                public string MostraTelaDescricao { get => _MostraTelaDescricao; set => _MostraTelaDescricao = value; }
                public string MostraTelaUnidade { get => _MostraTelaUnidade; set => _MostraTelaUnidade = value; }

                    //add atributos a mais para grid
                    foreach (var cm in materiais)
                    {
                        cm.MostraTelaEtapa = cm.getTarefa().getEtapa().getDescricao();
                cm.MostraTelaDescricao = cm.getMaterial().getDescricao();
                cm.MostraTelaUnidade = cm.getMaterial().getUnidade();
    }
            */


            //add atributos a mais para grid
            foreach (var cs in servicos)
            {
                cs.MostraTelaEtapa = cs.getTarefa().getEtapa().getDescricao();
            }


            if (this.consumoServicosSelecionados.Count > 0)
            {
                dgvServicosSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvServicosSelecionados.Columns["ConsumoMaterialServico"].Visible = false;
                dgvServicosSelecionados.Columns["Data"].Visible = false;

                dgvServicosSelecionados.Columns["Servico"].HeaderText = "Nome do Serviço";
                dgvServicosSelecionados.Columns["Servico"].DisplayIndex = 1;
                dgvServicosSelecionados.Columns["Servico"].ReadOnly = true;

                dgvServicosSelecionados.Columns["MostraTelaEtapa"].HeaderText = "Nome da etapa";
                dgvServicosSelecionados.Columns["MostraTelaEtapa"].DisplayIndex = 2;
                dgvServicosSelecionados.Columns["MostraTelaEtapa"].ReadOnly = true;

                dgvServicosSelecionados.Columns["Tarefa"].HeaderText = "Nome da tarefa";
                dgvServicosSelecionados.Columns["Tarefa"].DisplayIndex = 3;
                dgvServicosSelecionados.Columns["Tarefa"].ReadOnly = true;

                dgvServicosSelecionados.Columns["QuantidadeHomem"].HeaderText = "Quantidade de trabalhadores utilizados.";
                dgvServicosSelecionados.Columns["QuantidadeHomem"].DisplayIndex = 5;
                dgvServicosSelecionados.Columns["QuantidadeHomem"].ReadOnly = true;


                dgvServicosSelecionados.Columns["MetrosQuadrados"].HeaderText = "Metros Quadrados";
                dgvServicosSelecionados.Columns["MetrosQuadrados"].DisplayIndex = 6;
                dgvServicosSelecionados.Columns["MetrosQuadrados"].ReadOnly = true;

            }
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            if (this.consumoServicoTela != null)
            {
                this.consumoServicosSelecionados.Remove(this.consumoServicoTela);
                limparServicoTela();
            }
        }

        private void setarServicoTela(Model.ConsumoServico consumoServicoTela, Model.Servico servico)
        {
            if(servico!= null)
            {
                this.servicoTela = servico;
                objServicoSelecionado.Text = servico.getNome();
            }
            else if(consumoServicoTela != null)
            {
                this.consumoServicoTela = consumoServicoTela;
                objServicoSelecionado.Text = consumoServicoTela.getServico().getNome();
                txtQuantidadeHomens.Text = consumoServicoTela.getQuantidadeHomem().ToString();
                txtMetrosQuadrados.Text = consumoServicoTela.getMetrosQuadrados().ToString();
            }
        }

        private void limparServicoTela()
        {
            this.servicoTela = null;
            this.consumoServicoTela = null;
            objServicoSelecionado.Text = "";
            txtMetrosQuadrados.Text = "";
            txtQuantidadeHomens.Text = "";
        }

        private void dgvMaterialSelecionadoOnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var consumoMat = (Model.ConsumoMaterial)dgvMateriaisSelecionados.CurrentRow?.DataBoundItem;

            if (consumoMat != null)
            {
                setarMaterialTela(null, consumoMat);
                modoAlterarMaterial();
            }
        }

        //private void btnAlterarMaterial_Click(object sender, EventArgs e)
        //{
        //    if (this.materialTela != null)
        //    {
        //        var materialEstoque = materialController.obterUm(this.materialTela.getCod());

        //        if(materialEstoque != null && materialEstoque.getEstoque() < this.materialTela.getEstoque())
        //        {
        //            //remove
        //            this.materiaisSelecionados.Remove(this.materialTela);

        //            //insere de volta

        //            this.materiaisSelecionados.Add(this.materialTela);

        //            configurarGridMateriaisSelecionados(new List<Model.Material>(this.materiaisSelecionados));
        //            limparMaterialTela();
        //            modoInserirMaterial();
        //        }
        //    }
        //}

        private void btnAlterarServico_Click(object sender, EventArgs e)
        {
            //if (this.servicoTela.getQuantidadeHomem() <= 0)
            //{

            //}
            //else if(this.servicoTela.get <= 0)
            //{
            //    //remove
            //    this.materiaisSelecionados.Remove((object)this.materialTela);

            //    //insere de volta

            //    this.materiaisSelecionados.Add((object)this.materialTela);

            //    configurarGridMateriaisSelecionados(new List<object>(this.materiaisSelecionados));
            //    limparMaterialTela();
            //    modoInserirMaterial();
            //}
        }

        private void dgvServicoDisponiveis_OnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var servico = (Model.Servico)dgvServicosDisponiveis.CurrentRow?.DataBoundItem;

            if (servico != null)
            {
                
                setarServicoTela(null, servico);
            }
        }

        private void btnLançarMatServ_Click(object sender, EventArgs e)
        {
            if(this.obraTela == null)
            {
                MessageBox.Show("Selecione uma obra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.tarefaTela == null)
            {
                MessageBox.Show("Selecione uma tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.tarefasDisponiveis == null || this.tarefasDisponiveis.Count == 0 || 
                    this.tarefaTela == null)
            {
                MessageBox.Show("Selecione uma tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if((this.materiaisSelecionados != null && this.materiaisSelecionados.Count == 0) || 
                (this.consumoServicosSelecionados != null && this.consumoServicosSelecionados.Count == 0))
            {
                MessageBox.Show("Selecione um material ou serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                controllerConsumoMaterialServico.cadastrar(
                    this.obraTela,
                    this.materiaisSelecionados == null ? null : new List<Model.ConsumoMaterial>(this.materiaisSelecionados),
                    this.consumoServicosSelecionados == null ? null : new List<Model.ConsumoServico>(this.consumoServicosSelecionados), 
                    Convert.ToDateTime(dtpDataLanc.Value)
                );

                initTela();

                MessageBox.Show("Lançado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void dgvConsumoServicoOnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var consumoServicoSelecionado = (Model.ConsumoServico)dgvServicosSelecionados.CurrentRow?.DataBoundItem;

            if(consumoServicoSelecionado != null)
            {
                setarServicoTela(consumoServicoSelecionado, null);
            }
        }

        private void btnBuscarLancamentos_Click(object sender, EventArgs e)
        {
            var formBuscarConsumMatServ = new View.BuscarConsumoMatServ(this);
            formBuscarConsumMatServ.Show();
        }

        private void setarTarefa(Model.Tarefa tarefa)
        {
            this.tarefaTela = tarefa;
            objTarefa.Text = tarefa.getDescricao();
            objEtapa.Text = tarefa.getEtapa().getDescricao();
        }

        public void setarConsumoMatServ(Model.ConsumoMaterialServico consumoMaterialServico)
        {
            ///jogar infos na tela.
            ///
            setarObraTela(consumoMaterialServico.getObra());
            consumoMatServTela = consumoMaterialServico;

            if (consumoMaterialServico.getMateriais() != null && consumoMaterialServico.getMateriais().Count > 0)
            {
                setarTarefa(consumoMaterialServico.getMateriais()[0].getTarefa());
            }
            else if(consumoMaterialServico.getMateriais() != null && consumoMaterialServico.getMateriais().Count > 0)
            {
                setarTarefa(consumoMaterialServico.getServicos()[0].getTarefa());
            }


            if (consumoMaterialServico.getMateriais().Count > 0)
            {
                configurarGridMateriaisSelecionados(consumoMaterialServico.getMateriais());
            }

            if (consumoMaterialServico.getServicos().Count > 0)
            {
                configurarGridServicosSelecionados(consumoMaterialServico.getServicos());
            }

            modoExcluir();
            //travar pra excluir somente
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //excluir!!

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar esse registro?", "Confirmação",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (!controllerConsumoMaterialServico.removerMatServTela(this.consumoMatServTela.getCod()))
                {
                    MessageBox.Show("Falha ao tentar excluir o registro.");
                }
                else
                {
                    MessageBox.Show("Registro excluído com sucesso.");
                    initTela();
                }
            }
        }

        private void btnCancelarExclusao_Click(object sender, EventArgs e)
        {
            initTela();
        }
    }
}

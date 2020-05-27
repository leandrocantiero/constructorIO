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

        private Controller.ObrasController obrasController;
        private Controller.MaterialController materialController;
        private Controller.ServicoController servicoController;

        private new BindingList<object> tarefasDisponiveis;

        private new BindingList<object> materiaisDisponiveis;
        private new BindingList<object> materiaisSelecionados;
        private new BindingList<object> servicosDisponiveis;
        private new BindingList<object> servicosSelecionados;


        public LancarMateriaisServicos()
        {
            InitializeComponent();
            configurarFormsIniciais();

            this.Load += new EventHandler(afterLoadView);

            obrasController = new Controller.ObrasController();
            materialController = new Controller.MaterialController();
            servicoController = new Controller.ServicoController();

            obraTela = null;
            materialTela = null;
            servicoTela = null;

        }

        private void afterLoadView(System.Object sender, System.EventArgs e)
        {
            configurarFormsIniciais();
            carregarDados();
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
        }

        private void modoInserirMaterial()
        {
            btnInserirMaterial.Enabled = true;
            btnAlterarMaterial.Enabled = false;
        }

        private void modoInserirServico()
        {
            btnInserirServico.Enabled = true;
            btnAlterarServico.Enabled = false;
        }

        private void modoAlterarMaterial()
        {
            btnInserirMaterial.Enabled = false;
            btnAlterarMaterial.Enabled = true;
        }

        private void modoAlterarServico()
        {
            btnInserirServico.Enabled = false;
            btnAlterarServico.Enabled = true;
        }

        private void carregarDados()
        {
            carregarMateriais();
            carregarServicos();
        }

        private void carregarMateriais(string nome = null)
        {
            List<object> produtos = materialController.obterTodos(nome);
            configurarGridMateriaisDisponiveis(produtos);
        }

        private void configurarGridMateriaisDisponiveis(List<object> produtos = null)
        {
            if(produtos == null)
            {
                carregarMateriais();
            }
            else
            {
                this.materiaisDisponiveis = new BindingList<object>(produtos);
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


                    dgvMateriaisDisponiveis.Columns["Categoria"].HeaderText = "Categoria";
                    dgvMateriaisDisponiveis.Columns["Categoria"].DisplayIndex = 2;
                    dgvMateriaisDisponiveis.Columns["Categoria"].ReadOnly = true;


                    dgvMateriaisDisponiveis.Columns["Unidade"].HeaderText = "Unidade";
                    dgvMateriaisDisponiveis.Columns["Unidade"].DisplayIndex = 3;
                    dgvMateriaisDisponiveis.Columns["Unidade"].ReadOnly = true;


                    dgvMateriaisDisponiveis.Columns["Estoque"].HeaderText = "Estoque atual";
                    dgvMateriaisDisponiveis.Columns["Estoque"].DisplayIndex = 4;
                    dgvMateriaisDisponiveis.Columns["Estoque"].ReadOnly = true;


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
            List<object> servicos = servicoController.obterTodos(nome);
            configurarGridServicosDisponiveis(servicos);
        }

        private void configurarGridServicosDisponiveis(List<object> servicos = null)
        {
            if (servicos == null)
            {
                carregarServicos();
            }
            else
            {
                this.servicosDisponiveis = new BindingList<object>(servicos);
                this.dgvServicosDisponiveis.DataSource = null;
                this.dgvServicosDisponiveis.DataSource = this.servicosDisponiveis;

                if (this.servicosDisponiveis.Count > 0)
                {
                    dgvServicosDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgvServicosDisponiveis.Columns["Cod"].Visible = false;

                    dgvServicosDisponiveis.Columns["Nome"].HeaderText = "Nome";
                    dgvServicosDisponiveis.Columns["Nome"].DisplayIndex = 1;
                    dgvServicosDisponiveis.Columns["Nome"].ReadOnly = true;

                    dgvServicosDisponiveis.Columns["QuantidadeHomem"].HeaderText = "Quantidade de homem";
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
                setarMaterialTela(material);
                modoInserirMaterial();
            }
        }

        private void btnInserirTarefa_Click(object sender, EventArgs e)
        {
            if(this.materialTela != null)
            {
                if(txtQuantidadeProdutos.Text.Length == 0)
                {
                    MessageBox.Show("Informe uma quantidade para o material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.materiaisSelecionados == null)
                    {
                        this.materiaisSelecionados = new BindingList<object>();
                    }

                    bool contemMaterial = this.materiaisSelecionados.Contains((object)materialTela);

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
                        this.materialTela.setEstoque(Convert.ToInt32(txtQuantidadeProdutos.Text));
                        this.materiaisSelecionados.Add((object)this.materialTela);

                        configurarGridMateriaisSelecionados(new List<object>(this.materiaisSelecionados));
                        limparMaterialTela();
                    }
                }

            }
        }

        private void configurarGridMateriaisSelecionados(List<object> materiais)
        {
            this.materiaisSelecionados = new BindingList<object>(materiais);

            //configurar colunas depois

            this.dgvMateriaisSelecionados.DataSource = null;
            this.dgvMateriaisSelecionados.DataSource = this.materiaisSelecionados;


            if (this.materiaisSelecionados.Count > 0)
            {
                dgvMateriaisSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvMateriaisSelecionados.Columns["Cod"].Visible = false;
                dgvMateriaisSelecionados.Columns["Valor"].Visible = false;

                dgvMateriaisSelecionados.Columns["Nome"].HeaderText = "Nome";
                dgvMateriaisSelecionados.Columns["Nome"].DisplayIndex = 1;
                dgvMateriaisSelecionados.Columns["Nome"].ReadOnly = true;


                dgvMateriaisSelecionados.Columns["Categoria"].HeaderText = "Categoria";
                dgvMateriaisSelecionados.Columns["Categoria"].DisplayIndex = 2;
                dgvMateriaisSelecionados.Columns["Categoria"].ReadOnly = true;


                dgvMateriaisSelecionados.Columns["Unidade"].HeaderText = "Unidade";
                dgvMateriaisSelecionados.Columns["Unidade"].DisplayIndex = 3;
                dgvMateriaisSelecionados.Columns["Unidade"].ReadOnly = true;


                dgvMateriaisSelecionados.Columns["Estoque"].HeaderText = "Estoque atual";
                dgvMateriaisSelecionados.Columns["Estoque"].DisplayIndex = 4;
                dgvMateriaisSelecionados.Columns["Estoque"].ReadOnly = true;


                //dgvMateriaisSelecionados.Columns["Valor"].HeaderText = "Valor";
                //dgvMateriaisSelecionados.Columns["Valor"].DisplayIndex = 5;
                //dgvMateriaisSelecionados.Columns["Valor"].ReadOnly = true;

                dgvMateriaisSelecionados.Columns["Descricao"].HeaderText = "Descricao";
                dgvMateriaisSelecionados.Columns["Descricao"].DisplayIndex = 6;
                dgvMateriaisSelecionados.Columns["Descricao"].ReadOnly = true;
            }
        }

        private void limparMaterialTela()
        {
            this.materialTela = null;

            objProdutoSelecionado.Text = "";
            txtUnidadeProduto.Text = "";
            txtQuantidadeProdutos.Text = "";
        }

        private void setarMaterialTela(Model.Material material)
        {
            this.materialTela = material;

            objProdutoSelecionado.Text = material.getNome();
            txtUnidadeProduto.Text = material.getUnidade();
        }

        private void btnRemoverTarefa_Click(object sender, EventArgs e)
        {
            if (this.materialTela != null)
            {
                this.materiaisSelecionados.Remove((object)this.materialTela);
                limparMaterialTela();
            }
        }

        private void btnInserirServico_Click(object sender, EventArgs e)
        {
            if (this.servicoTela != null)
            {
                if (txtQuantidadeHomens.Text.Length == 0)
                {
                    MessageBox.Show("Informe a quantidade de trabalhores para o serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.materiaisSelecionados == null)
                        this.materiaisSelecionados = new BindingList<object>();

                    bool contemMaterial = this.servicosSelecionados.Contains((object)servicoTela);

                    if (contemMaterial)
                    {
                        MessageBox.Show("Serviço já inserido na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.servicoTela.setQuantidadeHomem(Convert.ToInt32(txtQuantidadeHomens.Text));
                        this.materiaisSelecionados.Add((object)this.materialTela);

                        configurarGridServicosSelecionados(new List<object>(this.materiaisSelecionados));

                        limparServicoTela();
                    }
                }

            }
        }

        private void configurarGridServicosSelecionados(List<object> servicos)
        {
            this.servicosSelecionados = new BindingList<object>(servicos);

            this.dgvServicosSelecionados.DataSource = null;
            this.dgvServicosSelecionados.DataSource = this.servicosSelecionados;

            if (this.servicosSelecionados.Count > 0)
            {
                dgvServicosSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvServicosSelecionados.Columns["Cod"].Visible = false;

                dgvServicosSelecionados.Columns["Nome"].HeaderText = "Nome";
                dgvServicosSelecionados.Columns["Nome"].DisplayIndex = 1;
                dgvServicosSelecionados.Columns["Nome"].ReadOnly = true;

                dgvServicosSelecionados.Columns["QuantidadeHomem"].HeaderText = "Quantidade de trabalhares";
                dgvServicosSelecionados.Columns["QuantidadeHomem"].DisplayIndex = 2;
                dgvServicosSelecionados.Columns["QuantidadeHomem"].ReadOnly = true;


                dgvServicosSelecionados.Columns["Observacao"].HeaderText = "Observação";
                dgvServicosSelecionados.Columns["Observacao"].DisplayIndex = 3;
                dgvServicosSelecionados.Columns["Observacao"].ReadOnly = true;
            }
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            if (this.servicoTela != null)
            {
                this.servicosSelecionados.Remove((object)this.materialTela);
                limparServicoTela();   
            }
        }

        private void dgvServicosDisponiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var servico = (Model.Servico)dgvServicosDisponiveis.CurrentRow?.DataBoundItem;

            if (servico != null)
            {
                setarServicoTela(servico);
                limparServicoTela();
            }
        }

        private void setarServicoTela(Model.Servico servico)
        {
            objServicoSelecionado.Text = servico.getNome();
        }

        private void limparServicoTela()
        {
            objServicoSelecionado.Text = "";
            txtMetrosQuadrados.Text = "";
        }

        private void dgvMaterialSelecionadoOnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var material = (Model.Material)dgvMateriaisSelecionados.CurrentRow?.DataBoundItem;

            if (material != null)
            {
                setarMaterialTela(material);
                modoAlterarMaterial();
            }
        }

        private void btnAlterarMaterial_Click(object sender, EventArgs e)
        {
            if (this.materialTela != null)
            {
                var materialEstoque = materialController.obterUm(this.materialTela.getCod());

                if(materialEstoque != null && materialEstoque.getEstoque() < this.materialTela.getEstoque())
                {
                    //remove
                    this.materiaisSelecionados.Remove((object)this.materialTela);

                    //insere de volta

                    this.materiaisSelecionados.Add((object)this.materialTela);

                    configurarGridMateriaisSelecionados(new List<object>(this.materiaisSelecionados));
                    limparMaterialTela();
                    modoInserirMaterial();
                }
            }
        }

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
    }
}

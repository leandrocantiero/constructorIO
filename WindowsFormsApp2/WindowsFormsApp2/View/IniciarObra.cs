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
    public partial class IniciarObra : MaterialSkin.Controls.MaterialForm
    {
        private Model.Funcionario funcionarioSelecionado;
        private Model.Cliente clienteSelecionado;
        private Model.Obra obraTela; 

        private BindingList<object> obras;
        private BindingList<object> tarefasSelecionadas;
        private BindingList<object> tarefasDisponiveis;
        private BindingList<object> etapasDisponiveis;
        private BindingList<object> status;
        private BindingList<object> estados;
        private BindingList<object> cidades;

        private Controller.ObrasController obrasController;
        private Controller.CidadeController cidadeController;
        private Controller.EstadoController estadoController;


        public IniciarObra()
        {
            InitializeComponent();

            dtpDataPrevTermino.Value = DateTime.Now.AddDays(30);

            funcionarioSelecionado = null;
            clienteSelecionado = null;
            obraTela = null;
            obrasController = new Controller.ObrasController();
            cidadeController = new Controller.CidadeController();
            estadoController = new Controller.EstadoController();

            obras=new BindingList<object>();
            tarefasSelecionadas = new BindingList<object>();
            tarefasDisponiveis  = new BindingList<object>();
            etapasDisponiveis = new BindingList<object>();

            configurarFormsIniciais();

            this.Load += new EventHandler(afterLoadView);
        }

        public void afterLoadView(System.Object sender, System.EventArgs e)
        {
            initTela();
        }

        public void initTela()
        {
            configurarFormsIniciais();
            carregarDadosIniciais();
            limparTela();
        }


        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && txtValor.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        // ----------------------------------------------------------------------------- configurar campo valor


        private void limparTela()
        {
            this.dgvTarefasSelecionadas.DataSource = null;
            this.dgvTarefasSelecionadas.DataSource = new BindingList<object>();

            txtBairro.Text = "";
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
            txtRua.Text = "";
            txtValor.Text = "";
            txtDescricaoObra.Text = "";

            dtpDataInicio.Value = DateTime.Now;
            dtpDataPrevTermino.Value = DateTime.Now;
            dtpDataFim.Value = DateTime.Now;

            this.cbbEstado.SelectedIndex = 0;
            this.cbbCidade.SelectedIndex = 0;
        }

        private void configurarFormsIniciais()
        {
            //mascara valor
            //this.txtValor.Mask = "999.999.999,00";
            txtValor.KeyPress += ApenasValorNumerico;


            objFuncionario.Text = "Responsável não selecionado";
            objCliente.Text = "Cliente não selecionado";

            lblDataFim.Hide();
            dtpDataFim.Hide();
            
            btnCancelar.Hide();
            btnAlterar.Hide();
            btnInserir.Show();

            lblStatus.Hide();
            cbbStatus.Hide();


            cbbStatus.Enabled = true;
            dtpDataPrevTermino.Enabled = true;


            //alterar para inserir
            modoInserirAlterarNaoFinalizado();



        }
        private void modoInserirAlterarNaoFinalizado()
        {
            btnBuscarCliente.Enabled = true;
            btnBuscarEngenheiro.Enabled = true;

            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtComplemento.Enabled = true;
            txtCEP.Enabled = true;
            cbbCidade.Enabled = true;
            cbbEstado.Enabled = true;
            txtDescricaoObra.Enabled = true;

            txtValor.Enabled = true;
            dtpDataInicio.Enabled = true;
            dtpDataPrevTermino.Enabled = true;
            txtBuscarEtapa.Enabled = true;
            btnBuscarEtapa.Enabled = true;


            btnInserirTarefa.Enabled = true;
            btnRemoverTarefa.Enabled = true;

            //txtBuscarObraEndereco.Enabled = true;
            //txtBuscarObraClienteNome.Enabled = true;
            //btnBuscarObra.Enabled = true;
            btnAlterar.Enabled = true;

            btnInserir.Enabled = true;

            dgvEtapasDisponiveis.Enabled = true;
            dgvTarefasDisponiveis.Enabled = true;
            dgvTarefasSelecionadas.Enabled = true;
        }

        private void modoInserirAlterarFinalizado() {
            btnBuscarCliente.Enabled = false;
            btnBuscarEngenheiro.Enabled = false;

            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtComplemento.Enabled = false;
            txtCEP.Enabled = false;
            cbbCidade.Enabled = false;
            cbbEstado.Enabled = false;
            txtDescricaoObra.Enabled = false;

            txtValor.Enabled = false;
            dtpDataInicio.Enabled = false;
            dtpDataPrevTermino.Enabled = false;
            txtBuscarEtapa.Enabled = false;
            btnBuscarEtapa.Enabled = false;


            btnInserirTarefa.Enabled = false;
            btnRemoverTarefa.Enabled = false;

            //txtBuscarObraEndereco.Enabled = false;
            //txtBuscarObraClienteNome.Enabled = false;
            //btnBuscarObra.Enabled = false;
            btnAlterar.Enabled = false;

            btnInserir.Enabled = false;

            dgvEtapasDisponiveis.Enabled = false;
            dgvTarefasDisponiveis.Enabled = false;
            dgvTarefasSelecionadas.Enabled = false;
        }


        private void carregarDadosIniciais()
        {
            this.obraTela = null;
            this.clienteSelecionado = null;
            this.funcionarioSelecionado = null;

            this.tarefasSelecionadas.Clear();
            this.dgvTarefasSelecionadas.DataSource = null;
            this.dgvTarefasSelecionadas.DataSource = tarefasSelecionadas;

            List<object> etapaList = obrasController.getTodasEtapas();
            configurarGridEtapasDisponiveis(etapaList);

            if (etapasDisponiveis.Count > 0)
            {
                int codEtapa = ((Model.Etapa)etapasDisponiveis[0]).getCod();
                var tarefas = obrasController.obterTodasTarefas(codEtapa);
                configurarGridTarefasDisponiveis(tarefas);
            }


            var estadosList = estadoController.obterTodos();
            if(estadosList.Count > 0)
            {
                estados = new BindingList<object>(estadosList);
                cbbEstado.DataSource = estados;

        
            }

            var statusList = obrasController.obterStatus();
            if(statusList != null)
            {
                status = new BindingList<object>(statusList);
                cbbStatus.DataSource = status;
            }

            var obras = new List<object>(obrasController.obterTodas());
            if(obras != null)
            {
                configurarGridObras(obras);
            }


         }

        private void configurarGridObras(List<object> obras = null)
        {
            if(obras == null)
            {
                obras = new List<object>(obrasController.obterTodas());
            }

            this.obras = null;
            this.obras = new BindingList<object>(obras);

            //configurar colunas depois

            this.dgvObras.DataSource = null;
            this.dgvObras.DataSource = this.obras;

            if (this.obras.Count > 0)
            {
                dgvEtapasDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvObras.Columns["Cod"].Visible = false;
                dgvObras.Columns["Descricao"].Visible = false;


                dgvObras.Columns["Cliente"].HeaderText = "Cliente";
                dgvObras.Columns["Cliente"].DisplayIndex = 1;
                dgvObras.Columns["Cliente"].ReadOnly = true;


                dgvObras.Columns["Funcionario"].HeaderText = "Funcionário";
                dgvObras.Columns["Funcionario"].DisplayIndex = 2;
                dgvObras.Columns["Funcionario"].ReadOnly = true;


                dgvObras.Columns["Endereco"].HeaderText = "Endereço";
                dgvObras.Columns["Endereco"].DisplayIndex = 3;
                dgvObras.Columns["Endereco"].ReadOnly = true;
                dgvObras.Columns["Endereco"].ReadOnly = true;

                dgvObras.Columns["Valor"].HeaderText = "Valor";
                dgvObras.Columns["Valor"].DisplayIndex = 4;
                dgvObras.Columns["Valor"].ReadOnly = true;

                dgvObras.Columns["Status"].HeaderText = "Status da obra";
                dgvObras.Columns["Status"].DisplayIndex = 5;
                dgvObras.Columns["Status"].ReadOnly = true;


                dgvObras.Columns["DtInicio"].HeaderText = "Data de início";
                dgvObras.Columns["DtInicio"].DisplayIndex = 6;
                dgvObras.Columns["DtInicio"].ReadOnly = true;


                dgvObras.Columns["DtPrevFim"].HeaderText = "Data Previsto fim";
                dgvObras.Columns["DtPrevFim"].DisplayIndex = 7;
                dgvObras.Columns["DtPrevFim"].ReadOnly = true;

            }

        }

        private void configurarGridEtapasDisponiveis(List<object> etapas)
        {
            this.etapasDisponiveis = new BindingList<object>(etapas);

            //configurar colunas depois

            this.dgvEtapasDisponiveis.DataSource = null;
            this.dgvEtapasDisponiveis.DataSource = this.etapasDisponiveis;

            if(this.etapasDisponiveis.Count > 0)
            {
                dgvEtapasDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvEtapasDisponiveis.Columns["Cod"].Visible = false;
            }
        }


        private void configurarGridTarefasDisponiveis(List<object> tarefas)
        {
            this.tarefasDisponiveis = new BindingList<object>(tarefas);

            //configurar colunas depois

            this.dgvTarefasDisponiveis.DataSource = null;
            this.dgvTarefasDisponiveis.DataSource = this.tarefasDisponiveis;

            if (this.tarefasDisponiveis.Count > 0)
            {
                dgvTarefasDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvTarefasDisponiveis.Columns["Cod"].Visible = false;

                dgvTarefasDisponiveis.Columns["Etapa"].Visible = false;

                dgvTarefasDisponiveis.Columns["Descricao"].HeaderText = "Descrição";
                dgvTarefasDisponiveis.Columns["Descricao"].DisplayIndex = 1;
                dgvTarefasDisponiveis.Columns["Descricao"].ReadOnly = true;

            }
        }


        private void configurarGridTarefasSelecionadas(List<object> tarefas)
        {
            this.tarefasSelecionadas = new BindingList<object>(tarefas);

            //configurar colunas depois

            this.dgvTarefasSelecionadas.DataSource = this.tarefasSelecionadas;

            if(tarefasSelecionadas.Count > 0)
            {
                dgvTarefasSelecionadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvTarefasSelecionadas.Columns["Cod"].Visible = false;

                dgvTarefasSelecionadas.Columns["Etapa"].Visible = true;
                dgvTarefasSelecionadas.Columns["Etapa"].HeaderText = "Etapa";
                dgvTarefasSelecionadas.Columns["Etapa"].DisplayIndex = 1;
                dgvTarefasSelecionadas.Columns["Etapa"].ReadOnly = true;

                dgvTarefasSelecionadas.Columns["Descricao"].HeaderText = "Tarefa";
                dgvTarefasSelecionadas.Columns["Descricao"].DisplayIndex = 2;
                dgvTarefasSelecionadas.Columns["Descricao"].ReadOnly = true;
            }
        }

        private void configurarCcbCidade(List<object> cidades)
        {
            this.cidades = null;
            this.cidades = new BindingList<object>(cidades);

            this.cbbCidade.DataSource = cidades;
        }

        public void setarClienteTela(object obj)
        {

            if (obj != null)
            {
                this.clienteSelecionado = (Model.Cliente)obj;
                objCliente.Text = clienteSelecionado.ToString();
            }
        }

        public void setarFuncionarioTela(object obj)
        {

            if (obj != null)
            {
                this.funcionarioSelecionado = (Model.Funcionario)obj;
                objFuncionario.Text = funcionarioSelecionado.ToString();
            }
        }

        private void onClickBuscarCliente(object sender, EventArgs e)
        {
            var buscarClienteView = new View.BuscarCliente(this);
            buscarClienteView.Show();
        }

        private void onClickBuscarResponsavel(object sender, EventArgs e)
        {
            var buscarFuncionarioView = new View.BuscarFuncionario(this);
            buscarFuncionarioView.Show();
        }

        private void OnClickEtapaDisponiveisGrid(object sender, DataGridViewCellMouseEventArgs e)
        {
            object etapaSelected = dgvEtapasDisponiveis.CurrentRow?.DataBoundItem;
            if (etapaSelected != null)
            {
                List<object> tarefasDisponiveis = obrasController.obterTodasTarefas(((Model.Etapa)etapaSelected).getCod());
                configurarGridTarefasDisponiveis(tarefasDisponiveis);
            }
        }

        public bool containsTarefa(BindingList<object> list, object obj)
        {
            foreach(var o in list)
            {
                if ( ((Model.Tarefa)o).getCod() == ((Model.Tarefa)obj).getCod())
                    return true;
            }

            return false;
        }

        private void InserirTarefaGridTarefaSelecionada(object sender, EventArgs e)
        {
            var tarefaSelecionada = dgvTarefasDisponiveis.CurrentRow?.DataBoundItem;
            if (tarefaSelecionada != null)
            {
                if(this.tarefasDisponiveis != null && this.tarefasSelecionadas != null && 
                    !this.containsTarefa(this.tarefasSelecionadas, tarefaSelecionada))
                {
                    if(tarefasSelecionadas.Count == 0)
                    {
                        tarefasSelecionadas = new BindingList<object>();
                    }

                    tarefasSelecionadas.Add(tarefaSelecionada);
                    configurarGridTarefasSelecionadas(new List<object>(tarefasSelecionadas));
                }
                else if(this.tarefasDisponiveis == null || this.tarefasDisponiveis.Count == 0)
                {
                    MessageBox.Show("Nenhuma tarefa selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tarefa já foi selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RemoverTarefaGridTarefaSelecionada(object sender, EventArgs e)
        {
            var tarefaSelecionada = dgvTarefasSelecionadas.CurrentRow?.DataBoundItem;
            if (tarefaSelecionada != null)
            {
                tarefasSelecionadas.Remove(tarefaSelecionada);
                
                if (tarefasSelecionadas.Count == 0)
                {
                    tarefasSelecionadas = new BindingList<object>();
                }

                configurarGridTarefasSelecionadas(new List<object>(tarefasSelecionadas));
            }
        }

        private void OnClickInserirObra(object sender, EventArgs e)
        {
            List<string> msgs = null;
            bool operacao = false;

            List<object> tarefasObjs = new List<object>(this.tarefasSelecionadas);

            this.obraTela = getObraTela();

            if(this.obraTela != null)
            {
                (msgs, operacao) = obrasController.inserir(this.obraTela, tarefasObjs);
            }


            if (msgs != null && msgs.Count > 0)
            {
                if(operacao)
                {
                    MessageBox.Show("Operação realizada com sucesso!!", "Sucesso", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    initTela();
                }
                else
                {
                    showMsgs(msgs);
                }
            }
            
        }

        

        private void showMsgs(List<string> msgs)
        {
            string msgsConcatenada = "";

            if (msgs != null)
            {
                foreach (var msg in msgs)
                {
                    msgsConcatenada += msg + "\n";
                }
            }


            MessageBox.Show(msgsConcatenada);
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var estado = cbbEstado.SelectedItem;

            if (estado != null)
            {
                this.configurarCcbCidade(
                    new List<object>(cidadeController.obterTodos( ((Model.Estado)estado).getUf() ))
                );
            }
        }

        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            this.initTela();
        }

        private void dgvObras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.obraTela = null;
            this.setarFuncionarioTela(null);
            this.setarClienteTela(null);

            dtpDataFim.Hide();
            btnCancelar.Show();
            btnAlterar.Hide();


        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.configurarGridObras();
        }

        private Model.Obra getObraTela()
        {
            if (obraTela == null)
                obraTela = new Model.Obra();

            Model.Endereco endereco = new Controller.FuncionarioController().GetEndereco(); ;

            Model.Cidade cidadeTela = null;
            Model.Status statusTela = new Controller.FuncionarioController().GetStatus();

            obraTela.setFuncionario(this.funcionarioSelecionado);
            obraTela.setCliente(this.clienteSelecionado);

            //cidade
            cidadeTela = (Model.Cidade)cbbCidade.SelectedItem;

            //endereco
            endereco.setCod(this.obraTela != null && obraTela.getEndereco() != null ? this.obraTela.getEndereco().getCod() : 0);
            endereco.setCep(txtCEP.Text.Replace("-", ""));

            endereco.setComplemento(txtComplemento.Text);
            endereco.setRua(txtRua.Text);

            try
            {
                endereco.setNumero(Convert.ToInt32(txtNumero.Text.Length > 0 ? txtNumero.Text : "0"));
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um número válido para o endereco");
                return null;
            }

            //check data prev termino
            DateTime datePrev = this.dtpDataPrevTermino.Value;
            DateTime dateInicio = this.dtpDataInicio.Value;

            int retornoData = DateTime.Compare(dateInicio, datePrev);
            if (retornoData >= 0)
            {
                MessageBox.Show("Data de previsão tem que ser maior que data de início.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            //----

            endereco.setBairro(txtBairro.Text);
            endereco.setCidade(cidadeTela);

            obraTela.setCliente(this.clienteSelecionado);
            obraTela.setFuncionario(this.funcionarioSelecionado);

            //status
            statusTela = (Model.Status) cbbStatus.SelectedItem;

            //datas
            obraTela.setDataInicio(dtpDataInicio.Value);
            obraTela.setDataPrevFim(dtpDataPrevTermino.Value);

            if (obraTela.getCod() != 0)
            {
                if(statusTela.getDescricao() == "Finalizado" && this.obraTela.getStatus().getDescricao() != "Finalizado")
                {
                    obraTela.setDataFim(DateTime.Now);
                }
                else if (this.obraTela.getStatus().getDescricao() == "Finalizado" && statusTela.getDescricao() == "Finalizado")
                {
                    obraTela.setDataFim(dtpDataFim.Value);
                }
                else if(this.obraTela.getStatus().getDescricao() == "Finalizado")
                {
                    obraTela.setDataFim(null);
                }
            }
            else if (obraTela.getCod() == 0)
            {
                obraTela.setDataFim(null);
            }

            //valor
            //decimal valorTotal = 0;
            //string[] valores = txtValor.Text.Trim().Split('.');

            //for(int i=0; i < valores.Length-1; i++)
            //{
            //    valorTotal += Convert.ToDecimal(valores[i]);
            //}
            //valorTotal += Convert.ToDecimal(valores[valores.Length - 2]);

            if(!formatarValorDecimal(obraTela, txtValor.Text))
            {
                return null;
            }

            //descricao
            obraTela.setDescricao(txtDescricaoObra.Text);

            obraTela.setEndereco(endereco);
            obraTela.setStatus(statusTela);

            return obraTela;
        }

        private bool formatarValorDecimal(Model.Obra obraTela, string valor)
        {
            if (valor.Length == 0)
            {
                MessageBox.Show("É necessário um valor para a obra!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {

                if(valor.IndexOf(',') > -1)
                {
                    string valorFormatado = valor;
                    
                    string[] valorVirgula = valorFormatado.Split(',');
                    if (valorVirgula.Length > 0 && valorVirgula[1].Length > 0)
                    {
                        valorFormatado = valorVirgula[0];
                        valorFormatado += ',';

                        string valorDecimal = valorVirgula[1];
                        if (valorDecimal.Length > 2)
                        {
                            valorFormatado += valorDecimal.Substring(0, 2);
                        }
                        else
                        {
                            valorFormatado += valorDecimal;
                        }
                    }
                    else
                    {
                        valorFormatado = valor.Replace(",", "");
                    }
                    obraTela.setValor(Convert.ToDecimal(valorFormatado));
                }
                else
                {
                    obraTela.setValor(Convert.ToDecimal(valor));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor da obra so aceita números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void carregaLinhaTela()
        {
            //cliente
            this.clienteSelecionado = this.obraTela.getCliente();
            objCliente.Text = this.clienteSelecionado.ToString();

            //funcionario
            this.funcionarioSelecionado = this.obraTela.getFuncionario();
            objFuncionario.Text = this.funcionarioSelecionado.ToString();



            //enderecos
            txtCEP.Text = this.obraTela.getEndereco().getCep();
            txtComplemento.Text = this.obraTela.getEndereco().getComplemento();
            txtRua.Text = this.obraTela.getEndereco().getRua();
            txtNumero.Text = this.obraTela.getEndereco().getNumero().ToString();
            txtBairro.Text = this.obraTela.getEndereco().getBairro();
            
            //valor
            txtValor.Text = this.obraTela.getValor().ToString("N2");

            //estado
            //cidade
            if (this.obraTela.getEndereco().getCidade().getEstado() != null)
            {
                cbbEstado.SelectedItem = this.obraTela.getEndereco().getCidade().getEstado();
            }
            if (this.obraTela.getEndereco().getCidade() != null)
            {
                cbbCidade.SelectedItem = this.obraTela.getEndereco().getCidade();

            }

            //datadas
            dtpDataFim.Value = this.obraTela.getDataFim() == null ? 
                Convert.ToDateTime(DateTime.Now) :
                Convert.ToDateTime(this.obraTela.getDataFim());

            dtpDataInicio.Value = Convert.ToDateTime(this.obraTela.getDataInicio());
            dtpDataPrevTermino.Value = Convert.ToDateTime(this.obraTela.getDataPrevFim());

            //status
            Model.Status statusSelecionado = this.obraTela.getStatus();

            int index = this.status.ToList().IndexOf(statusSelecionado);
            cbbStatus.SelectedIndex = index;

            //cbbStatus.SelectedItem = statusSelecionado;
            //cbbStatus.SelectedItem = this.obraTela.getStatus();

            //descricao
            txtDescricaoObra.Text = this.obraTela.getDescricao();

        }

        private void modoEditar()
        {

            btnInserir.Hide();
            btnAlterar.Show();
            btnCancelar.Show();
            lblStatus.Show();
            cbbStatus.Show();

            if (this.obraTela != null)
            {
                if(this.obraTela.getStatus().getDescricao() == "Finalizado")
                {
                    cbbStatus.Enabled = false;
                    dtpDataPrevTermino.Enabled = false;

                    btnInserirTarefa.Enabled = false;
                    btnRemoverTarefa.Enabled = false;

                    //remover coisas
               
                    modoInserirAlterarFinalizado();

                }
                else
                {
                    btnInserirTarefa.Enabled = true;
                    btnRemoverTarefa.Enabled = true;

                    cbbStatus.Enabled = true;
                    dtpDataPrevTermino.Enabled = true;

                    //alterar não finalizado
                    modoInserirAlterarNaoFinalizado();
                }

                List<object> tarefasSelecionadas = obrasController.obterTodasTarefasPorObra(this.obraTela.getCod());
                configurarGridTarefasSelecionadas(tarefasSelecionadas);
            }
        }

        private void dgvObras_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //jogar linha na tela

            var obraSelected = (Model.Obra) dgvObras.CurrentRow?.DataBoundItem;

            if(obraSelected != null)
            {
                this.obraTela = obraSelected;

                carregaLinhaTela();

                modoEditar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.OnClickInserirObra(sender, e);
        }

        private void btnOnLickBuscarEtapa(object sender, EventArgs e)
        {
            string etapa = txtBuscarEtapa.Text;
            if (etapa.Length == 0)
            {
                etapa = null;
            }

            List<object> etapaList = obrasController.getTodasEtapas(etapa);
            configurarGridEtapasDisponiveis(etapaList);

            if (etapasDisponiveis.Count > 0)
            {
                int codEtapa = ((Model.Etapa)etapasDisponiveis[0]).getCod();
                var tarefas = obrasController.obterTodasTarefas(codEtapa);
                configurarGridTarefasDisponiveis(tarefas);
            }
        }

        private void btnBuscarObra_Click(object sender, EventArgs e)
        {
            string nomeRua = txtBuscarObraEndereco.Text;
            string nomeCliente = txtBuscarObraClienteNome.Text;

            if(nomeRua.Length == 0)
            {
                nomeRua = null;
            }


            if (nomeCliente.Length == 0)
            {
                nomeCliente = null;
            }


            var obras = new List<object>(obrasController.obterTodas(nomeRua, nomeCliente));
            if (obras != null)
            {
                configurarGridObras(obras);
            }
        }
    }
}

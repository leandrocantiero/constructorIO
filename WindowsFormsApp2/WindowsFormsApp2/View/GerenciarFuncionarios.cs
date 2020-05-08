using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    public partial class GerenciarFuncionarios : MaterialSkin.Controls.MaterialForm
    {
        private Model.Funcionario funcTela;

        private BindingList<object> funcList;
        private BindingList<object> estadoList;
        private BindingList<object> cidadeList;
        private BindingList<object> cargoList;

        public GerenciarFuncionarios()
        {
            InitializeComponent();
          
            //apos a tela tiver renderizada, ele carrega esses 
            this.Load += new EventHandler(LoadAfterInitWindow);
        }

        private void LoadAfterInitWindow(System.Object sender, System.EventArgs e)
        {
            //inicia apos a tela tiver carregada.
            initTela();
        }

        public void configurarGridFuncionario(BindingList<object> funcionarios = null)
        {

            //ajustar o tamanho correto das colunas
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvFuncionarios.Columns["Cod"].Visible = false;

            dgvFuncionarios.Columns["Nome"].HeaderText = "Nome Completo";
            dgvFuncionarios.Columns["Nome"].DisplayIndex = 1;
            dgvFuncionarios.Columns["Nome"].ReadOnly = true;

            dgvFuncionarios.Columns["Registro"].HeaderText = "Registro (CAU/CREA)";
            dgvFuncionarios.Columns["Registro"].DisplayIndex = 2;
            dgvFuncionarios.Columns["Registro"].ReadOnly = true;

            dgvFuncionarios.Columns["Cpf"].HeaderText = "CPF";
            dgvFuncionarios.Columns["Cpf"].DisplayIndex = 3;
            dgvFuncionarios.Columns["Cpf"].ReadOnly = true;

            dgvFuncionarios.Columns["Rg"].HeaderText = "RG";
            dgvFuncionarios.Columns["Rg"].DisplayIndex = 4;
            dgvFuncionarios.Columns["Rg"].ReadOnly = true;

            dgvFuncionarios.Columns["Cargo"].HeaderText = "Cargo";
            dgvFuncionarios.Columns["Cargo"].DisplayIndex = 5;
            dgvFuncionarios.Columns["Cargo"].ReadOnly = true;

            dgvFuncionarios.Columns["Contatos"].HeaderText = "Celular/Telefone Fix";
            dgvFuncionarios.Columns["Contatos"].DisplayIndex = 6;
            dgvFuncionarios.Columns["Contatos"].ReadOnly = true;

            dgvFuncionarios.Columns["Endereco"].HeaderText = "Endereco Completo";
            dgvFuncionarios.Columns["Endereco"].DisplayIndex = 7;
            dgvFuncionarios.Columns["Endereco"].ReadOnly = true;

            dgvFuncionarios.Columns["DtNascimento"].HeaderText = "Data de Nascimento";
            dgvFuncionarios.Columns["DtNascimento"].DisplayIndex = 8;
            dgvFuncionarios.Columns["DtNascimento"].ReadOnly = true;

            dgvFuncionarios.Columns["ControleAcesso"].HeaderText = "Login";
            dgvFuncionarios.Columns["ControleAcesso"].DisplayIndex = 9;
            dgvFuncionarios.Columns["ControleAcesso"].ReadOnly = true;

            dgvFuncionarios.Columns["DtAdmissao"].HeaderText = "Data de Admissao";
            dgvFuncionarios.Columns["DtAdmissao"].DisplayIndex = 10;
            dgvFuncionarios.Columns["DtAdmissao"].ReadOnly = true;

            dgvFuncionarios.Columns["DtDemissao"].HeaderText = "Data de Demissao";
            dgvFuncionarios.Columns["DtDemissao"].DisplayIndex = 11;
            dgvFuncionarios.Columns["DtDemissao"].ReadOnly = true;


            if (funcionarios == null)
            {
                dgvFuncionarios.DataSource = this.funcList;
            }
            else 
            {
                dgvFuncionarios.DataSource = funcionarios;
            }

        }

        private void initTela()
        {
            this.iniciarVariaveisGlobais();
            this.carregarCargosTela();
         
            if( !View.Principal.cadastrarPrimeiroAdm)
            {
                this.carregarFuncionarios();
                this.configurarGridFuncionario(this.funcList);
            }
            else
            {
                dgvFuncionarios.Hide();
            }
            this.carregarEstadosTela();

            if( View.Principal.cadastrarPrimeiroAdm)
            {
                rdNivel2.Hide();
                rdNivel1.Checked = true;

                btnCancel.Hide();
                btnEdit.Hide();
                btnRemove.Hide();

                BtnBuscar2.Hide();
                txtBuscarRegistro.Hide();
                txtBuscarNome.Hide();
                btnListar.Hide();
                btnCancel.Hide();

                txtBuscarNome.Hide();
                txtBuscarRegistro.Hide();

                btnCancel.Hide();
                btnListar.Hide();

                cbUserAtivo.Checked = true;
                cbUserAtivo.Hide();
            }
            //else if (View.Principal.cadastrarFuncionario)
            //{
            //    rdNivel1.Hide();
            //    rdNivel2.Checked = true;

            //    btnCancel.Hide();
            //    btnEdit.Hide();
            //    btnRemove.Hide();


            //    BtnBuscar2.Hide();
            //    txtBuscarRegistro.Hide();
            //    txtBuscarNome.Hide();
            //    btnListar.Hide();
            //    btnCancel.Hide();

            //    txtBuscarNome.Hide();
            //    txtBuscarRegistro.Hide();

            //    cbUserAtivo.Checked = true;
            //    cbUserAtivo.Hide();
            //}
            else
            {
                rdNivel2.Checked = true;
                btnCancel.Hide();
                btnEdit.Hide();
                btnRemove.Hide();
            }

            dtAdmissao.Enabled = false;
            dtDemissao.Enabled = false;
            dtDemissao.Hide();

            lblDtDemissao.Hide();
            cbDemitir.Hide();
            btnInsert.Show();
          

            //txtLogin.Enabled = true;
            //txtSenha.Enabled = true;

        }

        private void carregarFuncionarios(string nome = null, string registro = null)
        {
            Controller.FuncionarioController funController = new Controller.FuncionarioController();
            dgvFuncionarios.DataSource = null;
            funcList.Clear();

            List<object> funcionariosList = new List<object>(funController.obterTodos(nome, registro));

            if(funcionariosList != null)
            {
                foreach (var fun in funcionariosList)
                {
                    funcList.Add(fun);
                }
            }

            dgvFuncionarios.DataSource = funcList;
            configurarGridFuncionario();
        }



        private void iniciarVariaveisGlobais()
        {
            funcTela = null;
            funcList = new BindingList<object>();
        }

        private void carregarCargosTela()
        {
            this.cargoList = new BindingList<object>();

            Controller.FuncionarioController funcionarioController = new Controller.FuncionarioController();
            List<object> cargos = new List<object>(funcionarioController.obterTodosCargos());

            if(cargos != null && cargos.Count > 0)
            {
                foreach (var cargo in cargos)
                {
                    this.cargoList.Add(cargo);
                }

            }

            cbbCargo.DataSource = this.cargoList;
        }


        private void carregarEstadosTela()
        {
            cbbEstado.DataSource = null;
            this.estadoList = new BindingList<object>();

            Controller.EstadoController estadoController = new Controller.EstadoController();
            List<object> estados = new List<object>(estadoController.obterTodos());

            if (estados != null && estados.Count > 0)
            {
                foreach (var estado in estados)
                {
                    estadoList.Add(estado);
                }
            }

            cbbEstado.DataSource = this.estadoList;
        }

        private void carregarCidadeTela(string uf)
        {
            cbbCidade.DataSource = null;
            this.cidadeList = new BindingList<object>();

            Controller.CidadeController cidadeController = new Controller.CidadeController();
            List<object> cidades = new List<object>(cidadeController.obterTodos(uf));

            if(cidades != null)
            {
                foreach(var cidade in cidades)
                {
                    this.cidadeList.Add(cidade);
                }

            }

            cbbCidade.DataSource = this.cidadeList;
        }

        private void btnCadastrar(object sender, EventArgs e)
        {
            Controller.FuncionarioController funcController = new Controller.FuncionarioController();
            Model.Funcionario funNew = funcController.GetFuncionario();

            funNew = this.getFuncionarioTela();

            if(funNew != null)
            {
                List<string> msgs = null;
                bool operacao = false;

                (msgs, operacao) = funcController.cadastrar(funNew);

                if (!operacao)
                {
                    if(msgs.Count > 0)
                    {
                        showMsgs(msgs);
                    }
                    funNew = this.getFuncionarioTela();
                }
                else
                {
                    if (msgs.Count > 0)
                    {
                        showMsgs(msgs);
                    }

                    if(View.Principal.cadastrarPrimeiroAdm)
                    {
                        int qntdAdm = funcController.getQuantUserNivelUm();

                        if(qntdAdm > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso, realize o login.", "Bem vindo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            View.Principal.cadastrarPrimeiroAdm = false;

                        }
                    }
                    //else if(View.Principal.cadastrarFuncionario)
                    //{
                    //    MessageBox.Show("Cadastro realizado com sucesso, realize o login.", "Bem vindo",
                    //         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //    View.Principal.cadastrarFuncionario = false;


                    //}

                    this.limparTela();
                    this.initTela();
                }
            }
        }

        private void btnRemover(object sender, EventArgs e)
        {
            Controller.FuncionarioController funcController = new Controller.FuncionarioController();

            if(funcTela.getCod() == View.Principal.FUNCIONARIO_LOGADO.getCod())
            {
                MessageBox.Show("Você não pode se auto excluir quando estiver logado.", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //else if(funcTela.getControleAcesso().getNivelAcesso() == 1 && funcController.getQuantUserNivelUm() == 1)
            //{
            //    MessageBox.Show("Você não pode excluir o ultimo Usuário nível Master do sistema.", "Erro",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            else
            {
                if (funcTela != null && funcTela.getCod() != 0)
                {
                    //List<string> msgs = null;
                    bool operacao = false;
                    List<string> msgs = new List<string>();

                    //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        //Sua rotina de exclusão
                        //Confirmando exclusão para o usuário
                        (msgs, operacao) = funcController.remover(funcTela);

                        if (operacao)
                        {
                            MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.limparTela();
                            this.initTela();
                        }
                        else
                        {
                            if(msgs!= null && msgs.Count > 0)
                            {
                                showMsgs(msgs);
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível apagar o registro.", 
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Problema ao deletar, escolha corretamente um funcionário");
                }
            }
        }

        private void btnBuscar(object sender, EventArgs e)
        {
            Controller.FuncionarioController funController = new Controller.FuncionarioController();
            dgvFuncionarios.DataSource = null;
            funcList.Clear();

            if(txtBuscarNome.Text.Length == 0 &&
                txtBuscarRegistro.Text.Length == 0)
            {
                this.carregarFuncionarios();
                return;
            }

            btnInsert.Show();
            btnEdit.Hide();
            btnRemove.Hide();
            btnCancel.Hide();
            dtDemissao.Hide();
            dtDemissao.Hide();


            List<Model.Funcionario> funcionariosList = funController.obterTodos(
                txtBuscarNome.Text.Length > 0 ? txtBuscarNome.Text : null,
                txtBuscarRegistro.Text.Length > 0 ? txtBuscarRegistro.Text : null
            );

            if (funcionariosList != null)
            {
                foreach (Model.Funcionario fun in funcionariosList)
                {
                    funcList.Add(fun);
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário encontrado.");
            }

            dgvFuncionarios.DataSource = funcList;
            configurarGridFuncionario();
        }

        private Model.Funcionario getFuncionarioTela()
        {
            Controller.FuncionarioController funcionarioController = new Controller.FuncionarioController();

            Model.Endereco enderecoTela = funcionarioController.GetEndereco();
            Model.ControleAcesso ctrAccessTela = funcionarioController.GetControleAcesso();
            Model.Contato contatoTela = funcionarioController.GetContato();
            Model.Cargo cargoTela = null;
            Model.Cidade cidadeTela = null;

            Model.NumeroContato numeroContato1 = funcionarioController.GetNumeroContato();
            Model.NumeroContato numeroContato2 = funcionarioController.GetNumeroContato();


            if (funcTela == null) funcTela = funcionarioController.GetFuncionario();

            //cargo
            cargoTela = (Model.Cargo) cbbCargo.SelectedItem;
            
            //cidade
            cidadeTela = (Model.Cidade) cbbCidade.SelectedItem;

            //numeros de contato
            contatoTela.setCod(this.funcTela != null && funcTela.getContato() != null ? this.funcTela.getContato().getCod() : 0);
            numeroContato1.Ddd = txtDdd1.Text;
            numeroContato1.Numero = txtContato1.Text.Replace("-", "");
            contatoTela.setNumeroPadrao(numeroContato1);

            numeroContato2.Ddd = txtDdd2.Text;
            numeroContato2.Numero = txtContato2.Text.Replace("-", "");
            contatoTela.setNumeroAlt(numeroContato2);

            //endereco
            enderecoTela.setCod(this.funcTela != null && funcTela.getEndereco() != null ? this.funcTela.getEndereco().getCod() : 0);
            enderecoTela.setCep(txtCEP.Text.Replace("-",""));
          
            enderecoTela.setComplemento(txtComplemento.Text);
            enderecoTela.setRua(txtRua.Text);

            try
            {
                enderecoTela.setNumero(Convert.ToInt32(txtNumero.Text.Length > 0 ? txtNumero.Text : "0"));
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um número válido para o endereco");
                return null;
            }
            enderecoTela.setBairro(txtBairro.Text);
            enderecoTela.setCidade(cidadeTela);

            //nivel acesso
            ctrAccessTela.setCod(this.funcTela != null && funcTela.getControleAcesso() != null ? this.funcTela.getControleAcesso().getCod() : 0);
            ctrAccessTela.setLogin(txtLogin.Text);
            ctrAccessTela.setSenha(txtSenha.Text);
            ctrAccessTela.setUsuarioAtivo(cbUserAtivo.Checked);

            if(rdNivel1.Checked)
            {
                ctrAccessTela.setNivelAcesso(1);
            }
            else if(rdNivel2.Checked)
            {
                ctrAccessTela.setNivelAcesso(2);
            }

            //pessoa e funcionario
            funcTela.setNome(txtNome.Text);
            funcTela.setRegistro(txtRegistro.Text);
            funcTela.setRg(txtRg.Text.ToString().Replace("-", "").Replace(".", "").Replace(",", ""));
            funcTela.setCpf(txtCpf.Text.ToString().Replace("-", "").Replace(".", "").Replace(",", ""));
            funcTela.setDtNascimento(dtNascimento.Value.ToString().Length > 0 ? 
                dtNascimento.Value : Convert.ToDateTime("1992-12-24"));
            funcTela.setDtAdmissao(DateTime.Now);

            if (cbDemitir.Checked)
            {
                funcTela.setDtDemissao(DateTime.Now);
            }
            else
            {
                funcTela.setDtDemissao(null);
            }

            //inserir os objetos no funcionario
            funcTela.setControleAcesso(ctrAccessTela);
            funcTela.setEndereco(enderecoTela);
            funcTela.setContato(contatoTela);
            funcTela.setCargo(cargoTela);
            funcTela.setCod(this.funcTela != null ? this.funcTela.getCod() : 0);


            return funcTela;
        }


        private void showMsgs(List<string> msgs)
        {
            string msgsConcatenada = "";

            if(msgs != null)
            {
                foreach(var msg in msgs)
                {
                    msgsConcatenada += msg + "\n";
                }
            }


            MessageBox.Show(msgsConcatenada);
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Estado estado = (Model.Estado) cbbEstado.SelectedItem;
            
            if(estado != null)
            {
                this.carregarCidadeTela(estado.getUf());
            }
        }

        private void dgvFuncionarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnInsert.Hide();
            btnEdit.Show();
            btnRemove.Show();
            btnCancel.Show();

            //txtLogin.Enabled = false;
            //txtSenha.Enabled = false;

            Model.Funcionario funSelected = (Model.Funcionario) dgvFuncionarios.CurrentRow?.DataBoundItem;
            funcTela = (Model.Funcionario) dgvFuncionarios.CurrentRow?.DataBoundItem;

            if (funSelected != null)
            {
                Controller.FuncionarioController funcController = new Controller.FuncionarioController();
                funcTela = funcController.obterUm(funSelected.getCod());

                carregarDadosTela();

                if(funcTela.getDtDemissao() != null)
                {
                    dtDemissao.Show();
                    lblDtDemissao.Show();
                    cbDemitir.Hide();
                }
                else
                {
                    dtDemissao.Hide();
                    lblDtDemissao.Hide();
                    cbDemitir.Show();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnInsert.Show();
            btnEdit.Hide();
            btnRemove.Hide();
            btnCancel.Hide();

            dtDemissao.Hide();
            lblDtDemissao.Hide();
            cbDemitir.Hide();

            dgvFuncionarios.ClearSelection();

            this.limparTela();
        }

        private void limparTela()
        {

            this.funcTela = null; 

            //limpa os contatos
            txtDdd1.Text = "";
            txtContato1.Text = "";
            txtDdd2.Text = "";
            txtContato2.Text = "";


            //limpa os comboxes
            this.cbbCargo.SelectedIndex = 0;
            this.cbbEstado.SelectedIndex = 0;
            this.cbbCidade.SelectedIndex = 0;
            cbDemitir.Checked = false;
            cbUserAtivo.Checked = true;

            //limpa endereco
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtRua.Text = ""; 
            txtNumero.Text = ""; 
            txtBairro.Text = "";


            // limpa controle acesso
            txtLogin.Text = "";
            txtSenha.Text = "";
            cbUserAtivo.Checked = false;
            rdNivel2.Checked = true;

            // limpa dados funcionario
            txtNome.Text = "";
            txtRegistro.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            dtNascimento.Value = Convert.ToDateTime(DateTime.Now);
            dtAdmissao.Value = Convert.ToDateTime(DateTime.Now);
            dtDemissao.Value = Convert.ToDateTime(DateTime.Now);


            funcTela = this.getFuncionarioTela();

        }

        private void carregarDadosTela()
        {
            //carrega os comboxes
            if (this.funcTela.getCargo() != null)
                cbbCargo.SelectedIndex = cargoList.IndexOf(this.funcTela.getCargo());


            //carrega os contatos
            if (this.funcTela.getContato() != null)
            {
                if (this.funcTela.getContato().getNumeroAlt() != null)
                {
                    txtDdd2.Text = this.funcTela.getContato().getNumeroAlt().getDdd();
                    txtContato2.Text = this.funcTela.getContato().getNumeroAlt().getNumero();
                }

                if (this.funcTela.getContato().getNumeroPadrao() != null)
                {
                    txtDdd1.Text = this.funcTela.getContato().getNumeroPadrao().getDdd();
                    txtContato1.Text = this.funcTela.getContato().getNumeroPadrao().getNumero();
                }
            }

            if (this.funcTela.getEndereco() != null)
            {
                //enderecos
                txtCEP.Text = this.funcTela.getEndereco().getCep();
                txtComplemento.Text = this.funcTela.getEndereco().getComplemento();
                txtRua.Text = this.funcTela.getEndereco().getRua();
                txtNumero.Text = this.funcTela.getEndereco().getNumero().ToString();
                txtBairro.Text = this.funcTela.getEndereco().getBairro();

                //carrega os comboxes
                
                if (this.funcTela.getEndereco().getCidade().getEstado() != null)
                {
                   
                    cbbEstado.SelectedItem = this.funcTela.getEndereco().getCidade().getEstado();
                
                }

                if (this.funcTela.getEndereco().getCidade() != null)
                {
                    
                    cbbCidade.SelectedItem = this.funcTela.getEndereco().getCidade();
                   

                }
            }

            if (this.funcTela.getControleAcesso() != null)
            {
                //controle acesso
                txtLogin.Text = this.funcTela.getControleAcesso().getLogin();
                txtSenha.Text = this.funcTela.getControleAcesso().getSenha();

                bool userAtivo = this.funcTela.getControleAcesso().getUsuarioAtivo();
                if (userAtivo)
                {
                    cbUserAtivo.Checked = true;
                }
                else
                {
                    cbUserAtivo.Checked = false;
                }

                int nivelAcesso = this.funcTela.getControleAcesso().getNivelAcesso();
                if (nivelAcesso == 1)
                {
                    rdNivel1.Checked = true;
                }
                else if (nivelAcesso == 2)
                {
                    rdNivel2.Checked = true;
                }
            }

            txtNome.Text = this.funcTela.getNome();
            txtRegistro.Text = this.funcTela.getRegistro();
            txtRg.Text = this.funcTela.getRg();
            txtCpf.Text = this.funcTela.getCpf();
            dtNascimento.Value = Convert.ToDateTime(this.funcTela.getDtNascimento());
            dtAdmissao.Value = Convert.ToDateTime(this.funcTela.getDtAdmissao());
            dtDemissao.Value = (this.funcTela.getDtDemissao() == null) ?
                Convert.ToDateTime("1992-12-24") :
                Convert.ToDateTime(this.funcTela.getDtDemissao());

        }

        private void btnEditar(object sender, EventArgs e)
        {
            Controller.FuncionarioController funcController = new Controller.FuncionarioController();
            Model.Funcionario funNew = null;

            funNew = this.getFuncionarioTela();

            if (funNew != null)
            {
                List<string> msgs = null;
                bool operacao = false;

                (msgs, operacao) = funcController.cadastrar(funNew);

                if (!operacao)
                {
                    if (msgs.Count > 0)
                    {
                        showMsgs(msgs);
                    }
                }
                else
                {
                    if (msgs.Count > 0)
                    {
                        showMsgs(msgs);
                    }
                    this.limparTela();
                    this.initTela();
                }
            }
        }

        
        private void limparTela(object sender, EventArgs e)
        {
            this.limparTela();
            this.initTela();
        }

        private void listarFuncionarios(object sender, EventArgs e)
        {
            txtBuscarNome.Text = "";
            txtBuscarRegistro.Text = "";
            this.configurarGridFuncionario();
            this.carregarFuncionarios();
        }

        private void txtContato2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

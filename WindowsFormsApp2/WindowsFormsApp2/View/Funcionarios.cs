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
    public partial class Funcionarios : MaterialSkin.Controls.MaterialForm
    {
        private Model.Funcionario funcTela;

        private BindingList<Model.Funcionario> funcList;
        private BindingList<Model.Estado> estadoList;
        private BindingList<Model.Cidade> cidadeList;
        private BindingList<Model.Cargo> cargoList;

        public Funcionarios()
        {
            InitializeComponent();
            initTela();
        }

        private void initTela()
        {
            this.iniciarVariaveisGlobais();
            this.carregarCargosTela();
            this.carregarFuncionarios();
            this.carregarEstadosTela();

            rdNivel2.Checked = true;
            dtAdmissao.Enabled = false;
            dtDemissao.Enabled = false;
            dtDemissao.Hide();
            lblDtDemissao.Hide();
            cbDemitir.Hide();
            btnInsert.Show();
            btnCancel.Hide();
            btnEdit.Hide();
            btnRemove.Hide();

            //txtLogin.Enabled = true;
            //txtSenha.Enabled = true;

        }

        private void carregarFuncionarios(string nome = null, string registro = null)
        {
            Controller.FuncionarioController funController = new Controller.FuncionarioController();
            dgvFuncionarios.DataSource = null;
            funcList.Clear();

            List<Model.Funcionario> funcionariosList = funController.obterTodos(nome, registro);

            if(funcionariosList != null)
            {
                foreach (Model.Funcionario fun in funcionariosList)
                {
                    funcList.Add(fun);
                }
            }

            //var source = new BindingSource(funcList, null);
            dgvFuncionarios.DataSource = funcList;
        }



        private void iniciarVariaveisGlobais()
        {
            funcTela = null;
            funcList = new BindingList<Model.Funcionario>();
        }

        private void carregarCargosTela()
        {
            this.cargoList = new BindingList<Model.Cargo>();

            Controller.FuncionarioController funcionarioController = new Controller.FuncionarioController();
            List<Model.Cargo> cargos = funcionarioController.obterTodosCargos();

            if(cargos != null && cargos.Count > 0)
            {
                foreach (Model.Cargo cargo in cargos)
                {
                    this.cargoList.Add(cargo);
                }

            }

            cbbCargo.DataSource = this.cargoList;
        }


        private void carregarEstadosTela()
        {
            cbbEstado.DataSource = null;
            this.estadoList = new BindingList<Model.Estado>();
      
            Controller.EstadoController estadoController = new Controller.EstadoController();
            List<Model.Estado> estados = estadoController.obterTodos();

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
            this.cidadeList = new BindingList<Model.Cidade>();

            Controller.CidadeController cidadeController = new Controller.CidadeController();
            List<Model.Cidade> cidades = cidadeController.obterTodos(uf);

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
            Model.Funcionario funNew = new Model.Funcionario();

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
                    this.limparTela();
                    this.initTela();
                }
            }
        }

        private void btnRemover(object sender, EventArgs e)
        {
            Controller.FuncionarioController funcController = new Controller.FuncionarioController();

            if (funcTela != null && funcTela.getCod() != 0)
            {
                //List<string> msgs = null;
                bool operacao = false;

                //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Sua rotina de exclusão
                    //Confirmando exclusão para o usuário
                    operacao = funcController.remover(funcTela.getCod());

                    if (operacao)
                    {
                        MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limparTela();
                        this.initTela();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível apagar o registro.", 
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }


            }
            else
            {
                MessageBox.Show("Problema ao deletar");
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

            //var source = new BindingSource(funcList, null);
            dgvFuncionarios.DataSource = funcList;
        }

        private Model.Funcionario getFuncionarioTela()
        {
            Model.Endereco enderecoTela = new Model.Endereco();
            Model.ControleAcesso ctrAccessTela = new Model.ControleAcesso();
            Model.Cargo cargoTela = null;
            Model.Cidade cidadeTela = null;
            Model.Contato contatoTela = new Model.Contato();

            if (funcTela == null) funcTela = new Model.Funcionario();

            //cargo
            cargoTela = (Model.Cargo) cbbCargo.SelectedItem;
            
            //cidade
            cidadeTela = (Model.Cidade) cbbCidade.SelectedItem;

            //numeros de contato
            contatoTela.setCod(this.funcTela != null && funcTela.getContato() != null ? this.funcTela.getContato().getCod() : 0);
            contatoTela.setNumeroPadrao(new Model.NumeroContato(txtDdd1.Text, txtContato1.Text));
            contatoTela.setNumeroAlt(new Model.NumeroContato(txtDdd2.Text, txtContato2.Text));

            //endereco
            enderecoTela.setCod(this.funcTela != null && funcTela.getEndereco() != null ? this.funcTela.getEndereco().getCod() : 0);
            enderecoTela.setCep(txtCEP.Text.ToString());
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
            funcTela.setDtNascimento(dtNascimento.Value.ToString().Length > 0 ? 
                dtNascimento.Value : Convert.ToDateTime("1992-12-24"));
            funcTela.setDtAdmissao(DateTime.Now);

            if (cbDemitir.Checked || funcTela.getDtDemissao() == null)
            {
                funcTela.setDtDemissao(DateTime.Now);
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

            Model.Funcionario funSelected = (Model.Funcionario)dgvFuncionarios.CurrentRow?.DataBoundItem;
            funcTela = (Model.Funcionario)dgvFuncionarios.CurrentRow?.DataBoundItem;

            if (funSelected != null)
            {
                Controller.FuncionarioController funcController = new Controller.FuncionarioController();
                funcTela = funcController.obterUm(funSelected.getCod());

                carregarDadosTela();

                if(funcTela.getDtDemissao() != null)
                {
                    dtDemissao.Show();
                    cbDemitir.Hide();
                }
                else
                {
                    dtDemissao.Hide();
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
            dtNascimento.Value = Convert.ToDateTime(DateTime.Now);
            dtAdmissao.Value = Convert.ToDateTime(DateTime.Now);
            dtDemissao.Value = Convert.ToDateTime(DateTime.Now);


            funcTela = this.getFuncionarioTela();

        }

        private void carregarDadosTela()
        {
            //carrega os comboxes
            cbbCargo.SelectedIndex = cargoList.IndexOf(this.funcTela.getCargo());
            cbbCidade.SelectedIndex = cidadeList.IndexOf(this.funcTela.getEndereco().getCidade());
            cbbEstado.SelectedIndex = estadoList.IndexOf(this.funcTela.getEndereco().getCidade().getEstado());

            //carrega os contatos
            txtDdd1.Text = this.funcTela.getContato().getNumeroPadrao().getDdd();
            txtContato1.Text = this.funcTela.getContato().getNumeroPadrao().getNumero();
            txtDdd2.Text = this.funcTela.getContato().getNumeroAlt().getDdd();
            txtContato2.Text = this.funcTela.getContato().getNumeroAlt().getDdd();

            //enderecos
            txtCEP.Text = this.funcTela.getEndereco().getCep();
            txtComplemento.Text = this.funcTela.getEndereco().getComplemento();
            txtRua.Text = this.funcTela.getEndereco().getRua();
            txtNumero.Text = this.funcTela.getEndereco().getNumero().ToString();
            txtBairro.Text = this.funcTela.getEndereco().getBairro();


            //controle acesso
            txtLogin.Text = this.funcTela.getControleAcesso().getLogin();
            txtSenha.Text = this.funcTela.getControleAcesso().getSenha();
            
            bool userAtivo = this.funcTela.getControleAcesso().getUsuarioAtivo();
            if(userAtivo)
            {
                cbUserAtivo.Checked = true;
            }
            else
            {
                cbUserAtivo.Checked = false;
            }

            int nivelAcesso = this.funcTela.getControleAcesso().getNivelAcesso();
            if(nivelAcesso == 1)
            {
                rdNivel1.Checked = true;
            }
            else if(nivelAcesso == 2)
            {
                rdNivel2.Checked = true;
            }

            txtNome.Text = this.funcTela.getNome();
            txtRegistro.Text = this.funcTela.getRegistro();
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
    }
}

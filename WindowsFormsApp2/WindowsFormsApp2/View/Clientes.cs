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
    public partial class Clientes : MaterialSkin.Controls.MaterialForm
    {

        private Model.Cliente cliTela;

        private BindingList<Model.Cliente> cliList;
        private BindingList<Model.Estado> estadoList;
        private BindingList<Model.Cidade> cidadeList;

        public Clientes()
        {
            InitializeComponent();
            initTela();
        }

        private void initTela()
        {
            this.iniciarVariaveisGlobais();
            this.carregarClientes();
            this.carregarEstadosTela();

            cbAtivo.Checked = true;
            btnSave.Show();
            btnRemove.Hide();
            btnCancel.Hide();

            txtCNPJ.Visible = false;
            txtCPF.Visible = true;

            txtCNPJBusca.Visible = false;
            txtCPFBusca.Visible = true;
        }

        private void iniciarVariaveisGlobais()
        {
            cliTela = null;
            cliList = new BindingList<Model.Cliente>();
        }

        private Model.Cliente getClienteTela()
        {
            Model.Endereco enderecoTela = new Model.Endereco();
            Model.Cidade cidadeTela = null;
            Model.Contato contatoTela = new Model.Contato();

            if (cliTela == null) cliTela = new Model.Cliente();

            //cidade
            cidadeTela = (Model.Cidade)cbbCidade.SelectedItem;

            //numeros de contato
            contatoTela.setCod(this.cliTela != null && cliTela.getContato() != null ? this.cliTela.getContato().getCod() : 0);
            contatoTela.setNumeroPadrao(new Model.NumeroContato(txtDdd1.Text, txtContato1.Text));
            contatoTela.setNumeroAlt(new Model.NumeroContato(txtDdd2.Text, txtContato2.Text));

            //endereco
            enderecoTela.setCod(this.cliTela != null && cliTela.getEndereco() != null ? this.cliTela.getEndereco().getCod() : 0);
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

            //pessoa e cliente
            cliTela.setNome(txtNome.Text);
            cliTela.setRegistro(txtCPF.Text != "   ,   ,   -" ? txtCPF.Text : txtCNPJ.Text);
            cliTela.setEmail(txtEmail.Text);
            cliTela.setAtivo(cbAtivo.Checked);
            cliTela.setDtNascimento(dtNascimento.Value.ToString().Length > 0 ?
                dtNascimento.Value : Convert.ToDateTime("1992-12-24"));

            //inserir os objetos no clinete
            cliTela.setEndereco(enderecoTela);
            cliTela.setContato(contatoTela);
            cliTela.setCod(this.cliTela != null ? this.cliTela.getCod() : 0);


            return cliTela;
        }


        private void carregarClientes(string nome = null, string registro = null)
        {
            Controller.ClienteController cliController = new Controller.ClienteController();
            dgvClientes.DataSource = null;
            cliList.Clear();

            List<Model.Cliente> ClientesList = cliController.obterTodos(nome, registro);

            if (ClientesList != null)
            {
                foreach (Model.Cliente cli in ClientesList)
                {
                    cliList.Add(cli);
                }
            }

            //var source = new BindingSource(cliList, null);
            dgvClientes.DataSource = cliList;
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

            if (cidades != null)
            {
                foreach (var cidade in cidades)
                {
                    this.cidadeList.Add(cidade);
                }

            }

            cbbCidade.DataSource = this.cidadeList;
        }

        private void limparTela()
        {

            this.cliTela = null;

            //limpa os contatos
            txtDdd1.Text = "";
            txtContato1.Text = "";
            txtDdd2.Text = "";
            txtContato2.Text = "";


            //limpa os comboxes
            this.cbbEstado.SelectedIndex = 0;
            this.cbbCidade.SelectedIndex = 0;

            //limpa endereco
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";


            // limpa dados cliente
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
            txtCNPJ.Text = "";
            txtNomeBusca.Text = "";
            txtCPFBusca.Text = "";
            txtCNPJBusca.Text = "";
            dtNascimento.Value = Convert.ToDateTime(DateTime.Now);


            //cliTela = this.getClienteTela();

        }

        private void carregarDadosTela()
        {
            //carrega os comboxes
            cbbCidade.SelectedIndex = cidadeList.IndexOf(this.cliTela.getEndereco().getCidade());
            cbbEstado.SelectedIndex = estadoList.IndexOf(this.cliTela.getEndereco().getCidade().getEstado());

            //carrega os contatos
            txtDdd1.Text = this.cliTela.getContato().getNumeroPadrao().getDdd();
            txtContato1.Text = this.cliTela.getContato().getNumeroPadrao().getNumero();
            txtDdd2.Text = this.cliTela.getContato().getNumeroAlt().getDdd();
            txtContato2.Text = this.cliTela.getContato().getNumeroAlt().getDdd();

            //enderecos
            txtCEP.Text = this.cliTela.getEndereco().getCep();
            txtComplemento.Text = this.cliTela.getEndereco().getComplemento();
            txtRua.Text = this.cliTela.getEndereco().getRua();
            txtNumero.Text = this.cliTela.getEndereco().getNumero().ToString();
            txtBairro.Text = this.cliTela.getEndereco().getBairro();


            txtCodigo.Text = this.cliTela.getCod().ToString();
            txtNome.Text = this.cliTela.getNome();
            if (this.cliTela.getRegistro().Length > 15)
            {
                txtCNPJ.Text = this.cliTela.getRegistro();
                rdCNPJ.Checked = true;
                txtCNPJ.Visible = true;
                txtCPF.Visible = false;
            }
            else
            {
                txtCPF.Text = this.cliTela.getRegistro();
                rdCPF.Checked = true;
                txtCNPJ.Visible = false;
                txtCPF.Visible = true;
            }
            txtEmail.Text = this.cliTela.getEmail();
            cbAtivo.Checked = this.cliTela.getAtivo();
            dtNascimento.Value = Convert.ToDateTime(this.cliTela.getDtNascimento());
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Controller.ClienteController cliController = new Controller.ClienteController();

            if (cliTela != null && cliTela.getCod() != 0)
            {
                //List<string> msgs = null;
                bool operacao = false;

                //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Sua rotina de exclusão
                    //Confirmando exclusão para o usuário
                    operacao = cliController.remover(cliTela.getCod());

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.ClienteController cliController = new Controller.ClienteController();
            Model.Cliente cliNew = new Model.Cliente();

            cliNew = this.getClienteTela();

            if (cliNew != null)
            {
                List<string> msgs = null;
                bool operacao = false;

                (msgs, operacao) = cliController.cadastrar(cliNew);

                if (!operacao)
                {
                    if (msgs.Count > 0)
                    {
                        showMsgs(msgs);
                    }
                    cliNew = this.getClienteTela();
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

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnRemove.Show();
            btnCancel.Show();

            //txtLogin.Enabled = false;
            //txtSenha.Enabled = false;

            Model.Cliente clieSelected = (Model.Cliente)dgvClientes.CurrentRow?.DataBoundItem;
            cliTela = (Model.Cliente)dgvClientes.CurrentRow?.DataBoundItem;

            if (clieSelected != null)
            {
                Controller.ClienteController funcController = new Controller.ClienteController();
                cliTela = funcController.obterUm(clieSelected.getCod());

                carregarDadosTela();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnSave.Show();
            btnCancel.Hide();
            btnRemove.Hide();

            dgvClientes.ClearSelection();

            this.limparTela();
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Estado estado = (Model.Estado)cbbEstado.SelectedItem;

            if (estado != null)
            {
                this.carregarCidadeTela(estado.getUf());
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            string registro = txtCPFBusca.Text != "" ? txtCPFBusca.Text : txtCNPJBusca.Text;
            carregarClientes(txtNomeBusca.Text, registro);
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            txtCNPJ.Visible = true;
            txtCPF.Visible = false;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            txtCNPJ.Visible = false;
            txtCPF.Visible = true;
        }

        private void rdCNPJBusca_MouseClick(object sender, MouseEventArgs e)
        {
            txtCNPJBusca.Visible = true;
            txtCPFBusca.Visible = false;
        }

        private void rdCPFBusca_MouseClick(object sender, MouseEventArgs e)
        {
            txtCNPJBusca.Visible = false;
            txtCPFBusca.Visible = true;
        }
    }
}

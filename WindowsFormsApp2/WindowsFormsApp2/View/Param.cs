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
    public partial class Param : MaterialSkin.Controls.MaterialForm
    {
        Model.Param paramTela;

        private BindingList<Model.Estado> estadoList;
        private BindingList<Model.Cidade> cidadeList;

        public Param()
        {
            InitializeComponent();
            initTela();
        }

        private void limparTela()
        {
            this.paramTela = null;

            //limpa os contatos
            txtDdd1.Text = "";
            txtContato1.Text = "";
            txtDdd2.Text = "";
            txtContato2.Text = "";


            //limpa os comboboxes
            this.cbbEstado.SelectedIndex = 0;
            this.cbbCidade.SelectedIndex = 0;

            //limpa endereco
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";


            // limpa dados
            txtRazaoSocial.Text = "";
            txtFantasia.Text = "";
            txtCnpj.Text = "";
            txtInscEstadual.Text = "";
            pbLogoMenor.Text = "";
            pbLogoMenor.Text = "";
            txtEmail.Text = "";
            txtSite.Text = "";

            paramTela = this.getParamTela();

        }

        private void initTela()
        {
            paramTela = null;
            this.carregarEstadosTela();
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

        private Model.Param getParamTela()
        {
            Model.Endereco enderecoTela = new Model.Endereco();
            Model.Cidade cidadeTela = null;
            Model.Contato contatoTela = new Model.Contato();

            if (paramTela == null) paramTela = new Model.Param();

            //cidade
            cidadeTela = (Model.Cidade)cbbCidade.SelectedItem;

            //numeros de contato
            contatoTela.setCod(this.paramTela != null && paramTela.getContato() != null ? this.paramTela.getContato().getCod() : 0);
            contatoTela.setNumeroPadrao(new Model.NumeroContato(txtDdd1.Text, txtContato1.Text));
            contatoTela.setNumeroAlt(new Model.NumeroContato(txtDdd2.Text, txtContato2.Text));

            //endereco
            enderecoTela.setCod(this.paramTela != null && paramTela.getEndereco() != null ? this.paramTela.getEndereco().getCod() : 0);
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

            paramTela.setRazaoSocial(txtRazaoSocial.Text);
            paramTela.setFantasia(txtFantasia.Text);
            paramTela.setCnpj(txtCnpj.Text);
            paramTela.setInscEstadual(txtInscEstadual.Text);
            paramTela.setLogoMenor(pbLogoMenor.ImageLocation);
            paramTela.setLogoMaior(pbLogoMenor.ImageLocation);
            paramTela.setEmail(txtEmail.Text);
            paramTela.setSite(txtSite.Text);

            //inserir os objetos no clinete
            paramTela.setEndereco(enderecoTela);
            paramTela.setContato(contatoTela);


            return paramTela;
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
            Controller.ParamController pc = new Controller.ParamController();
            Model.Param newParam = new Model.Param();

            newParam = this.getParamTela();

            if (newParam != null)
            {
                List<string> msgs = null;
                bool operacao = false;

                (msgs, operacao) = pc.cadastrar(newParam);

                if (!operacao)
                {
                    if (msgs.Count > 0)
                    {
                        showMsgs(msgs);
                    }
                    newParam = this.getParamTela();
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar Foto";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                    // cria um PictureBox
                    try
                    {
                        Image Imagem = Image.FromFile(ofd1.FileName);
                        pbLogoMenor.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbLogoMenor.Image = Imagem;
                    }
                    catch (Exception)
                    {
                    }
            }
        }

        private void pbLogoMaior_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar Foto";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // cria um PictureBox
                try
                {
                    Image Imagem = Image.FromFile(ofd1.FileName);
                    pbLogoMaior.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbLogoMaior.Image = Imagem;
                }
                catch (Exception)
                {
                }
            }
        }

        private void cbbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Model.Estado estado = (Model.Estado)cbbEstado.SelectedItem;

            if (estado != null)
            {
                this.carregarCidadeTela(estado.getUf());
            }
        }
    }
}

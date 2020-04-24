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
    public partial class Principal : MaterialSkin.Controls.MaterialForm
    {
        public static Model.Funcionario FUNCIONARIO_LOGADO = null;

        public Principal()
        {
            InitializeComponent();
            controleDeAcessoButtons();
            setarNomeFuncionarioLogado();
        }


        private void setarNomeFuncionarioLogado()
        {
            string msgBemVindo = "Bem vindo(a)";

            if (Principal.FUNCIONARIO_LOGADO != null)
            {
                if (Principal.FUNCIONARIO_LOGADO.getNome() != null && Principal.FUNCIONARIO_LOGADO.getNome().Length > 0)
                {
                    msgBemVindo += " " + Principal.FUNCIONARIO_LOGADO.getNome();
                }
                else if (Principal.FUNCIONARIO_LOGADO.getControleAcesso() != null &&
                        Principal.FUNCIONARIO_LOGADO.getControleAcesso().getLogin().Length > 0)
                {
                    msgBemVindo += " " + Principal.FUNCIONARIO_LOGADO.getControleAcesso().getLogin();
                }
            }
            else
            {
                msgBemVindo += " Você está sem Login, favor entrar em contato com a TI";
            }

            msgBemVindo += ".";

            txtNomeUsuarioLogado.Text = msgBemVindo;
        }

        private void controleDeAcessoButtons()
        {
            int width = 173;
            int heigh = 35;
            string color = "#374670";
            string color2 = "#FFFFFF";

            Button btnIniciarObra = new MaterialSkin.Controls.MaterialFlatButton();
            btnIniciarObra.AutoSize = true;
            btnIniciarObra.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnIniciarObra.Text = "Iniciar Obra";
            btnIniciarObra.Size = new Size(width, heigh);
            btnIniciarObra.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnIniciarObra.Click += new System.EventHandler(this.onClickBtnIniciarObras);

            Button btnGerenciarFuncionarios = new MaterialSkin.Controls.MaterialFlatButton();
            btnGerenciarFuncionarios.AutoSize = true;
            btnGerenciarFuncionarios.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnGerenciarFuncionarios.Text = "Gerenciar Funcionários";
            btnGerenciarFuncionarios.Size = new Size(width, heigh);
            btnGerenciarFuncionarios.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnGerenciarFuncionarios.Click += new System.EventHandler(this.onClickBtnGerenciarFuncionarios);

            Button btnGerenciarClientes = new MaterialSkin.Controls.MaterialFlatButton();
            btnGerenciarClientes.AutoSize = true;
            btnGerenciarClientes.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnGerenciarClientes.Text = "Gerenciar Clientes";
            btnGerenciarClientes.Size = new Size(width, heigh);
            btnGerenciarClientes.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnGerenciarClientes.Click += new System.EventHandler(this.onClickBtnGerenciarClientes);

            Button btnGerenciarFornecedores = new MaterialSkin.Controls.MaterialFlatButton();
            btnGerenciarFornecedores.AutoSize = true;
            btnGerenciarFornecedores.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnGerenciarFornecedores.Text = "Gerenciar Fornecedores";
            btnGerenciarFornecedores.Size = new Size(width, heigh);
            btnGerenciarFornecedores.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnGerenciarFornecedores.Click += new System.EventHandler(this.onClickBtnGerenciarFornecedores);

            Button btnRealizarAgendamento = new MaterialSkin.Controls.MaterialFlatButton();
            btnRealizarAgendamento.AutoSize = true;
            btnRealizarAgendamento.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnRealizarAgendamento.Text = "Realizar Agendamento";
            btnRealizarAgendamento.Size = new Size(width, heigh);
            btnRealizarAgendamento.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnRealizarAgendamento.Click += new System.EventHandler(this.onClickBtnRealizarAgendamento);

            Button btnComprarMateriais = new MaterialSkin.Controls.MaterialFlatButton();
            btnComprarMateriais.AutoSize = true;
            btnComprarMateriais.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnComprarMateriais.Text = "Comprar Materiais";
            btnComprarMateriais.Size = new Size(width, heigh);
            btnComprarMateriais.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnComprarMateriais.Click += new System.EventHandler(this.onClickBtnComprarMateriais);

            Button btnLancarMedicoes = new MaterialSkin.Controls.MaterialFlatButton();
            btnLancarMedicoes.AutoSize = true;
            btnLancarMedicoes.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnLancarMedicoes.Text = "Lançar Medições";
            btnLancarMedicoes.Size = new Size(width, heigh);
            btnLancarMedicoes.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnLancarMedicoes.Click += new System.EventHandler(this.onClickBtnLancarMedicoes);

            Button btnLancarDespesas = new MaterialSkin.Controls.MaterialFlatButton();
            btnLancarDespesas.AutoSize = true;
            btnLancarDespesas.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnLancarDespesas.Text = "Lançar Despesas";
            btnLancarDespesas.Size = new Size(width, heigh);
            btnLancarDespesas.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnLancarDespesas.Click += new System.EventHandler(this.onClickBtnLancarDespesas);


            Button btnLancarHorasExtras = new MaterialSkin.Controls.MaterialFlatButton();
            btnLancarHorasExtras.AutoSize = true;
            btnLancarHorasExtras.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnLancarHorasExtras.Text = "Lançar Horas Extras";
            btnLancarHorasExtras.Size = new Size(width, heigh);
            btnLancarHorasExtras.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnLancarHorasExtras.Click += new System.EventHandler(this.onClickBtnLancarHorasExtras);


            Button btnQuitarDespesas = new MaterialSkin.Controls.MaterialFlatButton();
            btnQuitarDespesas.AutoSize = true;
            btnQuitarDespesas.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnQuitarDespesas.Text = "Quitar Despesas";
            btnQuitarDespesas.Size = new Size(width, heigh);
            btnQuitarDespesas.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnQuitarDespesas.Click += new System.EventHandler(this.onClickBtnQuitarDespesas);


            Button btnReceberMedicoes = new MaterialSkin.Controls.MaterialFlatButton();
            btnReceberMedicoes.AutoSize = true;
            btnReceberMedicoes.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnReceberMedicoes.Text = "Receber medições";
            btnReceberMedicoes.Size = new Size(width, heigh);
            btnReceberMedicoes.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnReceberMedicoes.Click += new System.EventHandler(this.onClickBtnReceberMedicoes);


            Button btnLancarMateriaisServicos = new MaterialSkin.Controls.MaterialFlatButton();
            btnLancarMateriaisServicos.AutoSize = true;
            btnLancarMateriaisServicos.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnLancarMateriaisServicos.Text = "Lançar materiais/serviços";
            btnLancarMateriaisServicos.Size = new Size(width, heigh);
            btnLancarMateriaisServicos.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnLancarMateriaisServicos.Click += new System.EventHandler(this.onClickBtnLancarMateriaisServiços);


            Button btnControlarEscalaTrabalho = new MaterialSkin.Controls.MaterialFlatButton();
            btnControlarEscalaTrabalho.AutoSize = true;
            btnControlarEscalaTrabalho.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnControlarEscalaTrabalho.Text = "Controlar escala de trabalho";
            btnControlarEscalaTrabalho.Size = new Size(width, heigh);
            btnControlarEscalaTrabalho.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnControlarEscalaTrabalho.Click += new System.EventHandler(this.onClickBtnControlarEscalaTrabalho);


            Button btnLancarPedidosMateriais = new MaterialSkin.Controls.MaterialFlatButton();
            btnLancarPedidosMateriais.AutoSize = true;
            btnLancarPedidosMateriais.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnLancarPedidosMateriais.Text = "Lançar pedidos de materias";
            btnLancarPedidosMateriais.Size = new Size(width, heigh);
            btnLancarPedidosMateriais.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnLancarPedidosMateriais.Click += new System.EventHandler(this.onClickBtnLancarPedidosMateriais);

            Button btnAgendarVisita = new MaterialSkin.Controls.MaterialFlatButton();
            btnAgendarVisita.AutoSize = true;
            btnAgendarVisita.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnAgendarVisita.Text = "Agendar visita";
            btnAgendarVisita.Size = new Size(width, heigh);
            btnAgendarVisita.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnAgendarVisita.Click += new System.EventHandler(this.onClickBtnAgendarVisita);

            Button btnGerenciarParametros = new MaterialSkin.Controls.MaterialFlatButton();
            btnGerenciarParametros.AutoSize = true;
            btnGerenciarParametros.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnGerenciarParametros.Text = "Configurações";
            btnGerenciarParametros.Size = new Size(width, heigh);
            btnGerenciarParametros.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnGerenciarParametros.Click += new System.EventHandler(this.onClickBtnGerenciarParametros);


            Button btnRelatorios = new MaterialSkin.Controls.MaterialFlatButton();
            btnRelatorios.AutoSize = true;
            btnRelatorios.ForeColor = System.Drawing.ColorTranslator.FromHtml(color2);
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.Size = new Size(width, heigh);
            btnRelatorios.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
            btnRelatorios.Click += new System.EventHandler(this.onClickBtnRelatorios);



            if (Principal.FUNCIONARIO_LOGADO != null && FUNCIONARIO_LOGADO.getControleAcesso() != null)
            {
                //RESTRITO PARA NIVEL 1
                if (Principal.FUNCIONARIO_LOGADO.getControleAcesso().getNivelAcesso() == 1)
                {

                    flpAsideLeft.Controls.Add(btnGerenciarFuncionarios);
                    flpAsideLeft.Controls.Add(btnGerenciarClientes);
                    flpAsideLeft.Controls.Add(btnGerenciarFornecedores);
                    flpAsideLeft.Controls.Add(btnIniciarObra);
                    flpAsideLeft.Controls.Add(btnLancarPedidosMateriais);
                    flpAsideLeft.Controls.Add(btnGerenciarParametros);

                }

                //NIVEL 2 PODE ACESSAR TODO O RESTO
                flpAsideLeft.Controls.Add(btnComprarMateriais);
                flpAsideLeft.Controls.Add(btnRealizarAgendamento);
                flpAsideLeft.Controls.Add(btnLancarMedicoes);
                flpAsideLeft.Controls.Add(btnLancarDespesas);
                flpAsideLeft.Controls.Add(btnLancarHorasExtras);
                flpAsideLeft.Controls.Add(btnQuitarDespesas);
                flpAsideLeft.Controls.Add(btnReceberMedicoes);
                flpAsideLeft.Controls.Add(btnLancarMateriaisServicos);
                flpAsideLeft.Controls.Add(btnControlarEscalaTrabalho);
                flpAsideLeft.Controls.Add(btnAgendarVisita);

                flpAsideLeft.AutoScroll = true;
            }
        }

        private void onClickBtnGerenciarParametros(object sender, EventArgs e)
        {
            Param param = new Param();
            param.Show();
        }

        private void onClickBtnRelatorios(object sender, EventArgs e)
        {
            //Relatorios form = new Relatorios();
            //form.Show();
        }

        private void onClickBtnAgendarVisita(object sender, EventArgs e)
        {
            AgendarVisita form = new AgendarVisita();
            form.Show();
        }

        private void onClickBtnLancarPedidosMateriais(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnControlarEscalaTrabalho(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnLancarMateriaisServiços(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnReceberMedicoes(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnQuitarDespesas(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnLancarHorasExtras(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnLancarDespesas(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnLancarMedicoes(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnComprarMateriais(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnRealizarAgendamento(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onClickBtnGerenciarFornecedores(object sender, EventArgs e)
        {
            GerenciarFornecedores form = new GerenciarFornecedores();
            form.Show();

        }

        private void onClickBtnGerenciarClientes(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void onClickBtnGerenciarFuncionarios(object sender, EventArgs e)
        {
            GerenciarFuncionarios form = new GerenciarFuncionarios();
            form.Show();
        }

        private void onClickBtnIniciarObras(object sender, EventArgs e)
        {
            IniciarObra form = new IniciarObra();
            form.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            View.AlterarSenha alterarSenha = new View.AlterarSenha();
            alterarSenha.Show();
        }


    }
}

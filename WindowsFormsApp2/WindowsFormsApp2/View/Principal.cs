using MaterialSkin;
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

        //public static bool cadastrarFuncionario = false;
        public static bool cadastrarPrimeiroAdm = false;

        public Principal()
        {
            InitializeComponent();
            controleDeAcessoButtons();
            setarNomeFuncionarioLogado();

           
        }


        private void setarNomeFuncionarioLogado()
        {
            string msgBemVindo;

            if (View.Principal.cadastrarPrimeiroAdm)
            {
                msgBemVindo = "Clique em GERENCIAR FUNCIONÁRIOS para realizar o cadastro.";
            }
            else
            {
                msgBemVindo = "Bem vindo(a)";

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

            }
            
            txtNomeUsuarioLogado.Text = msgBemVindo;
        }

        private void controleDeAcessoButtons()
        {
            int width = 244;
            int heigh = 35;
            string color = "#374659";
            string color2 = "#000000";

            Button btnIniciarObra = new Button();
            btnIniciarObra.Text = "Iniciar Obra";
            btnIniciarObra.Click += new System.EventHandler(this.onClickBtnIniciarObras);

            Button btnGerenciarFuncionarios = new Button();
            btnGerenciarFuncionarios.Text = "Gerenciar Funcionários";
            btnGerenciarFuncionarios.Click += new System.EventHandler(this.onClickBtnGerenciarFuncionarios);

            Button btnGerenciarClientes = new Button();
            btnGerenciarClientes.Text = "Gerenciar Clientes";
            btnGerenciarClientes.Click += new System.EventHandler(this.onClickBtnGerenciarClientes);

            Button btnGerenciarFornecedores = new Button();
            btnGerenciarFornecedores.Text = "Gerenciar Fornecedores";
            btnGerenciarFornecedores.Click += new System.EventHandler(this.onClickBtnGerenciarFornecedores);

            Button btnRealizarAgendamento = new Button();
            btnRealizarAgendamento.Text = "Realizar Agendamento";
            btnRealizarAgendamento.Click += new System.EventHandler(this.onClickBtnRealizarAgendamento);

            Button btnComprarMateriais = new Button();
            btnComprarMateriais.Text = "Comprar Materiais";
            btnComprarMateriais.Click += new System.EventHandler(this.onClickBtnComprarMateriais);

            Button btnLancarMedicoes = new Button();
            btnLancarMedicoes.Text = "Lançar Medições";
            btnLancarMedicoes.Click += new System.EventHandler(this.onClickBtnLancarMedicoes);

            Button btnLancarDespesas = new Button();
            btnLancarDespesas.Text = "Lançar Despesas";
            btnLancarDespesas.Click += new System.EventHandler(this.onClickBtnLancarDespesas);


            Button btnLancarHorasExtras = new Button();
            btnLancarHorasExtras.Text = "Lançar Horas Extras";
            btnLancarHorasExtras.Click += new System.EventHandler(this.onClickBtnLancarHorasExtras);


            Button btnQuitarDespesas = new Button();
            btnQuitarDespesas.Text = "Quitar Despesas";
            btnQuitarDespesas.Click += new System.EventHandler(this.onClickBtnQuitarDespesas);


            Button btnReceberMedicoes = new Button();
            btnReceberMedicoes.Text = "Receber medições";
            btnReceberMedicoes.Click += new System.EventHandler(this.onClickBtnReceberMedicoes);


            Button btnLancarMateriaisServicos = new Button();
            btnLancarMateriaisServicos.Text = "Lançar materiais/serviços";
            btnLancarMateriaisServicos.Click += new System.EventHandler(this.onClickBtnLancarMateriaisServiços);


            Button btnControlarEscalaTrabalho = new Button();
            btnControlarEscalaTrabalho.Text = "Controlar escala de trabalho";
            btnControlarEscalaTrabalho.Click += new System.EventHandler(this.onClickBtnControlarEscalaTrabalho);


            Button btnLancarPedidosMateriais = new Button();
            btnLancarPedidosMateriais.Text = "Lançar pedidos de materias";
            btnLancarPedidosMateriais.Click += new System.EventHandler(this.onClickBtnLancarPedidosMateriais);

            Button btnAgendarVisita = new Button();
            btnAgendarVisita.Text = "Agendar visita";
            btnAgendarVisita.Click += new System.EventHandler(this.onClickBtnAgendarVisita);

            Button btnGerenciarParametros = new Button();
            btnGerenciarParametros.Text = "Configurações";
            btnGerenciarParametros.Click += new System.EventHandler(this.onClickBtnGerenciarParametros);


            Button btnRelatorios = new Button();
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.Click += new System.EventHandler(this.onClickBtnRelatorios);

            

            if (Principal.FUNCIONARIO_LOGADO != null && FUNCIONARIO_LOGADO.getControleAcesso() != null)
            {
                if(Principal.cadastrarPrimeiroAdm)
                {
                    flpAsideLeft.Controls.Add(btnGerenciarFuncionarios);
                }
                else
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
            else if (Principal.cadastrarPrimeiroAdm)
            {
                flpAsideLeft.Controls.Add(btnGerenciarFuncionarios);
            }

            foreach(Button b in flpAsideLeft.Controls)
            {
                b.BackColor = System.Drawing.ColorTranslator.FromHtml(color);
                b.Font = new Font("Roboto", 9, FontStyle.Bold);
                b.Size = new Size(width, heigh);
                b.ForeColor = Color.White;
                b.AutoSize = true;
                b.TabStop = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

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
            //AgendarVisita form = new AgendarVisita();
            //form.Show();
        }

        private void onClickBtnLancarPedidosMateriais(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnControlarEscalaTrabalho(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnLancarMateriaisServiços(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnReceberMedicoes(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnQuitarDespesas(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnLancarHorasExtras(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnLancarDespesas(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnLancarMedicoes(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnComprarMateriais(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnRealizarAgendamento(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void onClickBtnGerenciarFornecedores(object sender, EventArgs e)
        {
            //GerenciarFornecedores form = new GerenciarFornecedores();
            //form.Show();

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            View.Principal.FUNCIONARIO_LOGADO = null;
            //View.Principal.cadastrarFuncionario = false;
            View.Principal.cadastrarPrimeiroAdm = false;

            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}

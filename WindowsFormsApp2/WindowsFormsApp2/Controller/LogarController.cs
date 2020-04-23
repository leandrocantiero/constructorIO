using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Controller
{
    public class LogarController
    {
        public Model.Funcionario logar(Model.ControleAcesso ctrAccess)
        {
            List<string> msgs = new List<string>();
            //Model.ControleAcesso ctrAccessResp = null;
            Model.Funcionario funcLogado = null;
            bool operacao = true;

            if(ctrAccess.getLogin() == null ||
                ctrAccess.getLogin().Length == 0 ||
                ctrAccess.getLogin().Length < 3 ||
                ctrAccess.getLogin().Length > 30)
            {
                MessageBox.Show("Login deve ser maior que 2 caracteres e menor que 30.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                operacao = false;
            }

            if (ctrAccess.getSenha() == null ||
                ctrAccess.getSenha().Length == 0 ||
                ctrAccess.getSenha().Length < 4 ||
                ctrAccess.getLogin().Length > 30)
            {
                MessageBox.Show("Senha deve ser maior que 3 caracteres e menor que 30.", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                operacao = false;
            }

            if (operacao)
            {
                DatabaseAbstractionLayer.FuncionarioDAL funcionarioDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
                funcLogado = funcionarioDAL.obterUmPorEmailSenha(ctrAccess.getLogin(), ctrAccess.getSenha());

                if (funcLogado != null)
                {
                    if (funcLogado.getControleAcesso().getLogin() != ctrAccess.getLogin() ||
                        funcLogado.getControleAcesso().getSenha() != ctrAccess.getSenha())
                    {
                        MessageBox.Show("Login ou senha incorretos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funcLogado = null;
                    }

                    if (funcLogado.getControleAcesso().getNivelAcesso() > 1)
                    {
                        MessageBox.Show("Você não tem nível suficiente para se logar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funcLogado = null;

                    }

                    if (funcLogado.getControleAcesso().getUsuarioAtivo() == false)
                    {
                        MessageBox.Show("Seu usuário não está ativo para realizar o login.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funcLogado = null;

                    }

                    if (funcLogado.getDtDemissao() != null)
                    {
                        MessageBox.Show("Você foi demitido, não será possível realizar o login.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funcLogado = null;

                    }
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                //tem q verificar se login e senha sao iguais...
            }

            return funcLogado;
        }

        public Model.Funcionario trocarSenha(string senhaAtual, string senhaNova, Model.Funcionario funcionario)
        {
            
            if(senhaAtual != funcionario.getControleAcesso().getSenha())
            {
                MessageBox.Show("Senha atual digitada é diferente da atual cadastrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcionario = null;
            }
            else
            {
                if (senhaNova.Length == 0 || senhaNova.Length < 4 || senhaNova.Length > 20 || 
                    senhaAtual.Length == 0 || senhaAtual.Length < 4 || senhaAtual.Length > 20)
                {
                    MessageBox.Show("Senha nova e senha atual tem que ter mais de 4 caracteres e menos que 20.", 
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    funcionario = null;
                }
                else
                {
                    DatabaseAbstractionLayer.FuncionarioDAL funcionarioDAL = 
                        new DatabaseAbstractionLayer.FuncionarioDAL();

                    funcionario.getControleAcesso().setSenha(senhaNova);
                    
                    if( !funcionarioDAL.inserir(funcionario))
                    {
                        funcionario = null;
                    }
                }
            }

            return funcionario;
        }
    }
}

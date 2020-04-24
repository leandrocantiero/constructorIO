using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class FuncionarioController
    {
        public (List<string>, bool) cadastrar(Model.Funcionario func)
        {
            List<string> msgs = new List<string>();
            bool operacao = true;

            //funcionario
            if (func.getNome() == null || 
                func.getNome().ToString().Length == 0 || 
                func.getNome().ToString().Length > 30)
            {
                msgs.Add("Nome é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                operacao = false;
            }
            
            if (func.getRegistro() == null || 
                func.getRegistro().ToString().Length > 30)
            {
                msgs.Add("Registro, caso houver o funcionário tiver, é preciso ter menos que 30 caracteres..");
                operacao = false;
            }


            try
            {
                Convert.ToInt64(func.getCpf());

                if (func.getCpf() == null ||
                func.getCpf().ToString().Length != 11)
                {
                    msgs.Add("CPF é preciso ter a quantidade de 11 caracteres.");
                    operacao = false;
                }
            }
            catch (Exception ex)
            {
                msgs.Add("CPF só aceita números.");
                operacao = false;
            }

            try
            {
                Convert.ToInt64(func.getRg());

                if (func.getRg() == null ||
                    func.getRg().ToString().Length == 0 ||
                    func.getRg().ToString().Length < 11 ||
                    func.getRg().ToString().Length > 15)
                {
                    msgs.Add("RG é preciso ter entre 11 a 15 números.");
                    operacao = false;
                }
            }
            catch(Exception ex)
            {
                msgs.Add("RG só aceita números.");
                operacao = false;
            }

            if (func.getDtNascimento().ToString().Split(' ')[0].Split('/').Length != 3)
            {
                msgs.Add("Data de Nascimento é preciso ter dia, Mês e ano.");
                operacao = false;
            }

            if (func.getDtNascimento().ToString().Split(' ')[0].Split('/').Length != 3)
            {
                msgs.Add("Data de Nascimento é preciso ter dia, Mês e ano.");
                operacao = false;
            }

            //endereco
            if (func.getEndereco() != null)
            {
                if (func.getEndereco().getRua() == null ||
                    func.getEndereco().getRua().ToString().Length == 0 ||
                    func.getEndereco().getRua().ToString().Length > 30)
                {
                    msgs.Add("Rua é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }
                if (func.getEndereco().getCep() == null ||
                    func.getEndereco().getCep().ToString().Length != 8) 
                {
                    msgs.Add("CEP é preciso ter 8 caracteres.");
                    operacao = false;
                }

                try
                {
                    Convert.ToInt64(func.getEndereco().getNumero());
                    
                    if (func.getEndereco().getNumero() == 0 ||
                    func.getEndereco().getCep().ToString().Length > 999999)
                    {
                        msgs.Add("É preciso informar um número válido para o endereço.");
                        operacao = false;
                    }
                }
                catch(Exception ex)
                {
                    msgs.Add("Número do endereco só aceita valores númericos.");
                    operacao = false;
                }

                if (func.getEndereco().getComplemento().Length > 50)
                {
                    msgs.Add("É preciso informar um Complemento menor.");
                    operacao = false;
                }


                if (func.getEndereco().getBairro() == null ||
                    func.getEndereco().getBairro().Length == 0 ||
                    func.getEndereco().getBairro().Length > 30)
                {
                    msgs.Add("Bairro é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }

                if (func.getEndereco().getCidade() == null)
                {
                    msgs.Add("Cidade está completamente nulo.");
                    operacao = false;
                }

                if (func.getEndereco().getCidade().getEstado() == null)
                {
                    msgs.Add("Estado está completamente nulo.");
                    operacao = false;
                }
            }
            else
            {
                msgs.Add("Endereco está completamente nulo.");
                operacao = false;
            }

            //cargo
            if (func.getCargo() != null)
            {
                if(func.getCargo().getDescricao() == null || 
                    func.getCargo().getDescricao().Length == 0 || 
                    func.getCargo().getDescricao().Length > 30)
                {
                    msgs.Add("Cargo é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }
            }
            else
            {
                msgs.Add("Cargo está completamente nulo.");
                operacao = false;
            }

            //controle acesso
            if(func.getControleAcesso() != null)
            {
                if(func.getControleAcesso().getLogin() == null || 
                    func.getControleAcesso().getLogin().Length == 0 ||
                    func.getControleAcesso().getLogin().Length < 3 ||
                    func.getControleAcesso().getLogin().Length > 30)
                {
                    msgs.Add("Login é preciso ter a quantidade de caracteres maior que 2 e menor que 30.");
                    operacao = false;
                }

                if (func.getControleAcesso().getSenha() == null ||
                    func.getControleAcesso().getSenha().Length == 0 ||
                    func.getControleAcesso().getSenha().Length < 4 ||
                    func.getControleAcesso().getSenha().Length > 20)
                {
                    msgs.Add("Senha é preciso ter a quantidade de caracteres maior que 3 e menor que 30.");
                    operacao = false;
                }


                if(func.getControleAcesso().getNivelAcesso() < 1 || 
                    func.getControleAcesso().getNivelAcesso() > 2)
                {
                    msgs.Add("O nível de acesso é preciso ser entre 1 e 2.");
                    operacao = false;
                }

            }
            else
            {
                msgs.Add("Controle de acesso está completamente nulo.");
                operacao = false;
            }

            //data demissao
            if (func.getDtAdmissao() == null || func.getDtAdmissao().ToString().Split(' ')[0].Split('/').Length != 3)
            {
                msgs.Add("Data de adimissão está faltando dia, mês ou ano.");
                operacao = false;
            }


            //contato
            if(func.getContato() != null)
            {
                if(func.getContato().getNumeroPadrao() != null)
                {
                    if(func.getContato().getNumeroPadrao().getDdd().Length == 0 ||
                        func.getContato().getNumeroPadrao().getDdd().Length > 3)
                    {
                        msgs.Add("DDD do celular é preciso ter no máximo 3 caracteres.");
                        operacao = false;
                    }

                    if (func.getContato().getNumeroPadrao().getNumero().Length != 9)
                    {
                        msgs.Add("Número celular é preciso ter 9 caracteres.");
                        operacao = false;
                    }
                }

                if(func.getContato().getNumeroAlt() != null)
                {
                    if (func.getContato().getNumeroAlt().getDdd().Length > 3)
                    {
                        msgs.Add("DDD número fixo é preciso ter no máximo 3 caracteres.");
                        operacao = false;
                    }

                    if (func.getContato().getNumeroAlt().getNumero().Length > 8)
                    {
                        msgs.Add("Número do telefone fixo é preciso ter pelo menos 20 caracteres.");
                        operacao = false;
                    }

                }
            }
            else
            {
                msgs.Add("Os Contatos estão completamentes nulos.");
                operacao = false;
            }

            // PROIBIR EXCLUSAO DE ADM (MASTER)
            DatabaseAbstractionLayer.ControleAcessoDAL ctrAccess = new DatabaseAbstractionLayer.ControleAcessoDAL();
            DatabaseAbstractionLayer.FuncionarioDAL funcionarioDAL = new DatabaseAbstractionLayer.FuncionarioDAL();

            //if(func.getDtDemissao() != null &&
            //    funcionarioDAL.getQuantUserNivelUm() == 1 &&
            //    func.getControleAcesso().getNivelAcesso() == 1)
            //{
            //    operacao = false;
            //    msgs.Add("Não é possível demitir o último Usuario Master do sistema.");
            //}

            //if (func.getControleAcesso().getUsuarioAtivo() == false &&
            //    funcionarioDAL.getQuantUserNivelUm() == 1 &&
            //   func.getControleAcesso().getNivelAcesso() == 1)
            //{
            //    operacao = false;
            //    msgs.Add("Não é possível desativar o último Usuario Master do sistema.");
            //}



            if (operacao)
            {
                if (func.getCod() == 0)
                {
                    if(func.getCod() == 0)
                        func.setDtAdmissao(DateTime.Now);
                }
                
                Model.ControleAcesso ctrAccessExiste = ctrAccess.obterUmLogin(func.getControleAcesso().getLogin()) ;
                

                if (ctrAccessExiste == null || 
                    (func.getControleAcesso().getCod() == ctrAccessExiste.getCod()))
                {
                    if (funcionarioDAL.inserir(func))
                    {
                        operacao = true;
                        msgs.Add("Operação realiza com sucesso.");
                    }
                    else
                    {
                        operacao = false;
                        msgs.Add("Problema com banco de dados.");
                    }
                }
                else
                {
                    operacao = false;
                    msgs.Add("Já existe esse login cadastrado, escolha outro.");
                }
            }

            return (msgs, operacao);
        }

        internal void gerarUsuarioInicial()
        {
            DatabaseAbstractionLayer.FuncionarioDAL funcionarioDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
            funcionarioDAL.gerarUsuarioInicial();
        }

        public bool remover(int cod)
        {
            DatabaseAbstractionLayer.FuncionarioDAL funDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
            bool sucesso = funDAL.remover(cod);

            return sucesso;
        }

        public List<Model.Funcionario> obterTodos(string nome = null, string registro = null)
        {
            DatabaseAbstractionLayer.FuncionarioDAL funDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
            List<Model.Funcionario> funcionarios = funDAL.obterTodos(nome, registro);
            
            return funcionarios;
        }

        public Model.Funcionario obterUm(int cod)
        {
            DatabaseAbstractionLayer.FuncionarioDAL funDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
            Model.Funcionario funcionario = funDAL.obterUm(cod);

            return funcionario;
        }

        public List<Model.Cargo> obterTodosCargos()
        {
            DatabaseAbstractionLayer.CargoDAL cargoDAL = new DatabaseAbstractionLayer.CargoDAL();
            List<Model.Cargo> cargos = cargoDAL.obterTodos();

            return cargos;
        }

        public int getQuantUserNivelUm()
        {
            DatabaseAbstractionLayer.FuncionarioDAL funcionarioDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
            int quantidade = funcionarioDAL.getQuantUserNivelUm();

            return quantidade;
        }

    }
}

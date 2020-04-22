using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    class ClienteController
    {
        public (List<string>, bool) cadastrar(Model.Cliente cli)
        {
            List<string> msgs = new List<string>();
            bool operacao = true;

            //Cliente
            if (cli.getNome() == null ||
                cli.getNome().ToString().Length == 0 ||
                cli.getNome().ToString().Length > 30)
            {
                msgs.Add("Nome é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                operacao = false;
            }

            if (cli.getCpfCnpj() == null ||
                cli.getCpfCnpj().Length < 11)
            {
                msgs.Add("CPF/CNPJ é preciso ter a quantidade de caracteres maior que 11.");
                operacao = false;
            }

            if (cli.getEmail() == null ||
                cli.getEmail().Length < 10)
            {
                msgs.Add("E-mail é preciso ter a quantidade de caracteres maior que 10.");
                operacao = false;
            }


            if (cli.getDtNascimento().ToString().Split(' ')[0].Split('/').Length != 3)
            {
                msgs.Add("Data de Nascimento é preciso ter dia, Mês e ano.");
                operacao = false;
            }

            if (cli.getDtNascimento().ToString().Split(' ')[0].Split('/').Length != 3)
            {
                msgs.Add("Data de Nascimento é preciso ter dia, Mês e ano.");
                operacao = false;
            }

            //endereco
            if (cli.getEndereco() != null)
            {
                if (cli.getEndereco().getRua() == null ||
                    cli.getEndereco().getRua().ToString().Length == 0 ||
                    cli.getEndereco().getRua().ToString().Length > 30)
                {
                    msgs.Add("Rua é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }
                if (cli.getEndereco().getCep() == null ||
                    cli.getEndereco().getCep().ToString().Length == 0 ||
                    cli.getEndereco().getCep().ToString().Length < 0 ||
                    cli.getEndereco().getCep().ToString().Length > 11)
                {
                    msgs.Add("CEP é preciso ter a quantidade de 11 caracteres.");
                    operacao = false;
                }
                if (cli.getEndereco().getNumero() == 0 ||
                    cli.getEndereco().getCep().ToString().Length > 999999)
                {
                    msgs.Add("É preciso informar um número válido para o endereço.");
                    operacao = false;
                }

                if (cli.getEndereco().getLogradouro().Length > 50)
                {
                    msgs.Add("É preciso informar um logradouro menor.");
                    operacao = false;
                }


                if (cli.getEndereco().getBairro() == null ||
                    cli.getEndereco().getBairro().Length == 0 ||
                    cli.getEndereco().getBairro().Length > 30)
                {
                    msgs.Add("Bairro é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }

                if (cli.getEndereco().getCidade() == null)
                {
                    msgs.Add("Cidade está completamente nulo.");
                    operacao = false;
                }

                if (cli.getEndereco().getCidade().getEstado() == null)
                {
                    msgs.Add("Cidade está completamente nulo.");
                    operacao = false;
                }
            }
            else
            {
                msgs.Add("Endereco está completamente nulo.");
                operacao = false;
            }

            //contato
            {
                if (cli.getContato() != null)
                {
                    if (cli.getContato().getNumeroPadrao().getDdd().Length == 0 ||
                        cli.getContato().getNumeroPadrao().getDdd().Length > 5)
                    {
                        msgs.Add("DDD principal é preciso ter pelo menos 5 caracteres.");
                        operacao = false;
                    }

                    if (cli.getContato().getNumeroPadrao().getNumero().Length == 0 ||
                        cli.getContato().getNumeroPadrao().getNumero().Length > 20)
                    {
                        msgs.Add("Número principal é preciso ter pelo menos 20 caracteres.");
                        operacao = false;
                    }

                    if (cli.getContato().getNumeroAlt().getDdd().Length > 5)
                    {
                        msgs.Add("DDD secundário é preciso ter pelo menos 5 caracteres.");
                        operacao = false;
                    }

                    if (cli.getContato().getNumeroAlt().getNumero().Length > 20)
                    {
                        msgs.Add("Número secundário é preciso ter pelo menos 20 caracteres.");
                        operacao = false;
                    }
                }
            }

            if (operacao)
            {
                DatabaseAbstractionLayer.ClienteDAL ClienteDAL = new DatabaseAbstractionLayer.ClienteDAL();

                    if (ClienteDAL.inserir(cli))
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

            return (msgs, operacao);
        }

        public bool remover(int cod)
        {
            DatabaseAbstractionLayer.ClienteDAL cliDAL = new DatabaseAbstractionLayer.ClienteDAL();
            bool sucesso = cliDAL.remover(cod);

            return sucesso;
        }

        public List<Model.Cliente> obterTodos(string nome = null, string cod = null)
        {
            DatabaseAbstractionLayer.ClienteDAL cliDAL = new DatabaseAbstractionLayer.ClienteDAL();
            List<Model.Cliente> Clientes = cliDAL.obterTodos(nome, cod);

            return Clientes;
        }

        public Model.Cliente obterUm(int cod)
        {
            DatabaseAbstractionLayer.ClienteDAL cliDAL = new DatabaseAbstractionLayer.ClienteDAL();
            Model.Cliente Cliente = cliDAL.obterUm(cod);

            return Cliente;
        }
    }
}

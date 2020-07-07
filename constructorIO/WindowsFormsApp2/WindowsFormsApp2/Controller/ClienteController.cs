using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    class ClienteController
    {
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            cpf = cpf.Replace(",", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            cnpj = cnpj.Replace(",", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

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

            if (cli.getRegistro().Length > 15 && !IsCnpj(cli.getRegistro()))
            {
                msgs.Add("CNPJ inválido");
                operacao = false;
            } else if (cli.getRegistro().Length < 15 && !IsCpf(cli.getRegistro()))
            {
                msgs.Add("CPF inválido");
                operacao = false;
            }

            if (cli.getRegistro() == null ||
                cli.getRegistro().ToString().Length < 14)
            {
                msgs.Add("CPF/CNPJ é preciso ter a quantidade de caracteres maior que 11.");
                operacao = false;
            }

            if (cli.getEmail().Length < 10)
            {
                msgs.Add("E-mail é preciso ter a quantidade de caracteres maior que 10.");
                operacao = false;
            }


            if (cli.getDtNascimento().ToString().Split(' ')[0].Split('/').Length != 3)
            {
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

                if (cli.getEndereco().getComplemento().Length > 50)
                {
                    msgs.Add("É preciso informar um complemento menor.");
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

                    if (cli.getContato().getNumeroPadrao().getNumero().Length < 10 ||
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

        public List<Model.Cliente> obterTodos(string nome = null, string registro = null)
        {
            DatabaseAbstractionLayer.ClienteDAL cliDAL = new DatabaseAbstractionLayer.ClienteDAL();
            return cliDAL.obterTodos(nome, registro);
        }

        public Model.Cliente obterUm(int cod)
        {
            DatabaseAbstractionLayer.ClienteDAL cliDAL = new DatabaseAbstractionLayer.ClienteDAL();
            Model.Cliente Cliente = cliDAL.obterUm(cod);

            return Cliente;
        }
    }
}

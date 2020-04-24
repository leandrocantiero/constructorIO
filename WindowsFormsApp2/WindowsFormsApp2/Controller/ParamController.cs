using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    class ParamController
    {
        public (List<string>, bool) cadastrar(Model.Param param)
        {
            List<string> msgs = new List<string>();
            bool operacao = true;

            //Param
            if (param.getRazaoSocial() == null ||
                param.getRazaoSocial().ToString().Length == 0 ||
                param.getRazaoSocial().ToString().Length > 30)
            {
                msgs.Add("Nome é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                operacao = false;
            }
            if (param.getFantasia() == null ||
                param.getFantasia().ToString().Length == 0 ||
                param.getFantasia().ToString().Length > 30)
            {
                msgs.Add("Nome é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                operacao = false;
            }
            if (param.getInscEstadual() == null ||
                param.getInscEstadual().ToString().Length == 0 ||
                param.getInscEstadual().ToString().Length > 30)
            {
                msgs.Add("Nome é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                operacao = false;
            }

            if (param.getCnpj() == null ||
                param.getCnpj().Length < 11)
            {
                msgs.Add("CPF/CNPJ é preciso ter a quantidade de caracteres maior que 11.");
                operacao = false;
            }

            //endereco
            if (param.getEndereco() != null)
            {
                if (param.getEndereco().getRua() == null ||
                    param.getEndereco().getRua().ToString().Length == 0 ||
                    param.getEndereco().getRua().ToString().Length > 30)
                {
                    msgs.Add("Rua é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }
                if (param.getEndereco().getCep() == null ||
                    param.getEndereco().getCep().ToString().Length == 0 ||
                    param.getEndereco().getCep().ToString().Length < 0 ||
                    param.getEndereco().getCep().ToString().Length > 11)
                {
                    msgs.Add("CEP é preciso ter a quantidade de 11 caracteres.");
                    operacao = false;
                }
                if (param.getEndereco().getNumero() == 0 ||
                    param.getEndereco().getCep().ToString().Length > 999999)
                {
                    msgs.Add("É preciso informar um número válido para o endereço.");
                    operacao = false;
                }

                if (param.getEndereco().getComplemento().Length > 50)
                {
                    msgs.Add("É preciso informar um complemento menor.");
                    operacao = false;
                }


                if (param.getEndereco().getBairro() == null ||
                    param.getEndereco().getBairro().Length == 0 ||
                    param.getEndereco().getBairro().Length > 30)
                {
                    msgs.Add("Bairro é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                    operacao = false;
                }

                if (param.getEndereco().getCidade() == null)
                {
                    msgs.Add("Cidade está completamente nulo.");
                    operacao = false;
                }

                if (param.getEndereco().getCidade().getEstado() == null)
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
                if (param.getContato() != null)
                {
                    if (param.getContato().getNumeroPadrao().getDdd().Length == 0 ||
                        param.getContato().getNumeroPadrao().getDdd().Length > 5)
                    {
                        msgs.Add("DDD principal é preciso ter pelo menos 5 caracteres.");
                        operacao = false;
                    }

                    if (param.getContato().getNumeroPadrao().getNumero().Length == 0 ||
                        param.getContato().getNumeroPadrao().getNumero().Length > 20)
                    {
                        msgs.Add("Número principal é preciso ter pelo menos 20 caracteres.");
                        operacao = false;
                    }

                    if (param.getContato().getNumeroAlt().getDdd().Length > 5)
                    {
                        msgs.Add("DDD secundário é preciso ter pelo menos 5 caracteres.");
                        operacao = false;
                    }

                    if (param.getContato().getNumeroAlt().getNumero().Length > 20)
                    {
                        msgs.Add("Número secundário é preciso ter pelo menos 20 caracteres.");
                        operacao = false;
                    }
                }
            }

            if (operacao)
            {
                DatabaseAbstractionLayer.ParamDAL ParamDAL = new DatabaseAbstractionLayer.ParamDAL();

                if (ParamDAL.inserir(param))
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
            DatabaseAbstractionLayer.ParamDAL paramDAL = new DatabaseAbstractionLayer.ParamDAL();
            bool sucesso = paramDAL.remover(cod);

            return sucesso;
        }

        public Model.Param obterUm(int cod)
        {
            DatabaseAbstractionLayer.ParamDAL paramDAL = new DatabaseAbstractionLayer.ParamDAL();
            Model.Param parametro = paramDAL.obterUm(cod);

            return parametro;
        }

        public int obterQuantidade()
        {
            DatabaseAbstractionLayer.ParamDAL paramDAL = new DatabaseAbstractionLayer.ParamDAL();
           int quantidade = paramDAL.obterQuantidade();

            return quantidade;
        }
    }
}

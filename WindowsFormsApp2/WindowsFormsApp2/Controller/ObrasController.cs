using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controller
{
    public class ObrasController
    {
        public (List<string>, bool) inserir(Model.Obra obra, List<object> tarefaObj)
        {
            List<string> msgs = null;
            bool operacao = false;
            DatabaseAbstractionLayer.TarefaDAL tarefaDAL = new DatabaseAbstractionLayer.TarefaDAL();
            DatabaseAbstractionLayer.ObraDAL obraDAL = new DatabaseAbstractionLayer.ObraDAL();
            DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
            DatabaseAbstractionLayer.StatusDAL statusDAL = new DatabaseAbstractionLayer.StatusDAL();

            (msgs, operacao) = verificaDados(obra);

            if(operacao && tarefaObj.Count == 0)
            {
                msgs.Add("É necessário inserir pelo menos uma tarefa.");
                operacao = false;
            }

            if(operacao)
            {
                try
                {
                    if(obra.getCod() == 0)
                    {
                        Model.Status statusInserir = statusDAL.obterUm("Em execução");
                        obra.setStatus(statusInserir);
                    }
                }
                catch(Exception ex)
                {
                    operacao = false;
                }


                try
                {
                    operacao = enderecoDAL.inserir(obra.getEndereco());
                    
                    if (operacao) 
                        operacao = obraDAL.inserir(obra);

                    if(operacao)
                    {
                        if(obra.getCod() == 0)
                        {
                            foreach(var obj in tarefaObj)
                            {
                                operacao = tarefaDAL.inserirTarefaObra(obra.getCod(), ((Model.Tarefa)obj).getCod());

                                if (!operacao) break;
                            }
                        }
                        else
                        {

                            //retira todos que nao existem na lista para inserir
                            bool contem;
                            List<Model.Tarefa> tarefasGravadas = tarefaDAL.obterTodasPorObra(obra.getCod());
                            if(tarefasGravadas != null && tarefasGravadas.Count > 0 && tarefaObj != null && tarefaObj.Count > 0)
                            {
                                foreach (Model.Tarefa tarefaGravada in tarefasGravadas)
                                {
                                    contem = false;
                                    foreach (Model.Tarefa tarefaInserir in tarefaObj)
                                    {
                                        if(tarefaGravada.getCod() == tarefaInserir.getCod())
                                        {
                                            contem = true;
                                        }
                                    }

                                    if(contem == false)
                                    {
                                        tarefaDAL.removerTarefaObra(obra.getCod(), tarefaGravada.getCod());
                                    }
                                }
                            }

                            tarefasGravadas = tarefaDAL.obterTodasPorObra(obra.getCod());
                            if(tarefasGravadas != null && tarefasGravadas.Count > 0 && tarefaObj != null && tarefaObj.Count > 0)
                            {
                                //inseri todos que nao tem gravados ainda
                                foreach (Model.Tarefa tarefaInserir in tarefaObj)
                                {
                                    contem = false;
                                    foreach (Model.Tarefa tarefaGravada in tarefasGravadas)
                                    {
                                        if (tarefaInserir.getCod() == tarefaGravada.getCod())
                                        {
                                            contem = true;
                                        }
                                    }

                                    if (contem == false)
                                    {
                                        tarefaDAL.inserirTarefaObra(obra.getCod(), tarefaInserir.getCod());
                                    }
                                }
                            }
                            else
                            {
                                foreach (Model.Tarefa tarefaInserir in tarefaObj)
                                {
                                    tarefaDAL.inserirTarefaObra(obra.getCod(), tarefaInserir.getCod());
                                }
                            }
                        }
                    }

                    if(operacao)
                    {
                        msgs.Add("Inserido com sucesso!!");
                    }
                }
                catch(Exception ex)
                {
                    msgs.Add("ERRO ao inserir obra. =>> " + ex.Message);
                }
            }


            return (msgs, operacao);
        }

        public List<Model.Obra> obterTodas(string rua=null, string nomeCliente=null)
        {
            DatabaseAbstractionLayer.ObraDAL obraDAL = new DatabaseAbstractionLayer.ObraDAL();
            return obraDAL.obterTodas(rua, nomeCliente);
        }

        public List<object> getTodasEtapas(string nome = null)
        {
            DatabaseAbstractionLayer.EtapaDAL etapaDAL = new DatabaseAbstractionLayer.EtapaDAL();
            var etapas = etapaDAL.obterTodas(nome);

            if(etapas != null)
                return new List<object>(etapas);

            return new List<object>();
        }

        public List<object> obterTodasTarefas(int codEtapa)
        {
            DatabaseAbstractionLayer.TarefaDAL tarefaDAL = new DatabaseAbstractionLayer.TarefaDAL();

            var tarefas = tarefaDAL.obterTodas(codEtapa);

            if(tarefas != null)
                return new List<object>(tarefas);
            return new List<object>();
        }

        public List<object> obterTodasTarefasPorObra(int codObra)
        {
            DatabaseAbstractionLayer.TarefaDAL tarefaDAL = new DatabaseAbstractionLayer.TarefaDAL();

            var tarefas = tarefaDAL.obterTodasPorObra(codObra);

            if(tarefas != null)
            {
                return new List<object>(tarefas);
            }
            return new List<object>();

        }



        private (List<string>, bool) verificaDados(Model.Obra obra)
        {
            List<string> msgs = new List<string>();
            bool operacao = true;

            if(obra != null)
            {
                if(obra.getCliente() == null || obra.getCliente().getCod() == 0)
                {
                    msgs.Add("Cliente está nulo, selecione um.");
                    operacao = false;
                }

                if(obra.getFuncionario() == null || obra.getFuncionario().getCod() == 0)
                {
                    msgs.Add("Funcionário está nulo, selecione um.");
                    operacao = false;
                }

                if(obra.getValor() == null || obra.getValor() < 0)
                {
                    msgs.Add("Valor da obra não pode ser negativo ou está nulo");
                    operacao = false;
                }

                if (obra.getDescricao() == null || obra.getDescricao().Length > 200)
                {
                    msgs.Add("descrição muito grande. tem que ser menor que 200 caracteres.");
                    operacao = false;
                }

                if (obra.getDataInicio() == null || obra.getDataInicio().ToString().Split(' ')[0].Split('/').Length != 3)
                {
                    msgs.Add("Selecione uma data completa para o início da obra não pode ser negativo ou está nulo");
                    operacao = false;
                }

                if (obra.getDataPrevFim() == null || obra.getDataPrevFim().ToString().Split(' ')[0].Split('/').Length != 3)
                {
                    msgs.Add("Selecione uma data de previsão para o fim.");
                    operacao = false;
                }

                if (obra.getStatus() == null || obra.getStatus().getCod() == 0)
                {
                    msgs.Add("Selecione um status corretamente.");
                    operacao = false;
                }
                //endereco
                if (obra.getEndereco() != null)
                {
                    if (obra.getEndereco().getRua() == null ||
                        obra.getEndereco().getRua().ToString().Length == 0 ||
                        obra.getEndereco().getRua().ToString().Length > 30)
                    {
                        msgs.Add("Rua é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                        operacao = false;
                    }
                    if (obra.getEndereco().getCep() == null ||
                        obra.getEndereco().getCep().ToString().Length != 8)
                    {
                        msgs.Add("CEP é preciso ter 8 caracteres.");
                        operacao = false;
                    }

                    try
                    {
                        Convert.ToInt64(obra.getEndereco().getNumero());

                        if (obra.getEndereco().getNumero() == 0 ||
                        obra.getEndereco().getCep().ToString().Length > 999999)
                        {
                            msgs.Add("É preciso informar um número válido para o endereço.");
                            operacao = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        msgs.Add("Número do endereco só aceita valores númericos.");
                        operacao = false;
                    }

                    if (obra.getEndereco().getComplemento().Length > 50)
                    {
                        msgs.Add("É preciso informar um Complemento menor.");
                        operacao = false;
                    }


                    if (obra.getEndereco().getBairro() == null ||
                        obra.getEndereco().getBairro().Length == 0 ||
                        obra.getEndereco().getBairro().Length > 30)
                    {
                        msgs.Add("Bairro é preciso ter a quantidade de caracteres maior que 0 e menor que 30.");
                        operacao = false;
                    }

                    if (obra.getEndereco().getCidade() == null)
                    {
                        msgs.Add("Cidade está completamente nulo.");
                        operacao = false;
                    }

                    if (obra.getEndereco().getCidade().getEstado() == null)
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



            }
            else
            {
                msgs.Add("Obra está nula.");
                operacao = false;
            }


            return (msgs, operacao);
        }

        public  List<object> obterStatus()
        {
            DatabaseAbstractionLayer.StatusDAL statusDAL = new DatabaseAbstractionLayer.StatusDAL();
            return new List<object>(statusDAL.obterTodos());
        }
    }
}

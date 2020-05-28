using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ConsumoServicoDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public ConsumoServicoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.ConsumoServico consumoServico)
        {
            bool sucesso;
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"INSERT INTO public.consumo_servico(
                                quant_homem, 
                                quant_m2, 
                                cod_servico, 
                                cod_consumo_mat_serv,
                                data_consumo_mat_serv,
                                cod_tarefa
                            ) VALUES (
                                @quant_homem, 
                                @quant_m2, 
                                @cod_servico, 
                                @cod_consumo_mat_serv,
                                @data_consumo_mat_serv,
                                @cod_tarefa) 
                            RETURNING 0;";

            param.Add("@data_consumo_mat_serv", consumoServico.getData());
            param.Add("@quant_homem", consumoServico.getQuantidadeHomem());
            param.Add("@quant_m2", consumoServico.getMetrosQuadrados());
            param.Add("@cod_consumo_mat_serv", consumoServico.getConsumoMaterialServico().getCod());
            param.Add("@cod_servico", consumoServico.getServico().getCod());
            param.Add("@cod_tarefa", consumoServico.getTarefa().getCod());

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
            }
            catch (Exception)
            {
                sucesso = false;
            }

            return sucesso;
        }

        public bool remover(int codConsumoMatServ)
        {
            bool sucesso;
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"delete from consumo_material 
                            WHERE
                                cod_consumo_mat_serv=@cod_consumo_mat_serv 
                            RETURNING 0;";

            param.Add("@cod_consumo_mat_serv", codConsumoMatServ);

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
            }
            catch (Exception)
            {
                sucesso = false;
            }

            return sucesso;
        }

        //public bool atualizar(Model.ConsumoServico consumoServico)
        //{
        //    string sql = @" UPDATE public.consumo_servico
        //                    SET 
        //                        quant_homem=@quant_homem, 
        //                        quant_m2=@quant_m2, 
        //                 WHERE 
        //                        data_consumo_mat_serv=@data_consumo_mat_serv and
        //                        cod_servico=@cod_servico and 
        //                        cod_consumo_mat_serv=@cod_consumo_mat_serv 
        //                    RETURNING 0;";


        //    bool sucesso;
        //    var param = bd.getParams();

        //    param.Add("@data_consumo_mat_serv", consumoServico.getData());
        //    param.Add("@quant_homem", consumoServico.getQuantidadeHomem());
        //    param.Add("@quant_m2", consumoServico.getMetrosQuadrados());
        //    param.Add("@cod_consumo_mat_serv", consumoServico.getConsumoMaterialServico().getCod());
        //    param.Add("@cod_servico", consumoServico.getServico().getCod());

        //    try
        //    {
        //        sucesso = bd.executeNonQuery(sql, param);
        //    }
        //    catch (Exception)
        //    {
        //        sucesso = false;
        //    }

        //    return sucesso;
        //}

        public List<Model.ConsumoServico> obterTodosByConsumoMatServ(int codConsumoMatServ)
        {
            List<Model.ConsumoServico> consumoServicos = new List<Model.ConsumoServico>();
            string sql = @" SELECT 
                                quant_homem, quant_m2, cod_servico, cod_consumo_mat_serv, data_consumo_mat_serv, cod_tarefa
	                        FROM public.consumo_servico
                            WHERE
                                cod_consumo_mat_serv = @cod_consumo_mat_serv;";


            var param = bd.getParams();

            param.Add("@cod_consumo_mat_serv", codConsumoMatServ);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        consumoServicos.Add(map(dt.Rows[0]));
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return consumoServicos;
        }

        internal Model.ConsumoServico map(DataRow row)
        {
            // quant_homem, quant_m2, cod_servico, cod_consumo_mat_serv

            Model.ConsumoServico consumoServico = new Model.ConsumoServico();
            Model.ConsumoMaterialServico consumoMaterialServico = new Model.ConsumoMaterialServico();

            consumoMaterialServico.setCod(Convert.ToInt32(row["cod_consumo_mat_serv"]));
            consumoServico.setData(Convert.ToDateTime(row["data_consumo_mat_serv"]));
            consumoServico.setConsumoMaterialServico(consumoMaterialServico);
            consumoServico.setTarefa(new DatabaseAbstractionLayer.TarefaDAL().obterUma(Convert.ToInt32(row["cod_tarefa"])));

            consumoServico.setMetrosQuadrados(Convert.ToInt32(row["quant_m2"]));
            consumoServico.setQuantidadeHomem(Convert.ToInt32(row["quant_homem"]));
            consumoServico.setServico(new DatabaseAbstractionLayer.ServicoDAL().obterUm(Convert.ToInt32(row["cod_servico"])));

            return consumoServico;
        }

    }
}

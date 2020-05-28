using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ConsumoMaterialDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public ConsumoMaterialDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.ConsumoMaterial consumoMaterial)
        {
            bool sucesso;
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"INSERT INTO public.consumo_material(
	                        quant, 
                            cod_material, 
                            cod_consumo_mat_serv,
                            data_consumo_mat_serv,
                            cod_tarefa)
	                      VALUES (
                            @quant, 
                            @cod_material, 
                            @cod_consumo_mat_serv,
                            @data_consumo_mat_serv,
                            @cod_tarefa) RETURNING 0;";

            
            param.Add("@data_consumo_mat_serv", consumoMaterial.getData());
            param.Add("@quant", consumoMaterial.getQuantidadeMaterial());
            param.Add("@cod_material", consumoMaterial.getMaterial().getCod());
            param.Add("@cod_consumo_mat_serv", consumoMaterial.getConsumoMaterialServico().getCod());
            param.Add("@cod_tarefa", consumoMaterial.getTarefa().getCod());

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

        //public bool atualizar(Model.ConsumoMaterial consumoMaterial)
        //{
        //    string sql = @"UPDATE public.consumo_material
        //                 SET 
        //                        quant=@quant  
        //                 WHERE 
        //                        data_consumo_mat_serv=@data_consumo_mat_serv and
        //                        cod_material=@cod_material and 
        //                        cod_consumo_mat_serv=@cod_consumo_mat_serv
        //                    RETURNING 0;";


        //    bool sucesso;
        //    var param = bd.getParams();

        //    param.Add("@data_consumo_mat_serv", consumoMaterial.getData());
        //    param.Add("@quant", consumoMaterial.getQuantidadeMaterial());
        //    param.Add("@cod_material", consumoMaterial.getMaterial().getCod());
        //    param.Add("@cod_consumo_mat_serv", consumoMaterial.getConsumoMaterialServico().getCod());

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

        public List<Model.ConsumoMaterial> obterTodosByConsumoMatServ(int codConsumoMatServ)
        {
            List<Model.ConsumoMaterial> consumoMateriais = new List<Model.ConsumoMaterial>();
            string sql = @"SELECT 
                            quant, 
                            cod_material, 
                            cod_consumo_mat_serv,
                            data_consumo_mat_serv,
                            cod_tarefa
                           FROM 
                            public.consumo_material 
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
                        consumoMateriais.Add(map(dt.Rows[0]));
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return consumoMateriais;
        }

        public bool remover(int codConsumoMatServ)
        {
            bool sucesso;
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"delete from consumo_servico 
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

        internal Model.ConsumoMaterial map(DataRow row)
        {
            Model.ConsumoMaterial consumoMaterial = new Model.ConsumoMaterial();
            Model.ConsumoMaterialServico consumoMaterialServico = new Model.ConsumoMaterialServico();

            consumoMaterialServico.setCod(Convert.ToInt32(row["cod_consumo_mat_serv"]));
            consumoMaterial.setData(Convert.ToDateTime(row["data_consumo_mat_serv"]));
            consumoMaterial.setConsumoMaterialServico(consumoMaterialServico);
            consumoMaterial.setTarefa(new DatabaseAbstractionLayer.TarefaDAL().obterUma(Convert.ToInt32(row["cod_tarefa"])));
            consumoMaterial.setMaterial(new DatabaseAbstractionLayer.MaterialDAL().obterUm(Convert.ToInt32(row["cod_material"])));
            consumoMaterial.setQuantidadeMaterial(Convert.ToInt32(row["quant"]));

            return consumoMaterial;
        }

    }
}

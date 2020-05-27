using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sql = @"INSERT INTO public.tarefa_material(
	                        quant, 
                            cod_material, 
                            cod_consumo_mat_serv)
	                      VALUES (
                            @quant, 
                            @cod_material, 
                            @cod_consumo_mat_serv) RETURNING 0;";

            param.Add("@quant", consumoMaterial.getQuantidadeMaterial());
            param.Add("@cod_material", consumoMaterial.getMaterial().getCod());
            param.Add("@cod_consumo_mat_serv", consumoMaterial.getConsumoMaterialServico().getCod());

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

        public bool atualizar(Model.ConsumoMaterial consumoMaterial)
        {
            string sql = @"UPDATE public.tarefa_material
	                        SET 
                                quant=@quant  
	                        WHERE 
                                cod_material=@cod_material and 
                                cod_consumo_mat_serv=@cod_consumo_mat_serv 
                            RETURNING 0;";


            bool sucesso;
            var param = bd.getParams();

            param.Add("@quant", consumoMaterial.getQuantidadeMaterial());
            param.Add("@cod_material", consumoMaterial.getMaterial().getCod());
            param.Add("@cod_consumo_mat_serv", consumoMaterial.getConsumoMaterialServico().getCod());

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

        public Model.ConsumoMaterial obterUm(int codMaterial, int codConsumoMatServ)
        {
            Model.ConsumoMaterial consumoMaterial = null;
            string sql = @"SELECT 
                            quant, 
                            cod_material, 
                            cod_consumo_mat_serv
                           FROM 
                            public.tarefa_material 
                           WHERE 
                                cod_material=@cod_material and 
                                cod_consumo_mat_serv=@cod_consumo_mat_serv ";


            var param = bd.getParams();

            param.Add("@cod_material", codMaterial);
            param.Add("@cod_consumo_mat_serv", codConsumoMatServ);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count == 1)
                {
                    consumoMaterial = map(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {

            }

            return consumoMaterial;
        }

        internal Model.ConsumoMaterial map(DataRow row)
        {
            Model.ConsumoMaterial consumoMaterial = new Model.ConsumoMaterial();
            Model.ConsumoMaterialServico consumoMaterialServico = new Model.ConsumoMaterialServico();

            consumoMaterialServico.setCod(Convert.ToInt32(row["cod_consumo_mat_serv"]));
            consumoMaterial.setConsumoMaterialServico(consumoMaterialServico);

            consumoMaterial.setMaterial(new DatabaseAbstractionLayer.MaterialDAL().obterUm(Convert.ToInt32(row["cod_material"])));
            consumoMaterial.setQuantidadeMaterial(Convert.ToInt32(row["quant"]));

            return consumoMaterial;
        }

    }
}

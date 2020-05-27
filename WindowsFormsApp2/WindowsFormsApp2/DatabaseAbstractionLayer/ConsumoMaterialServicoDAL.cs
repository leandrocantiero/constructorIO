using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ConsumoMaterialServicoDAL
    {

        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public ConsumoMaterialServicoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.ConsumoMaterialServico consumoMaterialServico)
        {
            bool sucesso;
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"INSERT INTO public.consumo_mat_serv (
	                        data, 
                            cod_obra_tarefa_obra, 
                            cod_tarefa_tarefa_obra
                        ) VALUES (
                            data, 
                            cod_obra_tarefa_obra, 
                            cod_tarefa_tarefa_obra
                            ) RETURNING 0;";

            param.Add("@data", consumoMaterialServico.getData());
            param.Add("@cod_obra_tarefa_obra", consumoMaterialServico.getObra().getCod());
            param.Add("@cod_tarefa_tarefa_obra", consumoMaterialServico.getTarefa().getCod());

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
    }
}

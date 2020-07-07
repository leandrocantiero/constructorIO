using System;
using System.Collections.Generic;
using System.Data;
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
                            cod_obra
                        ) VALUES (
                            @data, 
                            @cod_obra
                            ) RETURNING cod;";

            param.Add("@data", consumoMaterialServico.getData());
            param.Add("@cod_obra", consumoMaterialServico.getObra().getCod());

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
                consumoMaterialServico.setCod(bd.getUltimoCod());
            }
            catch (Exception)
            {
                sucesso = false;
            }

            return sucesso;
        }

        public bool remover(int cod)
        {
            bool sucesso;
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"delete from consumo_mat_serv where cod=@cod RETURNING 0;";

            param.Add("@cod", cod);

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

        public List<Model.ConsumoMaterialServico> obterTodos(DateTime data, bool isDate = false)
        {
            List<Model.ConsumoMaterialServico> consumoMaterialServicos = new List<Model.ConsumoMaterialServico>();
            var param = bd.getParams();

            //mudar nome da tabela tarefa_servico para consumo_servico
            string sql = @"SELECT 
                            cod, data, cod_obra
	                        FROM public.consumo_mat_serv ";

            if(isDate)
            {

                //string d = data.ToShortDateString().Split('/')[0];
                //string mm = data.ToShortDateString().Split('/')[1];
                //string aaaa = data.ToShortDateString().Split('/')[2];

                //string dataf = aaaa + '-' + mm + '-' + d;

                sql += " where to_char(data, 'dd/mm/yyyy') = @data";
                param.Add("@data", data.ToString("dd/MM/yyyy"));
            }

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        consumoMaterialServicos.Add(map(row));
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return consumoMaterialServicos;
        }

        internal Model.ConsumoMaterialServico map(DataRow row)
        {
            Model.Obra obra = new Model.Obra();
            Model.ConsumoMaterialServico consumoMaterialServico = new Model.ConsumoMaterialServico();

            var obras = new DatabaseAbstractionLayer.ObraDAL().obterTodas();
            foreach (var o in obras)
            {
                if(o.getCod() == Convert.ToInt32(row["cod_obra"]))
                {
                    obra = o;
                    break;
                }
            }

            consumoMaterialServico.setCod(Convert.ToInt32(row["cod"]));
            consumoMaterialServico.setData(Convert.ToDateTime(row["data"]));
            consumoMaterialServico.setObra(obra);

            return consumoMaterialServico;
        }


    }
}

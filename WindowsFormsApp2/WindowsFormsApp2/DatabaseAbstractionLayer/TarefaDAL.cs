using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class TarefaDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public TarefaDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public List<Model.Tarefa> obterTodas(int codEtapa = 0)
        {
            List<Model.Tarefa> tarefas = null;
            string sql = @"select 
                                tarefa.cod as cod_tarefa, 
                                cod_etapa, 
                                tarefa.descricao as tarefa_descricao, 
                                etapa.descricao as etapa_descricao
                           from tarefa, etapa
                                where cod_etapa = etapa.cod ";

            var param = bd.getParams();
            
            if(codEtapa != 0)
            {
                sql += " and cod_etapa = @codEtapa;";
                param.Add("@codEtapa", codEtapa);
            }


            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    tarefas = new List<Model.Tarefa>();

                    foreach (DataRow row in dt.Rows)
                    {
                        tarefas.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return tarefas;
        }

        public List<Model.Tarefa> obterTodasPorObra(int codObra)
        {
            List<Model.Tarefa> tarefas = null;
            string sql = @"select 
                                tarefa.cod as cod_tarefa, 
                                cod_etapa, 
                                tarefa.descricao as tarefa_descricao, 
                                etapa.descricao as etapa_descricao
                           from tarefa, etapa, tarefa_obra
                                where cod_etapa = etapa.cod and
                                tarefa_obra.cod_tarefa = tarefa.cod and
                                tarefa_obra.cod_obra = @codObra";

            var param = bd.getParams();
            param.Add("@codObra", codObra);


            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    tarefas = new List<Model.Tarefa>();

                    foreach (DataRow row in dt.Rows)
                    {
                        tarefas.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return tarefas;
        }

        

        public List<Model.Tarefa> obterTodasComObra(int codObra)
        {
            List<Model.Tarefa> tarefas = null;
            string sql = @"select 
                                tarefa.cod as cod_tarefa, 
                                cod_etapa, 
                                tarefa.descricao as tarefa_descricao, 
                                etapa.descricao as etapa_descricao
                           from tarefa, etapa, tarefa_obra
                                where cod_etapa = etapa.cod and
                                cod_obra = @codObra and
                                tarefa_obra.cod_tarefa = tarefa.cod
                                order by tarefa.descricao";
            var param = bd.getParams();

            try
            {
                DataTable dt = bd.executeSelect(sql);

                if (dt.Rows.Count > 0)
                {
                    tarefas = new List<Model.Tarefa>();

                    foreach (DataRow row in dt.Rows)
                    {
                        tarefas.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return tarefas;
        }

        public bool removerTarefaObra(int codObra, int codTarefa)
        {
            List<Model.Tarefa> tarefas = null;
            string sql = @"delete from tarefa_obra 
                            where 
                                cod_obra = @codObra and 
                                cod_tarefa = @codTarefa RETURNING 1;";

            bool operacao = false;

            var param = bd.getParams();
            param.Add("@codObra", codObra);
            param.Add("@codTarefa", codTarefa);

            try
            {
                operacao = bd.executeNonQuery(sql, param);

            }
            catch (Exception ex)
            {

            }

            return operacao;
        }

        public bool inserirTarefaObra(int codObra, int codTarefa)
        {
            List<Model.Tarefa> tarefas = null;
            string sql = @"insert into tarefa_obra(cod_obra, cod_tarefa) values(@codObra, @codTarefa) RETURNING 1;";
            bool operacao = false;
            
            var param = bd.getParams();
            param.Add("@codObra", codObra);
            param.Add("@codTarefa", codTarefa);
            
            try
            {
                operacao = bd.executeNonQuery(sql, param);

            }
            catch (Exception ex)
            {

            }

            return operacao;
        }

        internal Model.Tarefa map(DataRow row)
        {
            Model.Tarefa tarefa = new Model.Tarefa();
            Model.Etapa etapa = new Model.Etapa();

            etapa.Cod = Convert.ToInt32(row["cod_etapa"]);
            etapa.Descricao = row["etapa_descricao"].ToString();

            tarefa.Cod = Convert.ToInt32(row["cod_tarefa"]);
            tarefa.Descricao = row["tarefa_descricao"].ToString();

            tarefa.Etapa = etapa;

            return tarefa;
        }
    }
}

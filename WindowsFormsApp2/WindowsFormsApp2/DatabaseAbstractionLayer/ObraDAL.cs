using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ObraDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;
        DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = null;

        public ObraDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();

            // DALs auxiliares para (obter, remover e etc) os funcionarios
            enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
        }

        public bool inserir(Model.Obra obra)
        {
            bool operacao = false;
            string sql = "";

            var param = bd.getParams();

            if (obra.getCod() == 0)
            {
                sql =
                    @"insert into obra
                        (valor_total, 
                        pes_cod_funcionario, 
                        pes_cod_cliente, 
                        data_inicio, 
                        data_conclusao, 
                        data_previsao, 
                        cod_status, 
                        cod_endereco, 
                        descricao
                        ) values (
                            @valor_total, 
                            @pes_cod_funcionario, 
                            @pes_cod_cliente, 
                            @data_inicio, 
                            @data_conclusao, 
                            @data_previsao, 
                            @cod_status, 
                            @cod_endereco,
                            @descricao) RETURNING COD";
            }
            else
            {
                sql =
                   @"update obra
                        set valor_total =   @valor_total, 
                        pes_cod_funcionario =  @pes_cod_funcionario, 
                        pes_cod_cliente =  @pes_cod_cliente,  
                        data_inicio =   @data_inicio,  
                        data_conclusao =   @data_conclusao,  
                        data_previsao =    @data_previsao, 
                        cod_status =    @cod_status,  
                        cod_endereco   = @cod_endereco, 
                        descricao =   @descricao
                        where cod = @cod RETURNING COD";

                    param.Add("@cod", obra.getCod());


            }

            param.Add("@valor_total", obra.getValor());
            param.Add("@pes_cod_funcionario", obra.getFuncionario().getCod());
            param.Add("@pes_cod_cliente", obra.getCliente().getCod());
            param.Add("@data_inicio", obra.getDataInicio());
            param.Add("@data_conclusao", obra.getDataFim());
            param.Add("@data_previsao", obra.getDataPrevFim());
            param.Add("@cod_status", obra.getStatus().getCod());
            param.Add("@cod_endereco", obra.getEndereco().getCod());
            param.Add("@descricao", obra.getDescricao());

            try
            {
                operacao = bd.executeNonQuery(sql, param);
                obra.setCod(bd.getUltimoCod());
            }
            catch(Exception ex)
            {

            }


            return true;
        }

        internal List<Obra> obterTodas(string rua, string nomeCliente)
        {
            string sql = @"	select  obra.cod as obra_cod,
 						valor_total, 
                        pes_cod_funcionario, 
                        pes_cod_cliente, 
                        data_inicio, 
                        data_conclusao, 
                        data_previsao, 
                        cod_status, 
                        cod_endereco, 
                        obra.descricao,
						status.descricao as status_descricao
                        from obra, status
						where cod_status = status.cod;";


            var param = bd.getParams();

            List<Model.Obra> obras = null;
            List<Model.Obra> obrasFiltrados = null;

            try
            {
                DataTable dt = bd.executeSelect(sql);

                if(dt.Rows.Count > 0)
                {
                    obras = new List<Obra>();
                    obrasFiltrados = new List<Obra>();

                    foreach (DataRow row in dt.Rows)
                    {
                        obras.Add(mapSelect(row));
                    }

                    if(rua != null || nomeCliente != null) 
                        foreach(var o in obras)
                        {
                            if(rua != null && nomeCliente != null)
                            {
                                if(o.getCliente().getNome().Contains(nomeCliente) && o.getEndereco().getRua().Contains(rua))
                                {
                                    obrasFiltrados.Add(o);
                                }
                            }
                            else if(rua != null && o.getEndereco().getRua().Contains(rua))
                            {
                                obrasFiltrados.Add(o);
                            }
                            else if(nomeCliente != null && o.getCliente().getNome().Contains(nomeCliente))
                            {
                                obrasFiltrados.Add(o);
                            }
                        }
                    else
                        foreach (var o in obras)
                        {
                            obrasFiltrados.Add(o);
                        }
                }
            }
            catch(Exception ex)
            {

            }

            return obrasFiltrados;
        }

        public Model.Obra mapSelect(DataRow row)
        {
            DatabaseAbstractionLayer.ClienteDAL clienteDAL = new DatabaseAbstractionLayer.ClienteDAL();
            DatabaseAbstractionLayer.FuncionarioDAL funcionarioDAL = new DatabaseAbstractionLayer.FuncionarioDAL();
            DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
            Model.Obra obra = new Model.Obra();
            Model.Status status = new Model.Status();


            status.setCod(Convert.ToInt32(row["cod_status"]));
            status.setDescricao(row["status_descricao"].ToString());
            obra.setStatus(status);

            obra.setCod(Convert.ToInt32(row["obra_cod"]));
            
            obra.setCliente(clienteDAL.obterUm(Convert.ToInt32(row["pes_cod_cliente"])));
            obra.setFuncionario(funcionarioDAL.obterUm(Convert.ToInt32(row["pes_cod_funcionario"])));
            obra.setEndereco(enderecoDAL.obterUm(Convert.ToInt32(row["cod_endereco"])));
            
            obra.setValor(Convert.ToInt32(row["valor_total"]));
            obra.setDataInicio(Convert.ToDateTime(row["data_inicio"]));
            obra.setDataPrevFim(Convert.ToDateTime(row["data_previsao"]));


            object dtFim = row["data_conclusao"];
            if (dtFim == DBNull.Value)
            {
                obra.setDataFim(null);
            }
            else
            {
                obra.setDataFim(Convert.ToDateTime(row["data_conclusao"]));
            }
            
            obra.setDescricao(row["descricao"].ToString());

            return obra;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class CargoDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public CargoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.Cargo cargo)
        {
            bool sucesso;
            var param = bd.getParams();
            string sql;

            if(cargo.getCod() == 0)
            {
                sql = @"insert into cargo 
                        (descricao)
                        values (@descricao) RETURNING COD;";
            }
            else
            {
                sql = @"update cargo 
                        set descricao = @descricao 
                        where cod = @cod RETURNING COD;";
            }

            param.Add("@cod", cargo.getCod());
            param.Add("@descricao", cargo.getDescricao());

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
                cargo.setCod(bd.getUltimoCod());
            }
            catch(Exception ex)
            {
                sucesso = false;
            }

            return sucesso;
        }

        public bool remover(int cod)
        {
            bool sucesso;

            var param = bd.getParams();
            string sql = @"delete from cargo  
                           where cod = @cod RETURNING COD;";

            param.Add("@cod", cod);

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
            }
            catch(Exception ex)
            {
                sucesso = false;
            }

            return sucesso;
        }


        public Model.Cargo obterUm(int cod)
        {
            Model.Cargo cargo = null;
            var param = bd.getParams();

            string sql = @"select * 
                           from cargo 
                           where cod = @cod;";

            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    cargo = map(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {

            }

            return cargo;
        }

        public List<Model.Cargo> obterTodos()
        {
            List<Model.Cargo> cargos = null;
            var param = bd.getParams();
            string sql = @"select * from cargo;";

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if(dt.Rows.Count > 0)
                {
                    cargos = new List<Model.Cargo>();

                    foreach (DataRow row in dt.Rows)
                    {
                        cargos.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {
            }


            return cargos;
        }

        internal Model.Cargo map(DataRow row)
        {
            Model.Cargo cargo = new Model.Cargo();
            cargo.setCod(Convert.ToInt32(row["cod"]));
            cargo.setDescricao(row["descricao"].ToString());
            return cargo;
        }
    }
}

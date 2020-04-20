using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ContatoDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public ContatoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.Contato contato)
        {
            bool sucesso;
            var param = bd.getParams();
            string sql;

            if (contato.getCod() == 0)
            {
                sql = @"insert into contato 
                        (ddd_padrao, numero_padrao, ddd_alt, numero_alt)
                        values (@ddd_padrao, @numero_padrao, @ddd_alt, @numero_alt)  RETURNING COD;";
                //param.Add("@cod", contato.getCod());    
            }
            else
            {
                sql = @"update contato 
                        set 
                            ddd_padrao = @ddd_padrao, 
                            numero_padrao = @numero_padrao, 
                            ddd_alt = @ddd_alt, 
                            numero_alt = @numero_alt   
                        where cod = @cod RETURNING COD;";
            }

            param.Add("@cod", contato.getCod());
            param.Add("@ddd_padrao", contato.getNumeroPadrao().getDdd());
            param.Add("@numero_padrao", contato.getNumeroPadrao().getNumero());
            param.Add("@ddd_alt", contato.getNumeroAlt().getDdd());
            param.Add("@numero_alt", contato.getNumeroAlt().getNumero());

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
                contato.setCod(bd.getUltimoCod());
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
            string sql = @"delete from contato 
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

        public Model.Contato obterUm(int cod)
        {
            Model.Contato contato = null;
            var param = bd.getParams();

            string sql = @"select cod, ddd_padrao, numero_padrao, numero_alt, ddd_alt
                           from contato 
                           where cod = @cod;";

            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    contato = map(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {

            }

            return contato;
        }

        public List<Model.Contato> obterTodos()
        {
            List<Model.Contato> cargos = null;
            var param = bd.getParams();
            string sql = @"select * from contato;";

            try
            {
                cargos = new List<Model.Contato>();
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    cargos = new List<Model.Contato>();

                    foreach (DataRow row in dt.Rows)
                    {
                        cargos.Add(map(row));
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return cargos;
        }

        internal Model.Contato map(DataRow row)
        {
            Model.Contato contato = new Model.Contato();
            Model.NumeroContato numPadrao = new Model.NumeroContato();
            Model.NumeroContato numAlt = new Model.NumeroContato();

            
            numPadrao.setDdd(row["ddd_padrao"].ToString());
            numPadrao.setNumero(row["numero_padrao"].ToString());

            object dddAlt = row["ddd_alt"];
            object numeroAlt = row["numero_alt"];

            if(dddAlt == DBNull.Value && numeroAlt == DBNull.Value)
            {
                numAlt.setDdd(null);
                numAlt.setNumero(null);
            }
            else
            {
                numAlt.setDdd(row["ddd_alt"].ToString());
                numAlt.setNumero(row["numero_alt"].ToString());
            }

            contato.setCod(Convert.ToInt32(row["cod"]));
            contato.setNumeroPadrao(numPadrao);
            contato.setNumeroAlt(numAlt);

            return contato;
        }
    }
}

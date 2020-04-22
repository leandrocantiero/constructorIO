using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class ControleAcessoDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public ControleAcessoDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public bool inserir(Model.ControleAcesso ctrAccess)
        {
            bool sucesso;
            var param = bd.getParams();
            string sql;

            if (ctrAccess.getCod() == 0)
            {
                sql = @"insert into controle_acesso 
                        (login, senha, usuario_ativo, nivel_acesso) 
                        values (@login, @senha, @usuario_ativo, @nivel_acesso) RETURNING COD;";
            }
            else
            {
                sql = @"update controle_acesso 
                        set 
                           login=@login, senha=@senha, usuario_ativo=@usuario_ativo, nivel_acesso=@nivel_acesso
                        where cod = @cod RETURNING COD;";
            }

            param.Add("@cod", ctrAccess.getCod());
            param.Add("@login", ctrAccess.getLogin());
            param.Add("@senha", ctrAccess.getSenha());
            param.Add("@usuario_ativo", ctrAccess.getUsuarioAtivo());
            param.Add("@nivel_acesso", ctrAccess.getNivelAcesso());


            try
            {
                sucesso = bd.executeNonQuery(sql, param);
                ctrAccess.setCod(bd.getUltimoCod());
            }
            catch(Exception)
            {
                sucesso = false;
            }
            return sucesso;
        }

        public bool remover(int cod)
        {
            bool sucesso;

            var param = bd.getParams();
            string sql = @"delete from controle_acesso 
                           where cod = @cod RETURNING COD;";

            param.Add("@cod", cod);

            try
            {
                sucesso = bd.executeNonQuery(sql, param);
            }
            catch(Exception)
            {
                sucesso = false;
            }

            return sucesso;
        }



        public List<Model.ControleAcesso> obterTodos()
        {
            List<Model.ControleAcesso> ctrAccess = null;
            var param = bd.getParams();

            string sql = @"select 
                                cod, login, senha, usuario_ativo, nivel_acesso
                           from controle_acesso;";

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    ctrAccess = new List<Model.ControleAcesso>();

                    foreach (DataRow row in dt.Rows)
                    {
                        ctrAccess.Add(map(row));
                    }
                }
            }
            catch(Exception)
            {

            }

            return ctrAccess;
        }

        public Model.ControleAcesso obterUm(int cod)
        {
            Model.ControleAcesso cargo = null;
            var param = bd.getParams();

            string sql = @"select cod, login, senha, usuario_ativo, nivel_acesso 
                           from controle_acesso 
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
            catch (Exception)
            {

            }

            return cargo;
        }

        public Model.ControleAcesso obterUmLogin(string login)
        {
            Model.ControleAcesso ctr = null;
            var param = bd.getParams();

            string sql = @"select cod, login, senha, usuario_ativo, nivel_acesso 
                           from controle_acesso 
                           where login = @login;";

            param.Add("@login", login);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    ctr = map(dt.Rows[0]);
                }
            }
            catch (Exception)
            {

            }

            return ctr;
        }

        


        public Model.ControleAcesso obterUmPorLoginSenha(Model.ControleAcesso ctrAccess)
        {
            Model.ControleAcesso endereco = null;
            var param = bd.getParams();

            string sql = @"select 
                                cod, login, senha, usuario_ativo, nivel_acesso 
                           from controle_acesso
                           where 
                                login = @login and senha = @senha;";

            param.Add("@login", ctrAccess.getLogin());
            param.Add("@senha", ctrAccess.getSenha());

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    endereco = map(dt.Rows[0]);
                }
            }
            catch(Exception)
            {

            }

            return endereco;
        }


        internal Model.ControleAcesso map(DataRow row)
        {
            Model.ControleAcesso ctrAccess = new Model.ControleAcesso();

            ctrAccess.setCod(Convert.ToInt32(row["cod"]));
            ctrAccess.setLogin(row["login"].ToString());
            ctrAccess.setSenha(row["senha"].ToString());
            ctrAccess.setNivelAcesso(Convert.ToInt32(row["nivel_acesso"]));
            ctrAccess.setUsuarioAtivo(Convert.ToBoolean(row["usuario_ativo"]));

            return ctrAccess;
        }


    }
}

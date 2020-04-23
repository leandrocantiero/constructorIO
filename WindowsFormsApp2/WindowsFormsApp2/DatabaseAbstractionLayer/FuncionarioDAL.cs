using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class FuncionarioDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = null;
        DatabaseAbstractionLayer.ContatoDAL contatoDAL = null;
        DatabaseAbstractionLayer.CargoDAL cargoDAL = null;
        DatabaseAbstractionLayer.ControleAcessoDAL controleAcessoDAL = null;
        

        public FuncionarioDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();

            // DALs auxiliares para (obter, remover e etc) os funcionarios
            enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
            contatoDAL = new DatabaseAbstractionLayer.ContatoDAL();
            cargoDAL = new DatabaseAbstractionLayer.CargoDAL();
            controleAcessoDAL = new DatabaseAbstractionLayer.ControleAcessoDAL();
        }

        public bool inserir(Model.Funcionario funcionario)
        {
            bool sucesso;
            var param = bd.getParams();
            string sql;

            if (funcionario.getCod() == 0)
            {
                sql = @"insert into funcionario(dt_demissao, cod_controle_acesso, dt_admissao, 
						cod_cargo, nome, registro, dtnasc, cod_endereco, cod_contato)
						values 
                            (@dt_demissao, 
                            @cod_controle_acesso, 
                            @dt_admissao, 
                            @cod_cargo, 
                            @nome, 
                            @registro, 
                            @dtnasc, 
                            @cod_endereco, 
                            @cod_contato
                        ) RETURNING PES_COD;";
            }
            else
            {
                sql = @"update funcionario 
                        set 
                            dt_demissao = @dt_demissao, 
                            cod_controle_acesso = @cod_controle_acesso, 
                            dt_admissao = @dt_admissao, 
                            cod_cargo = @cod_cargo, 
                            nome = @nome, 
                            registro = @registro, 
                            dtnasc = @dtnasc, 
                            cod_endereco = @cod_endereco, 
                            cod_contato = @cod_contato 
                        where pes_cod = @pes_cod RETURNING PES_COD;";
            }

            param.Add("@pes_cod", funcionario.getCod());
            param.Add("@dt_demissao", funcionario.getDtDemissao());
            param.Add("@dtnasc", funcionario.getDtNascimento());
            param.Add("@dt_admissao", funcionario.getDtAdmissao());
            param.Add("@nome", funcionario.getNome());
            param.Add("@registro", funcionario.getRegistro());

            try
            {
                // cria novos obj para atualizar o "COD" por referência;
                Model.Endereco endereco = funcionario.getEndereco();
                Model.Contato contato = funcionario.getContato();
                //Model.Cargo cargo = funcionario.getCargo();
                Model.ControleAcesso ctrAccess = funcionario.getControleAcesso();

                //int codEnd = endereco.getCod();
                //int codContato = contato.getCod();
                //int codControleAcesso = ctrAccess.getCod();

                // inserir na tabelas que faz referência a tabela funcionario
                sucesso = enderecoDAL.inserir(endereco);
                
                if(sucesso)
                    sucesso=contatoDAL.inserir(contato);
                //cargoDAL.inserir(cargo);
                if(sucesso)
                    sucesso= controleAcessoDAL.inserir(ctrAccess);

                if(sucesso)
                {
                    // atualizar obj "Model.Funcionario funcionario"
                    funcionario.setEndereco(endereco);
                    funcionario.setContato(contato);
                    //funcionario.setCargo(cargo);
                    funcionario.setControleAcesso(ctrAccess);

                    // add as fk
                    param.Add("@cod_cargo", funcionario.getCargo().getCod());
                    param.Add("@cod_controle_acesso", funcionario.getControleAcesso().getCod());
                    param.Add("@cod_endereco", funcionario.getEndereco().getCod());
                    param.Add("@cod_contato", funcionario.getContato().getCod());


                    // inserir de fato o "funcionario" ja com os objetos atualizados
                    sucesso = bd.executeNonQuery(sql, param);
                    funcionario.setCod(bd.getUltimoCod());
                }
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
            string sql = @"delete from funcionario  
                           where pes_cod = @cod RETURNING pes_cod;";

            param.Add("@cod", cod);

            try
            {
                Model.Funcionario funcionario = this.obterUm(cod);
                if(funcionario != null)
                {
                    // remover na tabelas que faz referência a tabela funcionario
                    
                    sucesso = bd.executeNonQuery(sql, param);
                    
                    if(sucesso)
                        sucesso = enderecoDAL.remover(funcionario.getEndereco().getCod());
                    if (sucesso)
                        sucesso = contatoDAL.remover(funcionario.getContato().getCod());
                    //if(sucesso)
                    //    sucesso=cargoDAL.remover(funcionario.getCargo().getCod());
                    if (sucesso)
                        sucesso = controleAcessoDAL.remover(funcionario.getControleAcesso().getCod());
                }
                else
                {
                    sucesso = false;
                    MessageBox.Show("Há registro associados.");
                }
            }
            catch (Exception)
            {
                sucesso = false;
                MessageBox.Show("Problema no banco");
            }

            return sucesso;
        }

        public List<Model.Funcionario> obterTodos(string nome = null, string registro = null)
        {
            List<Model.Funcionario> funcionarios = null;
            var param = bd.getParams();

            string sql = @"select
                                pes_cod
                                pes_cod, 
                                cod_controle_acesso, 
                                cod_cargo, 
                                dt_demissao, 
                                dt_admissao, 
                                nome, 
                                registro, 
                                dtnasc, 
                                cod_endereco, 
                                cod_contato
                           from funcionario ";

            if(nome != null || registro != null)
            {
                sql += " where ";

                if(nome != null)
                {
                    sql += " nome like @nome";
                    param.Add("@nome", "%" + nome + "%");
                }

                if(registro != null)
                {
                    if (nome != null) sql += " and ";
                    sql += " registro like @registro;";
                    param.Add("@registro", "%" + registro + "%");
                }

            }
            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    funcionarios = new List<Model.Funcionario>();

                    foreach (DataRow row in dt.Rows)
                    {
                        funcionarios.Add(map(row));
                    }
                }
            }
            catch(Exception)
            {

            }

            return funcionarios;
        }

        public Model.Funcionario obterUm(int cod)
        {
            Model.Funcionario funcionario = null;
            var param = bd.getParams();

            string sql = @"select 
                                pes_cod, 
                                cod_controle_acesso, 
                                cod_cargo, 
                                dt_demissao, 
                                dt_admissao, 
                                nome, 
                                registro, 
                                dtnasc, 
                                cod_endereco, 
                                cod_contato
                           from funcionario 
                           where pes_cod = @cod";

            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    funcionario = map(dt.Rows[0]);
                }
            }
            catch(Exception)
            {

            }

            return funcionario;
        }

        public Model.Funcionario obterUmPorEmailSenha(string login, string senha)
        {
            Model.Funcionario funcionario = null;
            var param = bd.getParams();

            string sql = @"select 
                                pes_cod, 
                                cod_controle_acesso, 
                                cod_cargo, 
                                dt_demissao, 
                                dt_admissao, 
                                nome, 
                                registro, 
                                dtnasc, 
                                cod_endereco, 
                                cod_contato,

                                controle_acesso.cod as ctr_cod,
                                login,
                                senha,
                                usuario_ativo,
                                nivel_acesso
                           from funcionario, controle_acesso
                           where 
                                 controle_acesso.cod = funcionario.cod_controle_acesso and
                                 login = @login and
                                 senha = @senha";

            param.Add("@login", login);
            param.Add("@senha", senha);


            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    funcionario = mapLoginSenha(dt.Rows[0]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return funcionario;
        }

        internal Model.Funcionario mapLoginSenha(DataRow row)
        {
            // cria novos obj para atualizar por referência;
            Model.Funcionario funcionario = new Model.Funcionario();
            Model.Endereco endereco = null;
            Model.Contato contato = null;
            Model.Cargo cargo = null;
            Model.ControleAcesso ctrAccess = new Model.ControleAcesso();


            //setar controle acesso
            ctrAccess.setCod(Convert.ToInt32(row["ctr_cod"]));
            ctrAccess.setLogin(row["login"].ToString());
            ctrAccess.setSenha(row["senha"].ToString());
            ctrAccess.setUsuarioAtivo(Convert.ToBoolean(row["ctr_cod"]));
            ctrAccess.setNivelAcesso(Convert.ToInt32(row["nivel_acesso"]));

            // obter das tabelas que faz referência a tabela funcionario
            //endereco = enderecoDAL.obterUm(Convert.ToInt32(row["cod_endereco"]));
            //contato = contatoDAL.obterUm(Convert.ToInt32(row["cod_contato"]));
            //cargo = cargoDAL.obterUm(Convert.ToInt32(row["cod_cargo"]));
            ctrAccess = controleAcessoDAL.obterUm(Convert.ToInt32(row["cod_controle_acesso"]));

            // atualizar obj "Model.Funcionario funcionario"
            funcionario.setEndereco(endereco);
            funcionario.setContato(contato);
            funcionario.setCargo(cargo);
            funcionario.setControleAcesso(ctrAccess);

            //atualizar resto do obj funcionario
            funcionario.setCod(Convert.ToInt32(row["pes_cod"]));
            //funcionario.setDtAdmissao(Convert.ToDateTime(row["dt_admissao"]));

            object dtdemissao = row["dt_demissao"];
            if (dtdemissao == DBNull.Value)
            {
                funcionario.setDtDemissao(null);
            }
            else
            {
                funcionario.setDtDemissao(Convert.ToDateTime(row["dt_demissao"]));
            }

            try
            {
                funcionario.setCod(Convert.ToInt16(row["pes_cod"]));
            }
            catch (Exception)
            {
                funcionario.setCod(0);
            }

            funcionario.setNome(row["nome"].ToString());
            funcionario.setRegistro(row["registro"].ToString());
            funcionario.setDtNascimento(Convert.ToDateTime(row["dtnasc"]));

            return funcionario;
        }


        internal Model.Funcionario map(DataRow row)
        {
            // cria novos obj para atualizar por referência;
            Model.Funcionario funcionario = new Model.Funcionario();
            Model.Endereco endereco = null;
            Model.Contato contato = null;
            Model.Cargo cargo = null;
            Model.ControleAcesso ctrAccess = null;

            // obter das tabelas que faz referência a tabela funcionario
            endereco = enderecoDAL.obterUm(Convert.ToInt32(row["cod_endereco"]));
            contato = contatoDAL.obterUm(Convert.ToInt32(row["cod_contato"]));
            cargo = cargoDAL.obterUm(Convert.ToInt32(row["cod_cargo"]));
            ctrAccess = controleAcessoDAL.obterUm(Convert.ToInt32(row["cod_controle_acesso"]));

            // atualizar obj "Model.Funcionario funcionario"
            funcionario.setEndereco(endereco);
            funcionario.setContato(contato);
            funcionario.setCargo(cargo);
            funcionario.setControleAcesso(ctrAccess);

            //atualizar resto do obj funcionario
            funcionario.setCod(Convert.ToInt32(row["pes_cod"]));
            //funcionario.setDtAdmissao(Convert.ToDateTime(row["dt_admissao"]));

            object dtdemissao = row["dt_demissao"];
            if(dtdemissao == DBNull.Value)
            {
                funcionario.setDtDemissao(null);
            }
            else
            {
                funcionario.setDtDemissao(Convert.ToDateTime(row["dt_demissao"]));
            }

            try
            {
                funcionario.setCod(Convert.ToInt16(row["pes_cod"]));
            }
            catch (Exception)
            {
                funcionario.setCod(0);
            }

            funcionario.setNome(row["nome"].ToString());
            funcionario.setRegistro(row["registro"].ToString());
            funcionario.setDtNascimento(Convert.ToDateTime(row["dtnasc"]));

            return funcionario;
        }

    }
}

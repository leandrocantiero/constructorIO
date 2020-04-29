using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    class ClienteDAL
    {
        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        DatabaseAbstractionLayer.EnderecoDAL enderecoDAL = null;
        DatabaseAbstractionLayer.ContatoDAL contatoDAL = null;

        public ClienteDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();

            // DALs auxiliares para (obter, remover e etc) os clientes
            enderecoDAL = new DatabaseAbstractionLayer.EnderecoDAL();
            contatoDAL = new DatabaseAbstractionLayer.ContatoDAL();
        }

        public bool inserir(Model.Cliente cliente)
        {
            bool sucesso;
            var param = bd.getParams();
            string sql;

            if (cliente.getCod() == 0)
            {
                sql = @"insert into cliente(nome, registro, email, dtnasc, ativo, cod_endereco, cod_contato)
						values 
                            (@nome, 
                            @registro,
                            @email,
                            @dtnasc, 
                            @ativo, 
                            @cod_endereco, 
                            @cod_contato
                        ) RETURNING PES_COD;";
            }
            else
            {
                sql = @"update cliente 
                        set 
                            nome = @nome,
                            registro = @registro,
                            email = @email,
                            dtnasc = @dtnasc, 
                            ativo = @ativo, 
                            cod_endereco = @cod_endereco, 
                            cod_contato = @cod_contato 
                        where pes_cod = @pes_cod RETURNING PES_COD;";
            }

            param.Add("@pes_cod", cliente.getCod());
            param.Add("@dtnasc", cliente.getDtNascimento());
            param.Add("@nome", cliente.getNome());
            param.Add("@registro", cliente.getRegistro());
            param.Add("@email", cliente.getEmail());
            param.Add("@ativo", cliente.getAtivo());

            try
            {
                // cria novos obj para atualizar o "COD" por referência;
                Model.Endereco endereco = cliente.getEndereco();
                Model.Contato contato = cliente.getContato();

                // inserir na tabelas que faz referência a tabela cliente
                sucesso = enderecoDAL.inserir(endereco);

                if (sucesso)
                    sucesso = contatoDAL.inserir(contato);
                if (sucesso)
                {
                    // atualizar obj "Model.Cliente cliente"
                    cliente.setEndereco(endereco);
                    cliente.setContato(contato);

                    // add as fk
                    param.Add("@cod_endereco", cliente.getEndereco().getCod());
                    param.Add("@cod_contato", cliente.getContato().getCod());


                    // inserir de fato o "cliente" ja com os objetos atualizados
                    sucesso = bd.executeNonQuery(sql, param);
                    cliente.setCod(bd.getUltimoCod());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sucesso = false;
            }

            return sucesso;
        }


        public bool remover(int cod)
        {
            bool sucesso;

            var param = bd.getParams();
            string sql = @"delete from cliente  
                           where pes_cod = @cod RETURNING pes_cod;";

            param.Add("@cod", cod);

            try
            {
                Model.Cliente cliente = this.obterUm(cod);
                if (cliente != null)
                {
                    // remover na tabelas que faz referência a tabela cliente

                    sucesso = bd.executeNonQuery(sql, param);

                    if (sucesso)
                        sucesso = enderecoDAL.remover(cliente.getEndereco().getCod());
                    if (sucesso)
                        sucesso = contatoDAL.remover(cliente.getContato().getCod());
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

        public List<Model.Cliente> obterTodos(string nome = null, string registro = null)
        {
            List<Model.Cliente> clientes = null;
            var param = bd.getParams();

            string sql = @"select * from cliente ";

            if (nome != "" || registro != "")
            {
                sql += " where ";

                if (nome != "")
                {
                    sql += " nome ilike @nome";
                    param.Add("@nome", "%" + nome + "%");
                }

                if (registro != "")
                {
                    if (nome != "") sql += " and ";
                    sql += " registro ilike @registro;";
                    param.Add("@registro", "%" + registro + "%");
                }

            }
            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    clientes = new List<Model.Cliente>();

                    foreach (DataRow row in dt.Rows)
                    {
                        clientes.Add(map(row));
                    }
                }
            }
            catch (Exception)
            {

            }

            return clientes;
        }

        public Model.Cliente obterUm(int cod)
        {
            Model.Cliente cliente = null;
            var param = bd.getParams();

            string sql = @"select * from cliente where pes_cod = @cod";

            param.Add("@cod", cod);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    cliente = map(dt.Rows[0]);
                }
            }
            catch (Exception)
            {

            }

            return cliente;
        }


        internal Model.Cliente map(DataRow row)
        {
            // cria novos obj para atualizar por referência;
            Model.Cliente cliente = new Model.Cliente();
            Model.Endereco endereco = null;
            Model.Contato contato = null;

            // obter das tabelas que faz referência a tabela cliente
            endereco = enderecoDAL.obterUm(Convert.ToInt32(row["cod_endereco"]));
            contato = contatoDAL.obterUm(Convert.ToInt32(row["cod_contato"]));

            // atualizar obj "Model.Cliente cliente"
            cliente.setEndereco(endereco);
            cliente.setContato(contato);

            //atualizar resto do obj cliente
            cliente.setCod(Convert.ToInt32(row["pes_cod"]));
            //cliente.setDtAdmissao(Convert.ToDateTime(row["dt_admissao"]));

            try
            {
                cliente.setCod(Convert.ToInt16(row["pes_cod"]));
            }
            catch (Exception)
            {
                cliente.setCod(0);
            }

            cliente.setNome(row["nome"].ToString());
            cliente.setDtNascimento(Convert.ToDateTime(row["dtnasc"]));
            cliente.setRegistro(row["registro"].ToString());
            cliente.setEmail(row["email"].ToString());
            cliente.setAtivo(Convert.ToBoolean(row["ativo"]));

            return cliente;
        }

    }
}

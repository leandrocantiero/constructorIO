using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.DatabaseAbstractionLayer
{
    public class MaterialDAL
    {

        DatabaseAbstractionLayer.PostgreSQLPersistence bd;

        public MaterialDAL()
        {
            bd = new DatabaseAbstractionLayer.PostgreSQLPersistence();
        }

        public List<Model.Material> obterTodas(string nome = null)
        {
            List<Model.Material> materiais = null;
            string sql = @" select 
                                material.cod as material_cod, 
                                cod_categoria_mat, 
                                unidade, 
                                material.descricao as descricao_mat, 
                                estoque, 
                                nome, 
                                valor,
                                categoria_mat.descricao as descricao_cat
                            from 
                                material, categoria_mat
                            where 
	                            cod_categoria_mat = categoria_mat.cod ";
            var param = bd.getParams();
            

            if (nome != null)
            {
                sql += " and nome like @nome ";
                param.Add("@nome", "%" + nome + "%");
            }

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    materiais = new List<Model.Material>();

                    foreach (DataRow row in dt.Rows)
                    {
                        materiais.Add(map(row));
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return materiais;
        }

        public bool atualizar(Material material)
        {
            bool operacao;
            string sql = @"UPDATE public.material
	                        SET 
                                cod_categoria_mat=@cod_categoria_mat, 
                                unidade=@unidade, 
                                descricao=@descricao, 
                                estoque=@estoque, 
                                nome=@nome, 
                                valor=@valor
	                        WHERE cod=@cod RETURNING cod";

            var param = bd.getParams();

            param.Add("@cod_categoria_mat", material.getCategoria().getCod());
            param.Add("@cod", material.getCod());
            param.Add("@unidade", material.getUnidade());
            param.Add("@descricao", material.getDescricao());
            param.Add("@estoque", material.getEstoque());
            param.Add("@nome", material.getNome());
            param.Add("@valor", material.getValor());

            try
            {
                operacao = bd.executeNonQuery(sql, param);
                material.setCod(bd.getUltimoCod());
                operacao = true;

            }
            catch(Exception ex)
            {
                operacao = false;
            }

            return operacao;

        }

        public Model.Material obterUm(int codMaterial)
        {
            Model.Material material = null;
            string sql = @" select 
                                material.cod as material_cod, 
                                cod_categoria_mat, 
                                unidade, 
                                material.descricao as descricao_mat, 
                                estoque, 
                                nome, 
                                valor,
                                categoria_mat.descricao as descricao_cat
                            from 
                                material, categoria_mat
                            where 
	                            cod_categoria_mat = categoria_mat.cod and
                                material.cod = @cod";
            var param = bd.getParams();
            param.Add("@cod", codMaterial);

            try
            {
                DataTable dt = bd.executeSelect(sql, param);

                if (dt.Rows.Count > 0)
                {
                    material = new Model.Material();

                    material = map(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {

            }

            return material;
        }

        internal Model.Material map(DataRow row)
        {
            Model.Material material = new Model.Material();
            Model.Categoria categoria= new Model.Categoria();

            categoria.Cod = Convert.ToInt32(row["cod_categoria_mat"]);
            categoria.Descricao = row["descricao_cat"].ToString();
            material.setCategoria(categoria);

            material.Cod = Convert.ToInt32(row["material_cod"]);
            material.Descricao = row["descricao_mat"].ToString();
            material.Unidade = row["unidade"].ToString();
            material.Estoque = Convert.ToInt32(row["estoque"]);
            material.Valor = Convert.ToDecimal(row["valor"]);
            material.Nome = row["nome"].ToString();

            return material;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sql = @"select material.cod as material_cod, 
                            cod_categoria_mat, 
                            unidade, 
                            descricao, 
                            estoque, 
                            nome, 
                            valor,
                            categoria.descricao as descricao_cat
                           from material, categoria_mat
                            where categoria_mat.cod = cod_categoria_mat";
            var param = bd.getParams();
            

            if (nome != null)
            {
                sql += " where ";
                sql += " nome like @nome";
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

        internal Model.Material map(DataRow row)
        {
            Model.Material material = new Model.Material();
            Model.Categoria categoria= new Model.Categoria();

            categoria.Cod = Convert.ToInt32(row["cod_categoria_mat"]);
            categoria.Descricao = row["descricao_cat"].ToString();

            material.Cod = Convert.ToInt32(row["material_cod"]);
            material.Descricao = row["descricao"].ToString();
            material.Estoque = Convert.ToInt32(row["estoque"]);
            material.Valor = Convert.ToDecimal(row["valor"]);
            material.Nome = row["nome"].ToString();

            return material;
        }
    }
}

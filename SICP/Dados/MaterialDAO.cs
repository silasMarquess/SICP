using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICP.Entidades;
using MySql.Data.MySqlClient;
using SICP.Entidades.enums;


namespace SICP.Dados
{
    class MaterialDAO
    {
       public static void InsertNewMaterial(MatConstrucao mat)
        {
            string query = "insert into tb_matconst(cod,descricao,valcusto,vallucro,tipomat,estoque) " +
                "values(@cod,@descricao,@valcusto,@vallucro,@tipomat,@estoque)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", mat.Cod);
            cmd.Parameters.AddWithValue("@descricao", mat.Descricao);
            cmd.Parameters.AddWithValue("@valcusto", mat.Custo);
            cmd.Parameters.AddWithValue("@vallucro", mat.ValLucro);
            cmd.Parameters.AddWithValue("@tipomat", (int)mat.Tipo);
            cmd.Parameters.AddWithValue("@estoque", mat.QtdeEstoque);
            cmd.ExecuteNonQuery();
        }


        public static List<MatConstrucao> GetListaMaterial()
        {
            List<MatConstrucao> lista = new List<MatConstrucao>();
            string query = "select * from tb_matconst";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                string descricao = read.GetString("descricao");
                string codigp = read.GetString("codigo");
                decimal custo = read.GetDecimal("valcusto");
                decimal lucro = read.GetDecimal("lucro");
                TipoMaterial tipo = (TipoMaterial)read.GetInt16("tipo");
                int estoque = read.GetInt16("estoque");
                lista.Add(new MatConstrucao(codigp, descricao, custo, lucro, tipo));
            }
            return lista;
        }

        public static void UpdateEstoqueMat(MatConstrucao mat)
        {
            string query = "update tb_matconst set estoque =@estoque where cod =@codigo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigo", mat.Cod);
            cmd.Parameters.AddWithValue("@estoque", mat.QtdeEstoque);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateInfoMat(MatConstrucao mat)
        {
            string query = "update tb_matconst set descricao =@desc, valcusto =@custo, vallucro =@lucro," +
                "tipomat=tipo,estoque = @estoque where cod =@cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", mat.Cod);
            cmd.Parameters.AddWithValue("@descricao", mat.Descricao);
            cmd.Parameters.AddWithValue("@valcusto", mat.Custo);
            cmd.Parameters.AddWithValue("@vallucro", mat.ValLucro);
            cmd.Parameters.AddWithValue("@tipomat", (int)mat.Tipo);
            cmd.Parameters.AddWithValue("@estoque", mat.QtdeEstoque);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteMat(MatConstrucao mat)
        {
            string query = "delete * from tb_matconst where cod =@cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", mat.Cod);
            cmd.ExecuteNonQuery();
        }

        public static bool VerificaSeMatExist(MatConstrucao mat)
        {
            string query = "select * from tb_matConst where descricao = @descricao";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            MySqlDataReader r = cmd.ExecuteReader();
            return (r.Read()) ? true : false;
        }
    }
}

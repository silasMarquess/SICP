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
                string codigp = read.GetString("cod");
                decimal custo = read.GetDecimal("valcusto");
                decimal lucro = read.GetDecimal("vallucro");
                TipoMaterial tipo = (TipoMaterial)read.GetInt16("tipomat");
                int estoque = read.GetInt16("estoque");
                lista.Add(new MatConstrucao(codigp, descricao, custo, lucro, tipo,estoque));
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
            string query = "update tb_matconst set descricao =  @desc, valcusto = @custo, vallucro =@lucro, " +
                "tipomat=@tipo, estoque = @estoque where cod =@cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", mat.Cod);
            cmd.Parameters.AddWithValue("@desc", mat.Descricao);
            cmd.Parameters.AddWithValue("@custo", mat.Custo);
            cmd.Parameters.AddWithValue("@lucro", mat.ValLucro);
            cmd.Parameters.AddWithValue("@tipo", (int)mat.Tipo);
            cmd.Parameters.AddWithValue("@estoque", mat.QtdeEstoque);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteMat(MatConstrucao mat)
        {
            string query = "delete from tb_matconst where cod =@cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", mat.Cod);
            cmd.ExecuteNonQuery();
        }

        public static bool VerificaSeMatExist(MatConstrucao mat)
        {
            string query = "select * from tb_matConst where descricao = @descricao";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@descricao", mat.Descricao);
            MySqlDataReader r = cmd.ExecuteReader();
            return (r.Read()) ? true : false;
        }

        public static bool VerificaSeCodeExist(string codigo)
        {
            string query = "select cod from tb_MatConst where cod=@codigo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader rd = cmd.ExecuteReader();
            return (rd.Read()) ? true : false;

        }

       /* public static void InsertMarcaCimento(MarcaCimento m)
        {
            string query = "insert into tb_marcaCimento(nome) values(@nomd)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome",m.Nome);
            cmd.ExecuteNonQuery();

        }

        public static void UpdateMarcaCimento(MarcaCimento m)
        {
            string query = "update tb_marcaCimento set nome =@nome " +
                "where id = @id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", m.Nome);
            cmd.Parameters.AddWithValue("@id", m.Id);
            cmd.ExecuteNonQuery();
        }

        public static List<MarcaCimento> GetListaMarcaCimento()
        {
            List<MarcaCimento> lista = new List<MarcaCimento>();
            string query = "select * from tb_marcaCimento";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int id = rd.GetInt32("id");
                string nome = rd.GetString("nome");
                MarcaCimento marca = new MarcaCimento(id, nome);
                lista.Add(marca);
            }
            return lista;
        }


        public static void DeleteMarcaCimento(MarcaCimento m)
        {
            string query = "delete from tb_marcaCimento where id = @id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", m.Id);
            cmd.ExecuteNonQuery();
        }


        public static bool VerificaSeMarcaCimentoJaExiste(MarcaCimento marca)
        {
            string query = "select * from tb_marcaCimento where nome =@nome";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            MySqlDataReader rd = cmd.ExecuteReader();
            return (rd.Read()) ? true : false;
        }*/
    }
}

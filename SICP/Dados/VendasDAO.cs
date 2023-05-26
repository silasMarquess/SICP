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
    class VendasDAO
    {

        //inserindo novas Vendas
        public static void InsertNewVenda(Venda v)
        {
            string query = "insert into tb_venda(codVenda, TotalVenda,desconto,adicional,cliente,data)" +
                " values(@codVenda, @TotalVenda,@desconto,@adicional,@cliente, @data)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codVenda", v.Codigo);
            cmd.Parameters.AddWithValue("@totalVenda", v.CalculaTotalBruto());
            cmd.Parameters.AddWithValue("@desconto", v.Desconto);
            cmd.Parameters.AddWithValue("@adicional", v.Adicional);
            cmd.Parameters.AddWithValue("@cliente", v.Cliente);
            cmd.Parameters.AddWithValue("@data", v.Data);
            cmd.ExecuteNonQuery();
        }

       
        public static void InsertItemsToVenda(Venda v)
        {
            string query = "insert into tb_item(qtde,codMat,codVenda) " +
                "values(@qtde,@codMat,@codVenda)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);

            foreach (Item i in v.ListaItens) 
            {
                cmd.Parameters.AddWithValue("@qtde", i.Qtde);
                cmd.Parameters.AddWithValue("@codMat", i.Produto.Cod);
                cmd.Parameters.AddWithValue("@codVenda",v.Codigo);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateVenda(Venda v)
        {
            string query = "update tb_venda set totalVenda = @Venda, desconto =@desconto, adicional = @adicional, cliente = @cliente " +
                "where codVenda =@codigoVenda";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoVenda", v.Codigo);
            cmd.Parameters.AddWithValue("@Venda", v.CalculaTotalLiquido());
            cmd.Parameters.AddWithValue("@desconto", v.Desconto);
            cmd.Parameters.AddWithValue("@adicional", v.Adicional);
            cmd.Parameters.AddWithValue("@cliente", v.Cliente);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteVenda(Venda v)
        {
            string query = "delete from tb_venda where codVenda =@codigoVenda";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoVenda",v.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static List<Venda> GetListaVendas()
        {
            List<Venda> lista = new List<Venda>();
            string query = "select * from tb_venda";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            // cmd.Parameters.AddWithValue("")
            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                string codVenda = r.GetString("codVenda");
                decimal totalVenda = r.GetDecimal("totalVenda");
                decimal desconto = r.GetDecimal("desconto");
                decimal adicional = r.GetDecimal("adicional");
                string cliente = r.GetString("cliente");
                DateTime data = r.GetDateTime("data");
                Venda v = new Venda(codVenda, totalVenda, desconto, adicional, cliente,data);
                lista.Add(v);
            }
            return lista;
        }

        public static void getItensForVenda(Venda v)
        {
            string query = "select i.*, m.* " +
                " from tb_item  as i " +
                "INNER JOIN tb_matConst as m " +
                " on i.codMat = m.cod " +
                "where i.codVenda = @CodVenda";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@CodVenda", v.Codigo);
            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                int id = read.GetInt32("id");
                int qtde = read.GetInt32("qtde");


                string codigoMat = read.GetString("cod");
                string descricao = read.GetString("descricao");
                decimal valorCusto = read.GetDecimal("Valcusto");
                decimal valorlucro = read.GetDecimal("vallucro");
                TipoMaterial tipoMat = (TipoMaterial)read.GetInt32("tipoMat");
                int Estoque = read.GetInt32("estoque");
                MatConstrucao mat = new MatConstrucao(codigoMat, descricao, valorCusto, valorlucro, tipoMat,Estoque);
                v.AddNewItem(new Item(id, qtde, mat));
            }
        }


        public static bool VerificaSeCodVendaExist(string codigo)
        {
            string query = "select * from tb_venda where codVenda = @venda";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@venda", codigo);
            MySqlDataReader rd = cmd.ExecuteReader();
            return (rd.Read()) ? true : false;
        }
    }
}

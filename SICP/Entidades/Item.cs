using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICP.Entidades
{
   public class Item
    {
        public int Id { get; set; }
        public int Qtde { get; set; }
        public MatConstrucao Produto { get; set; }

        public Item(int id, int qtde, MatConstrucao produto)
        {
            Id = id;
            Qtde = qtde;
            Produto = produto;
        }

        public decimal SubTotal()
        {
            decimal valorVenda = Produto.CalculaValorVenda();
            return (valorVenda * Qtde);
        }

        public decimal CalculaLucro()
        {
            decimal Valor = 0;
            if (Produto.ValLucro > 0)
            {
                Valor = Produto.ValLucro* Qtde;

            }
            else
            {
                Valor = Produto.Custo * Qtde;
            }
            return Valor;
        }
    }
}

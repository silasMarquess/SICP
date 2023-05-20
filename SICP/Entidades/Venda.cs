using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICP.Entidades
{
    class Venda
    {
        public string Codigo { get; set; }
        public decimal Total { get; private set; }
        public decimal Desconto { get; set; }
        public decimal Adicional { get; set; }
        public string Cliente { get; set; }
        public List<Item> ListaItens { get; private set; } = new List<Item>();



        public Venda(string codigo, decimal total, decimal desconto, decimal adicional, string cliente)
        {
            Codigo = codigo;
            Total = total;
            Desconto = desconto;
            Adicional = adicional;
            Cliente = cliente;
        }

        public void AddNewItem(Item i)
        {
            ListaItens.Add(i);
        }

        public decimal CalculaTotalBruto()
        {
            decimal valor = 0;
            foreach(Item i in ListaItens)
            {
                valor += i.SubTotal();
            }
            return valor;
        }

        public decimal CalculaTotalLiquido()
        {
            return (Total + Adicional) - Desconto;
        }

        public decimal CalculaTotalLucro()
        {
            decimal valor = 0;
            foreach(Item i in ListaItens)
            {
                valor += i.CalculaLucro();
            }

            valor += Adicional - Desconto;
            return valor;
        }



    }
}

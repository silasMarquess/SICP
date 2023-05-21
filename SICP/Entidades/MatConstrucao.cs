using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICP.Entidades.enums;

namespace SICP.Entidades
{
    class MatConstrucao
    {
        public string Cod { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal ValLucro  { get;  set; }
        public TipoMaterial Tipo { get; set; }
        public int QtdeEstoque { get; set; }


        public MatConstrucao(string cod, string descricao, decimal custo, decimal taxaLucro, TipoMaterial tipo)
        {
            Cod = cod;
            Descricao = descricao;
            Custo = custo;
            ValLucro = taxaLucro;
            Tipo = tipo;
        }

        public MatConstrucao()
        {
                
        }

        public decimal CalculaValorLucro(decimal taxaLucro)
        {
            return (taxaLucro / 100) * Custo;
        }

        public decimal CalculaValorVenda()
        {
            return Custo + ValLucro;
        }

        public void AddEstoque(int qtde)
        {
            QtdeEstoque += qtde;
        }

        public void RemoveEstoque(int qtde)
        {
            QtdeEstoque -= qtde;
        }

    }
}

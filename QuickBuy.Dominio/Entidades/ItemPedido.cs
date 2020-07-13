using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidades
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0) AdicionarCritica("Não foi identificado qual a referência do produto");
            if (Quantidade == 0) AdicionarCritica("Quantidade não foi informada");
        }
    }
}

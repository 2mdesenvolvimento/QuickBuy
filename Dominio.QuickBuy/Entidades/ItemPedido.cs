using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.QuickBuy.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if(ProdutoId == 0)
            {
                AdicionarMsgAtencao("Não foi identificado qual a referência do produto");
            }
            if(Quantidade == 0)
            {
                AdicionarMsgAtencao("Quantidade não foi informado");
            }
        }
    }
}

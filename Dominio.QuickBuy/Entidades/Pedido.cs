using Dominio.QuickBuy.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Dominio.QuickBuy.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EndCompleto { get; set; }
        public int NumEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        public ICollection<ItemPedido> ItemPedido { get; set; }

        public override void Validate()
        {
            LimparMsgValidacao();
            if (!ItemPedido.Any())
            {
                AdicionarMsgAtencao("Atenção: Pedido não pode ser vazio o item.");
            }
            if (string.IsNullOrEmpty(Cep))
            {
                AdicionarMsgAtencao("Atenção: Cep deve está preenchido.");
            }
            if (FormaPagamentoId == 0)
            {
                AdicionarMsgAtencao("Atenção: Não foi informado a forma de pagamento.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.QuickBuy.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMsgAtencao("Não foi informado nome");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarMsgAtencao("Não foi informado a descrição");
            }
            if (Preco == 0)
            {
                AdicionarMsgAtencao("Preço não foi informado");
            }
        }
    }
}

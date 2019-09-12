using Dominio.QuickBuy.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.QuickBuy.ObjetodeValor
{
    public class FormaPagamento
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }


        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool EhNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.QuickBuy.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMsgValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMsgAtencao(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}

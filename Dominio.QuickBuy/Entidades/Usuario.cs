using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.QuickBuy.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public ICollection<Pedido> Pedido { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarMsgAtencao("Não foi informado o Email");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarMsgAtencao("Não foi informado a senha");
            }
        }
    }
}

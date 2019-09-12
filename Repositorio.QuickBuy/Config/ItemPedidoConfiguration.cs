using Dominio.QuickBuy.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.QuickBuy.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProdutoId)
                                   .IsRequired();
            builder.Property(p => p.Quantidade)
                                   .IsRequired()
                                   .HasMaxLength(999999);
        }
    }
}

using Dominio.QuickBuy.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.QuickBuy.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.EndCompleto)
                                   .IsRequired()
                                   .HasMaxLength(100);
            builder.Property(p => p.NumEndereco)
                                   .IsRequired()
                                   .HasMaxLength(10000);
            builder.Property(p => p.Cep)
                                   .IsRequired()
                                   .HasMaxLength(15);
            builder.Property(p => p.Cidade)
                                   .IsRequired()
                                   .HasMaxLength(150);
            builder.Property(p => p.DataPedido)
                                   .IsRequired()
                                   .HasMaxLength(10);
            builder.Property(p => p.DataPrevEntrega)
                                   .IsRequired()
                                   .HasMaxLength(10);
            builder.Property(p => p.FormaPagamento)
                                   .IsRequired()
                                   .HasMaxLength(30);
        }
    }
}

using Dominio.QuickBuy.ObjetodeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.QuickBuy.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.Property(p => p.Descricao)
                       .IsRequired()
                       .HasMaxLength(250);
        }
    }
}

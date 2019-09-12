using Dominio.QuickBuy.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.QuickBuy.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Email)
                                   .IsRequired()
                                   .HasMaxLength(100);
            builder.Property(p => p.Nome)
                                   .IsRequired()
                                   .HasMaxLength(250);
            builder.Property(p => p.Sobrenome)
                                   .IsRequired()
                                   .HasMaxLength(250);
            builder.Property(p => p.Senha)
                                   .IsRequired()
                                   .HasMaxLength(400);
        }
    }
}

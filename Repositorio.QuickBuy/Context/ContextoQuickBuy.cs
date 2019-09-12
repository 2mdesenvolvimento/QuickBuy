using Dominio.QuickBuy.Entidades;
using Dominio.QuickBuy.ObjetodeValor;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Repositorio.QuickBuy.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.QuickBuy.Context
{
    public class ContextoQuickBuy : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }


        public ContextoQuickBuy(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

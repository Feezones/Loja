using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;
using Microsoft.EntityFrameworkCore;

namespace Loja.Persistence
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options):base(options)
        {
            
        }
        public DbSet<Cliente> Clientes{get;set;}
        public DbSet<Item> Itens{get;set;}

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedidos>()
                .HasKey(PE => new {PE.ClienteId, PE.ItensId});
        }*/
    }
}
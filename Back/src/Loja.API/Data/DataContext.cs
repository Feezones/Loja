using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Cliente> Clientes{get;set;}
        public DbSet<Item> Itens{get;set;}
    }
}
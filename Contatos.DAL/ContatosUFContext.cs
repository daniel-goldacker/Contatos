using Contado.Domain;
using Contatos.DAL.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.DAL
{
    public class ContatosUFContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public ContatosUFContext() : base("TabelaContatos") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Configurations.Add(new ContatosMapConfiguration());
        }
    }
}

using Contado.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.DAL.Mapping
{
    public class ContatosMapConfiguration: EntityTypeConfiguration<Contato>
    {
        public ContatosMapConfiguration()
        {
            this.ToTable("Contatos");
            this.HasKey(c => c.Id);
        }
    }
}

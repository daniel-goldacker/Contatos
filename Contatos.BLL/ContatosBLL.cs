using Contado.Domain;
using Contatos.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.BLL
{
    public class ContatosBLL
    {

        public Contato CriarContatos(Contato NovoContato)
        {
            using (ContatosUFContext context = new ContatosUFContext())
            {
                context.Contatos.Add(NovoContato);
                context.SaveChanges();
                return (NovoContato);
            }
        }

        public List<Contato> BuscaTodosContatos()
        {
            using (ContatosUFContext context = new ContatosUFContext())
            {
                return context.Contatos.ToList();
            }
        }


        public Contato BuscaContatoPorID(int id)
        {
            using (ContatosUFContext context = new ContatosUFContext())
            {
                return context.Contatos.Find(id);
            }
        }

        public void ExcluirContato(Contato dadosContato)
        {
            using (ContatosUFContext context = new ContatosUFContext())
            {
                context.Entry(dadosContato).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void AlterarContato(Contato dadosContato)
        {
            using (ContatosUFContext context = new ContatosUFContext())
            {
                context.Entry(dadosContato).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public  List<Contato> BuscaContatPorNome(String nome)
        {
            using (ContatosUFContext context = new ContatosUFContext())
            {
                context.Database.Log = Console.Write;
                return context.Contatos.Where(c => c.Nome.Contains(nome)).ToList();
            }
        }
    }
}

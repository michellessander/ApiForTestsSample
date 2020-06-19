using System.Collections.Generic;
using System.Linq;
using ApiForTestsample.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiForTestsSample.Repositories
{
    public class ListaRepository : DbContext, IListaRepository
    {
        public ListaRepository(DbContextOptions<ListaRepository> options)
            : base(options)
        { }

        public DbSet<Lista> Lista { get; set; }
        
        public new int SaveChanges() => base.SaveChanges();
        public IEnumerable<Lista> GetAll()
        {
            var listaConsulta = Lista.Include(x => x.Items).ToList();
            var listas = new List<Lista>();
            foreach (var l in listaConsulta)
            {
                var lista = new Lista(){};
                lista.Id = l.Id;
                lista.Items = l.Items;
                lista.Nome = l.Nome;
                listas.Add(lista);
            }

            return listas;
        }
    }
}
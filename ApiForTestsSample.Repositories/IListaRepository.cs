using System.Collections.Generic;
using ApiForTestsample.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiForTestsSample.Repositories
{
    public interface IListaRepository
    {
        DbSet<Lista> Lista { get; set; }
        int SaveChanges();
        IEnumerable<Lista> GetAll();
    }
}
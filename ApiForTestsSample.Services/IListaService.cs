using System.Collections.Generic;
using ApiForTestsample.Domain;

namespace ApiForTestsSample.Services
{
    public interface IListaService
    {
        IEnumerable<Lista> GetAll();
    }
}
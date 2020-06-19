using System.Collections.Generic;
using ApiForTestsample.Domain;
using ApiForTestsSample.Repositories;

namespace ApiForTestsSample.Services
{
    public class ListaService : IListaService
    {
        private readonly IListaRepository _listaRepository;
        public ListaService(IListaRepository listaRepository)
        {
            _listaRepository = listaRepository;
        }

        public IEnumerable<Lista> GetAll() => _listaRepository.GetAll();
    }
}
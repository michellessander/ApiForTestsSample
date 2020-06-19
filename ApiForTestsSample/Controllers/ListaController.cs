using System.Collections.Generic;
using ApiForTestsample.Domain;
using ApiForTestsSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiForTestsSample.Controllers
{
    [Route("api/[controller]")]
    public class ListaController : Controller
    {
        private readonly IListaService _listaService;
        
        public ListaController(IListaService listaService)
        {
            _listaService = listaService;
        }

        [HttpGet]
        public IEnumerable<Lista> Get() => _listaService.GetAll();
    }
}
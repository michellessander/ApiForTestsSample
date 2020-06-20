using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Get()
        {
            var result = _listaService.GetAll();
            
            if (result.Any(x => x.IsValid() == false)) return BadRequest(result.SelectMany(x => x.GetErrors()));
            return Ok(result);
        }
    }
}
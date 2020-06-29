using System;
using System.Collections.Generic;
using System.Net;
using ApiForTestsample.Domain;
using ApiForTestsSample.Controllers;
using ApiForTestsSample.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace ApiForTestsSample.WebApi.Tests
{
    public class ListaControllerTest
    {
        [Fact]
        public void DadoUmRequestGetQuandoHouverListaValidaNoRepositorioDeveRetornar200()
        {
            //arrange
            var lista = new Lista() {Id = 1};
            var listaLista = new List<Lista>(){lista};
            var listaServiceMock = new Mock<IListaService>();
            listaServiceMock.Setup(x => x.GetAll()).Returns(listaLista);
            var controller = new ListaController(listaServiceMock.Object);
            
            //act
            var result = controller.Get();

            //assert
            Assert.IsType<OkObjectResult>(result);
            var actionResult = result as OkObjectResult;
            Assert.Equal(listaLista, actionResult?.Value);
        }
        
        [Fact]
        public void DadoUmRequestGetQuandoHouverListaInvalidaNoRepositorioDeveRetornarErro400()
        {
            //arrange
            var lista = new Lista() {Id = 1};
            lista.SetNome(string.Empty);
            var listaLista = new List<Lista>(){lista};
            var listaServiceMock = new Mock<IListaService>();
            listaServiceMock.Setup(x => x.GetAll()).Returns(listaLista);
            var controller = new ListaController(listaServiceMock.Object);
            
            //act
            var result = controller.Get();

            //assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
        
    }
}
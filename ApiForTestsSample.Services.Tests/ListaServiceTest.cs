using System.Collections.Generic;
using ApiForTestsample.Domain;
using ApiForTestsSample.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace ApiForTestsSample.Services.Tests
{
    public class ListaServiceTest
    {
        [Fact]
        public void DadaARequisicaoDeTodosOsItensDaListaDeveRetonarALista()
        {
            //arrange
            var lista = new List<Lista> {It.IsAny<Lista>()};

            var listaRepositoryMock = new Mock<IListaRepository>();
            listaRepositoryMock.Setup(x => x.GetAll()).Returns(lista);
            var listaService = new ListaService(listaRepositoryMock.Object);
            
            //act
            var result = listaService.GetAll();

            //assert
            Assert.Equal(lista, result);
        }
        
    }
}
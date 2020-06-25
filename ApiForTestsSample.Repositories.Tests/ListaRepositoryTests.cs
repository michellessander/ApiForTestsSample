using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ApiForTestsample.Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using Xunit.Sdk;

namespace ApiForTestsSample.Repositories.Tests
{
    public class ListaRepositoryTests
    {
        [Fact]
        public void DadaAInclusaoDeUmaListaNoBancoDeveRetornarALista()
        {
            // Arrange
            var item = new Item {Id = 1};
            item.SetCategoria("Viagem");
            item.SetDescricao("Arrumar as malas");
            var listaItens = new List<Item> {item};
            var lista = new Lista{Id = 1};
            lista.SetNome("Minha lista");
            lista.SetItem(listaItens);
            var testList = new List<Lista>() { lista };
            var contextOptions = new DbContextOptionsBuilder<ListaRepository>().UseInMemoryDatabase("Teste").Options;
            var repository = new ListaRepository(contextOptions);
            repository.Lista.Add(lista);
            repository.SaveChanges();

            // Act
            var result = repository.GetAll();

            // Assert
            Assert.Equal(testList.FirstOrDefault()?.Nome, result.ToList().FirstOrDefault()?.Nome);
            Assert.Equal(testList.FirstOrDefault()?.Itens, result.ToList().FirstOrDefault()?.Itens);
            Assert.Equal(testList.FirstOrDefault()?.Id, result.ToList().FirstOrDefault()?.Id);

        }
    }
}
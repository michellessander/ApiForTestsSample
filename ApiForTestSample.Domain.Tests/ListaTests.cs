using System.Collections.Generic;
using System.Linq;
using ApiForTestsample.Domain;
using Xunit;

namespace ApiForTestSample.Domain.Tests
{
    public class ListaTests
    {
        
        [Fact]
        public void DadoNomeAtribuidoAListaDeveRetornarONome()
        {
            //arrange
            var lista = new Lista();
            var nome = "Lista";

            //act
            lista.SetNome(nome);
            
            //assert
            Assert.True(lista.IsValid());
            Assert.True(lista.Nome == nome);
            
        }

        [Theory,InlineData(""),InlineData(null)]
        public void DadoNomeVazioOuNuloAtribuidoAListaDeveRetornarErro(string nome)
        {
            //arrange
            var lista = new Lista();
            var mensagemDeErro = "O nome da lista deve ser informado.";

            //act
            lista.SetNome(nome);
            
            //assert
            Assert.False(lista.IsValid());
            Assert.True(lista.GetErrors().FirstOrDefault() == mensagemDeErro);
            
        }

        [Fact]
        public void DadoItemAtribuidoAListaDeveRetornarOItem()
        {
            //arrange
            var lista = new Lista();
            var listaItem = new List<Item>();
            var item = new Item();
            item.SetDescricao("Descrição");
            listaItem.Add(item);

            //act
            lista.SetItem(listaItem);
            
            //assert
            Assert.True(lista.IsValid());
            Assert.Contains(item, lista.Itens);
            
        }

        [Fact]
        public void DadoItemInvalidoAtribuidoAListaDeveRetornarErro()
        {
            //arrange
            var mensagemErro = "O item informado na lista deve ser válido.";
            var lista = new Lista();
            var listaItem = new List<Item>();
            var item = new Item();
            item.SetDescricao(string.Empty);
            listaItem.Add(item);

            //act
            lista.SetItem(listaItem);
            
            //assert
            Assert.False(lista.IsValid());
            Assert.True(lista.GetErrors().FirstOrDefault() == mensagemErro);
            
        }
        
        [Fact]
        public void DadoListaDeItensVaziaNaListaDeveCriarListaValida()
        {
            //arrange
            var lista = new Lista();
            var listaItem = new List<Item>();

            //act
            lista.SetItem(listaItem);
            
            //assert
            Assert.True(lista.IsValid());
            
        }
    }
}
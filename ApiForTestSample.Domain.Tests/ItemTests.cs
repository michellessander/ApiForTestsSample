using System.Linq;
using ApiForTestsample.Domain;
using Xunit;

namespace ApiForTestSample.Domain.Tests
{
    public class ItemTests
    {
        [Fact]
        public void DadoCategoriaAtribuidaAoItemRetornarCategoria()
        {
            //arrange
            var item = new Item();
            var categoria = "Categoria";

            //act
            item.SetCategoria(categoria);
            
            //assert
            Assert.True(item.Categoria.Equals(categoria));
            Assert.True(item.IsValid());
        }
        
        [Fact]
        public void DadoCategoriaVaziaAtribuidaAoItemRetornarErro()
        {
            //arrange
            var item = new Item();
            var categoria = string.Empty;
            var mensagemErro = "A categoria do item deve ser informada.";

            //act
            item.SetCategoria(categoria);
            
            //assert
            Assert.False(item.IsValid());
            Assert.True(item.GetErrors()?.FirstOrDefault()?.Equals(mensagemErro));
        }
        
        [Fact]
        public void DadoDescricaoAtribuidaAoItemRetornarDescricao()
        {
            //arrange
            var item = new Item();
            var descricao = "Descricao";

            //act
            item.SetDescricao(descricao);
            
            //assert
            Assert.True(item.Descricao.Equals(descricao));
            Assert.True(item.IsValid());
        }
        
        [Fact]
        public void DadoDescricaoVaziaAtribuidaAoItemRetornarErro()
        {
            //arrange
            var item = new Item();
            var descricao = string.Empty;
            var mensagemErro = "A descrição do item deve ser informada.";

            //act
            item.SetDescricao(descricao);
            
            //assert
            Assert.False(item.IsValid());
            Assert.True(item.GetErrors()?.FirstOrDefault()?.Equals(mensagemErro));
        }
        
        [Fact]
        public void DadoIdAtribuidaAoItemRetornarId()
        {
            //arrange
            var item = new Item();
            var id = 1;

            //act
            item.Id = id;
            
            //assert
            Assert.True(item.Id.Equals(id));
            Assert.True(item.IsValid());
        }
    }
}
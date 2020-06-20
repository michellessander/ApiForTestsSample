namespace ApiForTestsample.Domain
{
    public class Item : BaseEntity
    {
        public string Descricao { get;  private set; }
        public string Categoria { get;  private set; }

        public void SetDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
            {
                AddError(DomainResource.Descricao_Null_Empty);
                return;
            }
            Descricao = descricao;
        }
        public void SetCategoria(string categoria)
        {
            if (string.IsNullOrEmpty(categoria))
            {
                AddError(DomainResource.Categoria_Null_Empty);
                return;
            }
            Categoria = categoria;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace ApiForTestsample.Domain
{
    public class Lista : BaseEntity
    {
        public string Nome { get; private set; }
        public ICollection<Item> Itens { get; private set; }
        
        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                AddError(DomainResource.Nome_Null_Empty);
                return;
            }
            Nome = nome;
        }
        public void SetItem(ICollection<Item> itens)
        {
            if (!itens.Any()) return;

            foreach (var item in itens)
            {
                if (!item.IsValid())
                {
                    AddError(DomainResource.Item_Invalido);
                    return;
                }
            }
            Itens = itens;
        }
    }
}
using System.Collections.Generic;

namespace ApiForTestsample.Domain
{
    public class Lista : BaseEntity
    {
        public string Nome { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
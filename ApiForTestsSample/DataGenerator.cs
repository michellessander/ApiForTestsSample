using System;
using System.Collections.Generic;
using System.Linq;
using ApiForTestsample.Domain;
using ApiForTestsSample.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApiForTestsSample
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ListaRepository(serviceProvider.GetRequiredService<DbContextOptions<ListaRepository>>()))
            {
                if (context.Lista.Any())
                {
                    return;
                }

                var item = new Item {Id = 1};
                //item.SetCategoria("Viagem");
                item.SetDescricao("Arrumar as malas");
                

                var listaItens = new List<Item> {item};
                
                var lista = new Lista{Id = 1};
                lista.SetNome("Minha lista");
                lista.SetItem(listaItens);
                
                context.Lista.Add(lista);
                
                
                context.SaveChanges();
            }
        }
    }
}
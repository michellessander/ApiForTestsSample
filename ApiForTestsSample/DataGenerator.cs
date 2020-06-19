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

                var item = new Item {Id = 1, Categoria = "Viagem", Descricao = "Fazer as malas"};

                var listaItens = new List<Item> {item};
                
                context.Lista.Add(new Lista
                {
                    Id = 1,
                    Nome = "Minha lista",
                    Items = listaItens

                });

                context.SaveChanges();
            }
        }
    }
}
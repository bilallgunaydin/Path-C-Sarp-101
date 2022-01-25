using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var conxext= new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(conxext.Books.Any())
                {
                    return;
                }

                conxext.Books.AddRange
                (
                    new Book
                    {
                        Id=1,
                        Title="Martin Eden",
                        GenreId=1,
                        PageCount=500,
                        PublishDate= new DateTime(1920,11,30)

                    },

                    new Book
                    {
                        Id=2,
                        Title="Deniz Kurdu",
                        GenreId=1,
                        PageCount=350,
                        PublishDate= new DateTime(1925,05,05)

                    },

                    new Book
                    {
                        Id=3,
                        Title="Hayatın Kaynağı",
                        GenreId=1,
                        PageCount=980,
                        PublishDate= new DateTime(1940,10,05)

                    }
                );
            }
            
        }
    }
}
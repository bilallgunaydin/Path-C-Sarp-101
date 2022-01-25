using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        public GetBooksQuery(BookStoreDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public List<BookViewModel> Handle()
        {
            
            var bookList= _dbContext.Books.OrderBy(x=> x.Id).ToList<Book>();
            List<BookViewModel> vm= new List<BookViewModel>();
            foreach (var book in bookList)
            {
                vm.Add(new BookViewModel()
                {
                    Title=book.Title,
                    PageCount=book.PageCount,
                    PublishDate=book.PublishDate.Date.ToString("dd/MM/yyy"),
                    Genre=((GenreEnum)book.GenreId).ToString(),
                    
                });
            }
            return vm;
        }
    }

    public class BookViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }

    }
}
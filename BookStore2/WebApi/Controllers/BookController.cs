using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.DBOperations;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.CreateBook;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.UpdateBook;
using WebApi.BookOperations.DeleteBook;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
        private readonly BookStoreDbContext _context;
        public BookController(BookStoreDbContext context)
        {
            _context=context;
        }
        
        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query= new GetBooksQuery(_context);
            var result= query.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            BookDetailViewModel result;
            try
            {
                GetBookDetailQuery query =new GetBookDetailQuery(_context);
                query.BookId=id;
                result=query.Handle();
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
              return Ok(result);
        }

        // [HttpGet("{id}")]
        // public Book Get([FromQuery] string id)
        // {
        //     var book=BookList.Where(book=> book.Id==int.Parse(id)).SingleOrDefault();
        //     return book;
        // }

        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command= new CreateBookCommand(_context);

            try
            {
                command.Model= newBook;
                command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
            
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
    
           try
           {
               UpdateBookCommand command= new UpdateBookCommand(_context);
               command.BookId=id;
               command.Model=updatedBook;
               command.Handle();

           }
           catch (Exception ex)
           {
               
               return BadRequest(ex.Message);
           }

            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
           try
            {
                DeleteBookCommand command =new DeleteBookCommand(_context);
                command.BookId=id;
                command.Handle();

            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
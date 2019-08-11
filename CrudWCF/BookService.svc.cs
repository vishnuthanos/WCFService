using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CrudWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        static IBookRepository repository = new BookRepository();
        public List<Book> GetBookList()
        {
            return repository.GetAllBooks();
        }
        public List<Book> GetBookListBare()
        {
            return repository.GetAllBooks();
        }




        public Book GetBookById(string id)
        {
            return repository.GetBookById(int.Parse(id));
        }

        public string AddBook(Book book, string id)
        {
            Book newBook = repository.AddNewBook(book);
            return "id=" + newBook.BookId;
        }
        public string UpdateBook(Book book, string id)
        {
            bool updated = repository.UpdateABook(book);
            if (updated)
                return "Book with id = " + id + " updated successfully";
            else
                return "Unable to update book with id = " + id;
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.DeleteABook(int.Parse(id));
            if (deleted)
                return "Book with id = " + id + " deleted successfully.";
            else
                return "Unable to delete book with id = " + id;
        }
    }
}

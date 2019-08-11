using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CrudWCF
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedResponse,
            Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Books/")]
        [return: MessageParameter(Name = "BookList")]
        List<Book> GetBookList();

        [OperationContract]
        [WebInvoke(
           BodyStyle = WebMessageBodyStyle.Bare,
           Method = "GET", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "BooksBare/")]
        [return: MessageParameter(Name = "BookListBare")]
        List<Book> GetBookListBare();



        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Book/{id}")]
        Book GetBookById(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddBook/{id}")]
        string AddBook(Book book, string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateBook/{id}")]
        string UpdateBook(Book book, string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteBook/{id}")]
        string DeleteBook(string id);

    }
}

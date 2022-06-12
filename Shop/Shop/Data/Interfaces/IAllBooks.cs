using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get; set; }
        Book getObjectBook(int bookId);
    }
}

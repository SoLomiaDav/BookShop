using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();

        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book {name = "Дюна",
                        author = "Френк Герберт",
                        shortDesc = "656",
                        img = "https://content1.rozetka.com.ua/goods/images/big/255947477.jpg",
                        price = 350,
                        isFavorite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }
        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }

}

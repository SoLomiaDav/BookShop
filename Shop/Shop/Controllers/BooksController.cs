using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class BooksController :Controller
    {
        private readonly IAllBooks _allbooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCat)
        {
            _allbooks = iAllBooks;
            _allCategories = iBooksCat;
        }

        public ViewResult List()
        {
            var books = _allbooks.Books;
            return View();
        }
    }
}

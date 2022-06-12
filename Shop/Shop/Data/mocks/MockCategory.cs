using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>{
                    new Category { categoryName = "Тверда обкладинка", desc = "Запобігає залому книги" },
                    new Category { categoryName = "М'яка обкладинка", desc = "Зручна для переносу" }
                };
            }
        }
    }


}

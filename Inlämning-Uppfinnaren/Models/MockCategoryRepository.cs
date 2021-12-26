using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;

namespace Uppfinnaren.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Statues", Cdescription="Animals"},
                new Category{CategoryId=1, CategoryName="Statues", Cdescription="Toys"},
                new Category{CategoryId=1, CategoryName="Statues", Cdescription="Bowls"},
                new Category{CategoryId=1, CategoryName="Statues", Cdescription="Stools"},
                new Category{CategoryId=1, CategoryName="Statues", Cdescription="Utensils"}
            };
    }
}

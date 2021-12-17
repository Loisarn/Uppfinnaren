using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlämning_Uppfinnaren.Models;
using Inlämning_Uppfinnaren.ViewModels;

namespace Inlämning_Uppfinnaren.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Statues", cDescription="Statues"}
            };
    }
}

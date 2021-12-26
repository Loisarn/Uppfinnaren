using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;

namespace Uppfinnaren.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

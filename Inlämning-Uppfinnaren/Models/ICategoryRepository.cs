using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlämning_Uppfinnaren.Models;
using Inlämning_Uppfinnaren.ViewModels;

namespace Inlämning_Uppfinnaren.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

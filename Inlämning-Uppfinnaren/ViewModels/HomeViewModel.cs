using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;

namespace Uppfinnaren.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Art> ArtofTheWeek { get; set; }
    }
}


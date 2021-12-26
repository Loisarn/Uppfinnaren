using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Models;
using Uppfinnaren.ViewModels;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Uppfinnaren.ViewModels
{
    public class ArtListViewModel
    {
       public IEnumerable<Art> Art { get; set; }
       public string CurrentCategory { get; set; }
        
    }
}

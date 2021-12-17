using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Inlämning_Uppfinnaren.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string cDescription { get; set; }
        public List <Art> Arts { get; set; }
    }
}

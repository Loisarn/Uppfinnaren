using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Uppfinnaren.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Cdescription { get; set; }
        public List <Art> Arts { get; set; }
    }
}

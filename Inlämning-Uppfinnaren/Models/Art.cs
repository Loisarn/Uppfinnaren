﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Inlämning_Uppfinnaren.Models
{
    public class Art
    {
            public int ArtId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public string ImageThumbnailUrl { get; set; }
            public int CategoryId { get; set; }
            public decimal Price { get; set; }
            public Category Category { get; set; }
        }
    }


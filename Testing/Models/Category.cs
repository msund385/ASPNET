﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Category : Controller
    {
    

        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}

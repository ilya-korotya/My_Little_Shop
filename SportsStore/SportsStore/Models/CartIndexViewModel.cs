﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SportsStore.Models.Entities;

namespace SportsStore.Models
{
    public class CartIndexViewModel
    {
       public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
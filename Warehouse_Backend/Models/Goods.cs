﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Backend.Models
{
    public class Goods
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

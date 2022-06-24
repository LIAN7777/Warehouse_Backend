using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Backend.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public int W_id { get; set; }
        public int G_id { get; set; }
        public int Number { get; set; }
    }
}

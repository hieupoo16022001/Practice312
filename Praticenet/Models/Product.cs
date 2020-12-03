using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticenet.Models
{
    public class Product
    {
        public string Name { get; set; }
        public long ProductId { get; set; }
        public string Category { get; set; }
        public decimal Luong { get; set; }
    }
}

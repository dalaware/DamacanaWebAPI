using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamacanaWebAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Product> Cartproducts { get; set; }

        public virtual Product Product { get; set; }

    }
}

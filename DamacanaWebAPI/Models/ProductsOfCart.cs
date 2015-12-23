using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamacanaWebAPI.Models
{
    public class ProductsOfCart
    {
        public int Id { get; set; }

        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        /*"Conflicting changes to the role 'ProductsOfCart_Cart_Target' of the relationship 
        'DamacanaWebAPI.Models.ProductsOfCart_Cart' have been detected.",
        */

    }
}

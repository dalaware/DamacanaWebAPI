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

        public virtual ICollection<ProductsOfCart> Productslist { get; set; }

        //public List<Product> Cartproducts { get; set; }

        /* "ExceptionMessage": "One or more validation errors were detected during model 
        generation:\r\n\r\nDamacanaWebAPI.Models.ProductsOfCart: : EntityType 'ProductsOfCart' 
        has no key defined. Define the key for this EntityType.\r\nProductsOfCarts: 
        EntityType: EntitySet 'ProductsOfCarts' is based on type 'ProductsOfCart' that has no keys defined.\r\n",
        */

    }
}

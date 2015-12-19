﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamacanaWebAPI.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Product> PurchaseList { get; set; }

        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}

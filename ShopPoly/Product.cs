using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPoly
{
    public abstract class Product
    {
        public string Name { get; set; }
        public virtual decimal Price { get; set; }
        public abstract string GetInformation();
        public decimal GetDiscountedPrice()
        {
            return Price - (Price * GetDiscount());
        }
        protected virtual decimal GetDiscount()
        {
            return 0.1m;
        }
    }
}

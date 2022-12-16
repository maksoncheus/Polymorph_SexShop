using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 500)
                return Price;
            if(user.Spent < 1000)
                return Price * 0.9;
            return Price * 0.8;
        }
    }
}

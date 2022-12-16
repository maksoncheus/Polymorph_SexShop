using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    internal class Dolls : Product
    {
        public string Material { get; set; }
        public Dolls(string name, double price, string material)
        {
            Name = name;
            Price = price;
            Material = material;
        }
        public override double GetDiscountPrice(User user)
        {
            return base.GetDiscountPrice(user)/2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    internal class Condoms : Product
    {
        public int Size { get; set; }
        public Condoms(string name, double price, int size)
        {
            Name = name;
            Price = price;
            Size = size;
        }
        public override double GetDiscountPrice(User user)
        {
            if (user.Name.StartsWith('Д')) return base.GetDiscountPrice(user) * 0.78;
            return base.GetDiscountPrice(user);
        }
    }
}

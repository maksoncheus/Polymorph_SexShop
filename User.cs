using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    internal class User
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public double Spent { get; private set; }
        public double Balance { get; private set; } 
        public User(string name, string address, double spent, double balance)
        {
            Name = name;
            Address = address;
            Spent = spent;
            Balance = balance;
        }
        public void ReduceBalance(double val)
        {
            Spent += val;
            Balance -= val;
        }
    }
}

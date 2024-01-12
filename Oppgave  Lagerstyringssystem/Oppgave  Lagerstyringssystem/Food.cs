using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave__Lagerstyringssystem
{
    internal class Food : IProduct
    {
        public int ExpireDate { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Food(int expiredate, string name, double price)
        {
            ExpireDate = expiredate;
            Name = name;
            Price = price;
        }
        public Food()
        {

        }
        public void WriteOutInfo()
        {
            Console.WriteLine($"Days:{ExpireDate} - Name:{Name} - kr:{Price}");
        }
        public string ReturnWriteOutInfoVariables()
        {
            return $"Days:{ExpireDate} - Name:{Name} - kr:{Price}";
        }
    }
}

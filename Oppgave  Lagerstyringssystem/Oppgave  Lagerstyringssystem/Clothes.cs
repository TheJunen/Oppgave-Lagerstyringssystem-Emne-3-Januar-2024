using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave__Lagerstyringssystem
{
    internal class Clothes : IProduct
    {
        public string Size  { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Clothes(string size, string name, double price )
        {
            Size = size;
            Name = name;
            Price = price;
        }

        public Clothes()
        {

        }

        public void WriteOutInfo()
        {
            Console.WriteLine($"Size:{Size} - Name:{Name} - kr:{Price}");
        }
        public string ReturnWriteOutInfoVariables()
        {
            return $"Size:{Size} - Name:{Name} - kr:{Price}";
        }
    }
}

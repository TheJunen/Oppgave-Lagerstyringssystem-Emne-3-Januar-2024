using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave__Lagerstyringssystem
{
    internal class Electronic : IProduct
    {
        private int WarrantyTime { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Electronic(int warrantyTime, string name, double price)
        {
            WarrantyTime = warrantyTime;
            Name = name;
            Price = price;
        }
        public Electronic()
        {

        }

        public void WriteOutInfo()
        {
            Console.WriteLine($"Months:{WarrantyTime} - Name:{Name} - kr:{Price}");
        }
        public string ReturnWriteOutInfoVariables()
        {
            return $"Months:{WarrantyTime} - Name:{Name} - kr:{Price}";
        }

    }
}

using System.Xml.Linq;

namespace Oppgave__Lagerstyringssystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();
            
            storage.AddProduct(new Clothes ("medium", "Vero Moda Jeans", 409.99));
            storage.AddProduct(new Clothes("XL", "Gucci Veske", 14999.99));
            storage.AddProduct(new Food(30, "Ost", 80));
            storage.AddProduct(new Food(10, "Kjøttdeig", 69.99));
            storage.AddProduct(new Electronic(24, "TV", 9999.99));
            storage.AddProduct(new Electronic(12, "Ipad Air 4", 4999.99));
            //var storagelist = storage.GetList();
            storage.ListAllProductsInStorage();
            storage.RemoveProduct(3);
            //storagelist = storage.GetList();
            storage.ListAllProductsInStorage();


        }



    }
}
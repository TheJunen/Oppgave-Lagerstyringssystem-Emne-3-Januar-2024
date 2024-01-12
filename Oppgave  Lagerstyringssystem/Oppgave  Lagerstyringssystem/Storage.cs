using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave__Lagerstyringssystem
{
    internal class Storage
    {
        List<IProduct> AllProducts = new List<IProduct>();
        
        public void AddProduct(IProduct product)
        {
            AllProducts.Add(product);
        }

        public void RemoveProduct(int product)
        {
            var Clothes = new Clothes();
            var Electronic = new Electronic();
            var Food = new Food();

            //Console.WriteLine($"Item has been removed {AllProducts[product]}");
            if (AllProducts[product] is Food)
            {
                Console.WriteLine($"Item has been removed: {((Food)AllProducts[product]).ReturnWriteOutInfoVariables()}");
            }
            else if (AllProducts[product] is Electronic)
            {
                Console.WriteLine($"Item has been removed: {((Electronic)AllProducts[product]).ReturnWriteOutInfoVariables()}");
            }
            else if (AllProducts[product] is Clothes)
            {
                Console.WriteLine($"Item has been removed: {((Clothes)AllProducts[product]).ReturnWriteOutInfoVariables()}");
            }
            AllProducts.RemoveAt(product);
            //int myInt = System.Convert.ToInt32(product);
        }

        public void ListAllProductsInStorage()
        {
            foreach (var item in AllProducts)
            {
                item.WriteOutInfo();
            }
        }
        //public List<IProduct> GetList()
        //{
        //    return AllProducts;
        //}
    }
}

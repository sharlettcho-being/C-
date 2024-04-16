using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice2_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesCounter sales = new SalesCounter(ReadSales("sale.csv"));
            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string, int> obj in amountPerStore)
            {
                Console.WriteLine("{0}  {1}", obj.Key, obj.Value);
            }
                
        }

        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                if (line == "") break;
                string[] item = line.Split(',');
                Sale sale = new Sale()
                {
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}

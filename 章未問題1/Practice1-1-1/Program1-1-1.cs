using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtherName.Product product = new OtherName.Product();
            product.Name = "どら焼き";
            product.Code = 98;
            product.Price = 210;

            Console.WriteLine(product.GetTax());

        }
    }
}

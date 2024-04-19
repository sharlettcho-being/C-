using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_1
{
    internal class Program
    {
        /// <summary>
        /// どら焼きの消費税額を求める
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Product Fproduct = new Product();
            Fproduct.FCode = 98;
            Fproduct.FPrice = 210;

            Console.WriteLine(Fproduct.GetTax());

        }
    }
}

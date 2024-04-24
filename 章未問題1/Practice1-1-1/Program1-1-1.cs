using System;

namespace Practice1_1_1 {
    internal class Program
    {
        /// <summary>
        /// どら焼きの消費税額を求める
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Product FProduct = new Product();
            FProduct.Code = 98;
            FProduct.Price = 210;

            Console.WriteLine(FProduct.GetTax());

        }
    }
}

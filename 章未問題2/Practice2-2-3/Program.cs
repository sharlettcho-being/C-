using System;
using System.Collections.Generic;
using System.IO;

namespace Practice2_2_3{
    internal class Program{
        /// <summary>
        /// 商品カテゴリ別の売上高を求める
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args){
            SalesCounter wSales = new SalesCounter(ReadSales("sale.csv"));
            Dictionary<string, int> amountPerStore = wSales.GetPerStoreSales();
            foreach(KeyValuePair<string, int> obj in amountPerStore){
                Console.WriteLine("{0}  {1}", obj.Key, obj.Value);
            }
                
        }
        /// <summary>
        /// 売り上げデータを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        static List<Sale> ReadSales(string filePath){
            List<Sale> wSales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines){
                if (line == "") break;
                string[] item = line.Split(',');
                Sale sale = new Sale(){
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2])
                };
                wSales.Add(sale);
            }
            return wSales;
        }
    }
}

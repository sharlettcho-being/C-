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
            Dictionary<string, int> wAmountPerStore = wSales.GetPerStoreSales();
            foreach(KeyValuePair<string, int> obj in wAmountPerStore) {
                Console.WriteLine("{0}  {1}", obj.Key, obj.Value);
            }
                
        }
        /// <summary>
        /// 売り上げデータを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="filePath">CSVファイルのパス</param>
        /// <returns></returns>
        static List<Sale> ReadSales(string vfilePath){
            List<Sale> FSales = new List<Sale>();
            string[] wLines = File.ReadAllLines(vfilePath);
            foreach(string line in wLines) {
                if (line == "") break;
                string[] item = line.Split(',');
                Sale Fsale = new Sale(){
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2])
                };
                FSales.Add(Fsale);
            }
            return FSales;
        }
    }
}

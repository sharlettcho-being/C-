using System.Collections.Generic;

namespace Practice2_2_3{
    /// <summary>
    /// 売り上げ集計クラス
    /// </summary>
    internal class SalesCounter{
        private List<Sale> FSales;

        /// <summary>
        /// salesインスタンスを受け入れるコンストラクタ
        /// </summary>
        /// <param name="sales">salesインスタンス</param>
        public SalesCounter(List<Sale> vSales){
            FSales = vSales;
        }

        /// <summary>
        /// 店舗別売り上げを求める
        /// </summary>
        /// <returns>店舗別売り上げを求めたDictionaryを返す</returns>
        public Dictionary<string, int> GetPerStoreSales() { 
            Dictionary<string, int> wDict = new Dictionary<string, int>();
            foreach (Sale sale in FSales) {
                if (wDict.ContainsKey(sale.ProductCategory)){
                    wDict[sale.ProductCategory] += sale.Amount;
                }
                else{
                    wDict[sale.ProductCategory] = sale.Amount;
                }
            }
            return wDict;
        }
    }
}

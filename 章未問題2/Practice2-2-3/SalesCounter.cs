using System.Collections.Generic;

namespace Practice2_2_3{
    /// <summary>
    /// 売り上げ集計クラス
    /// </summary>
    internal class SalesCounter{
        private List<Sale> _sales;

        /// <summary>
        /// salesインスタンスを受け入れるコンストラクタ
        /// </summary>
        /// <param name="sales"></param>
        public SalesCounter(List<Sale> sales){
            _sales = sales;
        }

        /// <summary>
        /// 店舗別売り上げを求める
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetPerStoreSales() { 
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales){
                if (dict.ContainsKey(sale.ProductCategory)){
                    dict[sale.ProductCategory] += sale.Amount;
                }
                else{
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }
            return dict;
        }
    }
}

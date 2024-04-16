using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2_3
{
    internal class SalesCounter
    {
        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }

        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                {
                    dict[sale.ProductCategory] += sale.Amount;
                }
                else
                {
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }
            return dict;
        }
    }
}

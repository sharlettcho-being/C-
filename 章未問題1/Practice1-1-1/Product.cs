using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherName
{
    internal class Product
    {
        //商品コード
        public int Code { get; set; }

        //商品名
        public string Name { get; set; }

        //商品価格（税抜き）
        public int Price { get; set; }

        //消費税額を求める（消費税率は8%）
        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        //税込価格を求める
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}

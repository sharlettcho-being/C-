using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_1
{
    internal class Product
    {
        /// <summary>
        /// 商品コード
        /// </summary>
        public int FCode { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string FName { get; set; }

        /// <summary>
        ///商品価格（税抜き） 
        /// </summary>
        public int FPrice { get; set; }

        ///<summary>
        /// 消費税額を求める（消費税率は8%）
        /// </summary>
        /// <returns></returns>
        public int GetTax()
        {
            return (int)(this.FPrice * 0.08);
        }

        /// <summary>
        /// 税込価格を求める
        /// </summary>
        /// <returns></returns>
        public int GetPriceIncludingTax()
        {
            return this.FPrice + GetTax();
        }
    }
}

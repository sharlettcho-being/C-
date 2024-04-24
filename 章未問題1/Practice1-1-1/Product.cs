namespace Practice1_1_1 {
    internal class Product{
        /// <summary>
        /// 商品コード
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///商品価格（税抜き） 
        /// </summary>
        public int Price { get; set; }

        ///<summary>
        /// 消費税額を求める（消費税率は8%）
        /// </summary>
        /// <returns>税金8％が含んでる消費</returns>
        public int GetTax(){
            return (int)(this.Price * 0.08);
        }

        /// <summary>
        /// 税込価格を求める
        /// </summary>
        /// <returns>税込価格</returns>
        public int GetPriceIncludingTax(){
            return this.Price + GetTax();
        }
    }
}

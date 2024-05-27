namespace Practice15_1_1 {
    /// <summary>
    /// 書籍のタイトル、価格、カテゴリID、発行年を持っているクラス
    /// </summary>
    internal class Book {
        /// <summary>
        /// 書籍のタイトル
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// 書籍の価格
        /// </summary>
        public int Price { get; }

        /// <summary>
        /// 書籍のカテゴリID
        /// </summary>
        public int CategoryId { get; }

        /// <summary>
        /// 書籍の発行年
        /// </summary>
        public int PublishedYear { get; }

        /// <summary>
        /// オーバーライドされたToStringメソッド
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"発行年:{this.PublishedYear}, カテゴリ:{this.CategoryId}, 価格:{this.Price}, タイトル:{this.Title}";
        }

        /// <summary>
        /// パラメータなしのコンストラクタ
        /// </summary>
        public Book() { }

        /// <summary>
        /// パラメータありのコンストラクタ
        /// </summary>
        /// <param name="vTitle">書籍のタイトル</param>
        /// <param name="vPrice">書籍の価格</param>
        /// <param name="vCategoryId">書籍のカテゴリID</param>
        /// <param name="vPublishedYear">書籍の発行年</param>
        public Book(string vTitle, int vPrice, int vCategoryId, int vPublishedYear) {
            this.Title = vTitle;
            this.Price = vPrice;
            this.CategoryId = vCategoryId;
            this.PublishedYear = vPublishedYear;
        }
    }
}

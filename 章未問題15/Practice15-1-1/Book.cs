namespace Practice15_1_1 {
    /// <summary>
    /// 書籍のタイトル、価格、カテゴリID、発行年を持っているクラス
    /// </summary>
    internal class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int PublishedYear { get; set; }
        public override string ToString() {
            return $"発行年:{this.PublishedYear}, カテゴリ:{this.CategoryId}, 価格:{this.Price}, タイトル:{this.Title}";
        }
    }
}

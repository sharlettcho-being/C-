namespace Practice15_1_1 {
    /// <summary>
    /// 書籍のカテゴリIdとカテゴリ名を持っているクラス
    /// </summary>
    internal class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return $"{Id}, カテゴリ名：{Name}";
        }
    }
}

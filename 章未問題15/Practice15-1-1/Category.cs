namespace Practice15_1_1 {
    /// <summary>
    /// 書籍のカテゴリIdとカテゴリ名を持っているクラス
    /// </summary>
    internal class Category {
        /// <summary>
        /// 書籍のカテゴリID
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// 書籍のカテゴリ名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// オーバーライドされたToStringメソッド
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"{this.Id}, カテゴリ名：{this.Name}";
        }

        /// <summary>
        /// パラメータなしのコンストラクタ
        /// </summary>
        public Category() { }

        /// <summary>
        /// パラメータありのコンストラクタ
        /// </summary>
        /// <param name="vId">書籍のカテゴリID</param>
        /// <param name="vName">書籍のカテゴリ名</param>
        public Category(int vId, string vName) {
            this.Id = vId;
            this.Name = vName;
        }
    }
}

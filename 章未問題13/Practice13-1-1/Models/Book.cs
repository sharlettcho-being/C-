namespace Practice13_1_1.Models {
    /// <summary>
    /// 書籍の情報を表す
    /// </summary>
    public class Book {
        /// <summary>
        /// パレメータなしのコンストラクタ
        /// </summary>
        public Book() {
        }

        /// <summary>
        /// パレメータありのコンストラクタ
        /// </summary>
        /// <param name="id">書籍の一意の識別子</param>
        /// <param name="title">書籍のタイトル</param>
        /// <param name="publishedYear">書籍が出版された年</param>
        /// <param name="author">書籍の著者</param>
        public Book(int vId, string vTitle, int vPublishedYear, Author vAuthor) {
            this.Id = vId;
            this.Title = vTitle;
            this.PublishedYear = vPublishedYear;
            this.Author = vAuthor;
        }

        /// <summary>
        /// 書籍の一意の識別子を取得または設定
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 書籍のタイトルを取得または設定
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 書籍が出版された年を取得または設定
        /// </summary>
        public int PublishedYear { get; set; }
        /// <summary>
        /// 書籍の著者を取得または設定
        /// </summary>
        public virtual Author Author { get; set; }
    }
}

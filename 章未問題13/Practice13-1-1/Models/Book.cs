namespace Practice13_1_1.Models {
    /// <summary>
    /// 書籍の情報を表す
    /// </summary>
    public class Book {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}

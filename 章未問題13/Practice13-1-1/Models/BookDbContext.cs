using System.Data.Entity;

namespace Practice13_1_1.Models {
    /// <summary>
    /// 書籍データベースのEntity Frameworkデータベースコンテキストを表します。
    /// このコンテキストは、BooksテーブルとAuthorsテーブルとのやり取りを行います。
    /// </summary>
    public class BookDbContext : DbContext {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BookDbContext()
            : base("name=BookDbContext") {
        }

        /// <summary>
        /// 書籍テーブルへの参照
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// 著者テーブルへの参照
        /// </summary>
        public DbSet<Author> Authors { get; set; }
    }
}
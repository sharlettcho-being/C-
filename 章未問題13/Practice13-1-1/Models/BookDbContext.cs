using System.Data.Entity;

namespace Practice13_1_1.Models {
    /// <summary>
    /// 書籍データベースのEntity Frameworkデータベースコンテキストを表します。
    /// このコンテキストは、BooksテーブルとAuthorsテーブルとのやり取りを行います。
    /// </summary>
    public class BookDbContext : DbContext {
        public BookDbContext()
            : base("name=BookDbContext") {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
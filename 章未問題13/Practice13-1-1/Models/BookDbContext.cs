using System;
using System.Data.Entity;
using System.Linq;

namespace Practice13_1_1.Models {
    public class BookDbContext : DbContext {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'BookDbContext' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'Practice13_1_1.Models.BookDbContext' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'BookDbContext' 接続文字列を変更してください。
        public BookDbContext()
            : base("name=BookDbContext") {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
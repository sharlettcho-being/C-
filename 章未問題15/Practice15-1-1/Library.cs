using System.Collections.Generic;

namespace Practice15_1_1 {
    /// <summary>
    /// 書籍のカテゴリプロパティと書籍情報のプロパティを持っているクラス
    /// </summary>
    internal class Library {
        /// <summary>
        /// カテゴリのコレクションを保持する静的プロパティ
        /// </summary>
        public static IEnumerable<Category> Categories { get; private set; }

        /// <summary>
        /// 書籍のコレクションを保持する静的プロパティ
        /// </summary>
        public static IEnumerable<Book> Books { get; private set; }

        static Library() {
            // Categories のデータを初期化
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Development" },
                new Category { Id = 2, Name = "Server" },
                new Category { Id = 3, Name = "Web Design" },
                new Category { Id = 4, Name = "Windows" },
                new Category { Id = 5, Name = "Application" }
            };

            // Books のデータを初期化
            Books = new List<Book>
            {
                new Book {Title = "Writing C# Solid Code", Price = 2500, CategoryId = 1, PublishedYear = 2016},
                new Book {Title = "C# 開発指南", Price = 3800, CategoryId = 1, PublishedYear = 2014},
                new Book {Title = "Visual C# 再入門", Price = 2780, CategoryId = 1, PublishedYear = 2016},
                new Book {Title = "フレーズ学ぶC# Book", Price = 2400, CategoryId = 1, PublishedYear = 2016},
                new Book {Title = "TypeScript 初級講座", Price = 2500, CategoryId = 1, PublishedYear = 2015},
                new Book {Title = "PowerShell 実践レシピ", Price = 4200, CategoryId = 2, PublishedYear = 2013},
                new Book {Title = "SQL Server 完全入門", Price = 3800, CategoryId = 2, PublishedYear = 2014},
                new Book {Title = "IIS Web サーバー運用ガイド", Price = 3180, CategoryId = 2, PublishedYear = 2015},
                new Book {Title = "Microsoft Azure サーバー構築", Price = 4800, CategoryId = 2, PublishedYear = 2016},
                new Book {Title = "Web デザイン講座 HTML5 & CSS", Price = 2800, CategoryId = 3, PublishedYear = 2013},
                new Book {Title = "HTML5 Web 大百科", Price = 3800, CategoryId = 3, PublishedYear = 2015},
                new Book {Title = "CSS デザイン 逆引き辞典", Price = 3550, CategoryId = 3, PublishedYear = 2015},
                new Book {Title = "Windows10で楽しくお仕事", Price = 2280, CategoryId = 4, PublishedYear = 2016},
                new Book {Title = "Windows10 使いこなし術", Price = 1890, CategoryId = 4, PublishedYear = 2015},
                new Book {Title = "続 Windows10 使いこなし術", Price = 2080, CategoryId = 4, PublishedYear = 2016},
                new Book {Title = "Windows10 やさしい操作入門", Price = 2300, CategoryId = 4, PublishedYear = 2015},
                new Book {Title = "まるわかりMicrosoft Office 入門", Price = 1890, CategoryId = 5, PublishedYear = 2015},
                new Book {Title = "Word・Excel 実践テンプレート集", Price = 2600, CategoryId = 5, PublishedYear = 2016},
                new Book {Title = "たのしく学ぶExcel初級編", Price = 2800, CategoryId = 5, PublishedYear = 2015},
            };
        }
    }
}

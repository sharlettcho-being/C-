﻿using System.Collections.Generic;

namespace Practice15_1_1 {
    /// <summary>
    /// 書籍のカテゴリプロパティと書籍情報のプロパティを持っているクラス
    /// </summary>
    internal class Library {
        /// <summary>
        /// カテゴリのコレクションを保持する静的プロパティ
        /// </summary>
        public static IEnumerable<Category> Categories { get; }

        /// <summary>
        /// 書籍のコレクションを保持する静的プロパティ
        /// </summary>
        public static IEnumerable<Book> Books { get; }

        static Library() {
            // Categories のデータを初期化
            Categories = new List<Category>
            {
                new Category (1, "Development" ),
                new Category (2, "Server" ),
                new Category (3, "Web Design" ),
                new Category (4, "Windows" ),
                new Category (5, "Application" )
            };

            // Books のデータを初期化
            Books = new List<Book>
            {
                new Book ("Writing C# Solid Code", 2500, 1,  2016),
                new Book ("C# 開発指南", 3800, 1, 2014),
                new Book ("Visual C# 再入門", 2780, 1, 2016),
                new Book ("フレーズ学ぶC# Book", 2400, 1, 2016),
                new Book ("TypeScript 初級講座", 2500, 1, 2015),
                new Book ("PowerShell 実践レシピ", 4200, 2, 2013),
                new Book ("SQL Server 完全入門", 3800, 2, 2014),
                new Book ("IIS Web サーバー運用ガイド", 3180, 2, 2015),
                new Book ("Microsoft Azure サーバー構築", 4800, 2, 2016),
                new Book ("Web デザイン講座 HTML5 & CSS", 2800, 3, 2013),
                new Book ("HTML5 Web 大百科", 3800, 3, 2015),
                new Book ("CSS デザイン 逆引き辞典", 3550, 3, 2015),
                new Book ("Windows10で楽しくお仕事", 2280, 4, 2016),
                new Book ("Windows10 使いこなし術", 1890, 4, 2015),
                new Book ("続 Windows10 使いこなし術", 2080, 4, 2016),
                new Book ("Windows10 やさしい操作入門", 2300, 4, 2015),
                new Book ("まるわかりMicrosoft Office 入門", 1890, 5, 2015),
                new Book ("Word・Excel 実践テンプレート集", 2600, 5, 2016),
                new Book ("たのしく学ぶExcel初級編", 2800, 5, 2015),
            };
        }
    }
}

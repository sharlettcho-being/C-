using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice15_1_1 {
    internal class Program {
        static void Main(string[] args) {

            var mostExpensiveBook = ShowMostEnpensiveBook();
            ShowBookDetails("---------最も価格の高い書籍----------", mostExpensiveBook);

            var wNumberOfBooksByYear = ShowNumberOfBooksByYear();
            ShowBookData("--------発行年ごとに書籍数のカウント--------", wNumberOfBooksByYear);
            

            var wSortYearAndPrice = SortByPublicationYearAndPrice();
            ShowBookData("--------発行年、価格の順に並べ替えした結果--------", wSortYearAndPrice);
            

            var wBooksPublishedIn2016 = ShowCategoriesOfBooksPublishedIn2016();
            ShowBookData("--------2016年に発行された書籍のカテゴリ一覧--------", wBooksPublishedIn2016);

            var wBooks = GroupBooksByCategory();
            ShowBookData("--------カテゴリ名をアルファベット順に並べ替えした書籍名--------", wBooks);

            var wGroupBooksByCategory = GroupBooksByCategoryAndPublishedYear();
            ShowBookData("--------「Development」というカテゴリの書籍を発行年ごとに分類して結果--------", wGroupBooksByCategory);

            var wCategories = GetCategoriesWithFourOrMoreBooks();
            ShowBookData("--------4冊以上発行されたカテゴリ名--------", wCategories);
        }

        /// <summary>
        /// 最も価格の高い書籍の情報を表示する。
        /// </summary>
        public static Book ShowMostEnpensiveBook() {
            return Library.Books.OrderByDescending(x => x.Price).First();
        }

        /// <summary>
        /// 発行年ごとに書籍の数をカウントする。
        /// </summary>
        public static IEnumerable<dynamic> ShowNumberOfBooksByYear() {
            return Library.Books.GroupBy(x => x.PublishedYear)
                                .Select(y => new { wYear = y.Key, wCount = y.Count() });
        }

        /// <summary>
        /// 発行年、価格の順に並べ替える結果を表示する。
        /// </summary>
        public static IEnumerable<dynamic> SortByPublicationYearAndPrice() {
            return Library.Books.OrderBy(x => x.PublishedYear).ThenBy(y => y.Price)
                                .Join(Library.Categories,
                                        wBook => wBook.CategoryId,
                                        wCategory => wCategory.Id,
                                        (wBook, wCategory) => new {
                                          wBook.Title,
                                          CategoryName = wCategory.Name,
                                          wBook.PublishedYear,
                                          wBook.Price
                                         });
        }

        /// <summary>
        /// 2016年に発行された書籍のカテゴリ一覧を表示する。
        /// </summary>
        public static IEnumerable<dynamic> ShowCategoriesOfBooksPublishedIn2016() {
            return Library.Books.Where(x => x.PublishedYear == 2016);
            
        }

        /// <summary>
        /// GroupByメソッドを使い、カテゴリごとに書籍を分類しカテゴリ名をアルファベット
        /// 順に並べ替える。
        /// </summary>
        public static IEnumerable<dynamic> GroupBooksByCategory() {
            return Library.Books.Join(Library.Categories,
                                    wBook => wBook.CategoryId,
                                    wCategory => wCategory.Id,
                                    (wBook, wCategory) => new {
                                        wCategoryName = wCategory.Name,
                                        wBookInfo = wBook
                                    })
                                .GroupBy(x => x.wCategoryName)
                                .OrderBy(y => y.Key)
                                .Select(z => new {
                                    Category = z.Key,
                                    Titles = z.Select(x => x.wBookInfo.Title)
                                 });
        }

        /// <summary>
        /// カテゴリ"Development"の書籍に対し、発行年ことに分類する。
        /// </summary>
        public static IEnumerable<dynamic> GroupBooksByCategoryAndPublishedYear() {
            return Library.Books.Join(Library.Categories,
                                    wBook => wBook.CategoryId,
                                    wCategory => wCategory.Id,
                                    (wBook, wCategory) => new {
                                        wCategoryName = wCategory.Name,
                                        wBookInfo = wBook
                                    })
                                    .Where(x => x.wCategoryName == "Development")
                                    .GroupBy(x => x.wBookInfo.PublishedYear)
                                    .OrderBy(x => x.Key)
                                    .Select(group => new {
                                        Year = group.Key,
                                        Books = group.OrderBy(item => item.wBookInfo.Title)
                                    });
        }

        /// <summary>
        /// GroupJoinメソッドを使って4冊以上発行されたカテゴリ名を求める。
        /// </summary>
        public static IEnumerable<dynamic> GetCategoriesWithFourOrMoreBooks() {
            return Library.Categories.GroupJoin(Library.Books, x => x.Id,
                                        y => y.CategoryId,
                                        (x, wBooks) => new {
                                            wCategoryName = x.Name,
                                            wBookCount = wBooks.Count()
                                        })
                                     .Where(x => x.wBookCount >= 4)
                                     .Select(x => x.wCategoryName);
        }

        /// <summary>
        /// 書籍の詳細情報を表示する
        /// </summary>
        /// <param name="vHeader">課題</param>
        /// <param name="vBook">内容のオブジェクト</param>
        public static void ShowBookDetails(string vHeader, Book vBook) {
            Console.WriteLine(vHeader);
            Console.WriteLine($"書籍名      -  {vBook.Title}\n価格        -  {vBook.Price}" +
                              $"\nカテゴリID  -  {vBook.CategoryId}" +
                              $"\n発行年      -  {vBook.PublishedYear}");
            Console.WriteLine();
        }

        /// <summary>
        /// ユーザーが要望する情報を表示する
        /// </summary>
        /// <param name="vHeader">課題</param>
        /// <param name="vBook">内容のオブジェクト</param>
        public static void ShowBookData(string vHeader, IEnumerable<dynamic> vBook) {
            if (vBook == null || vBook.Count() == 0) return;
            Console.WriteLine(vHeader);
            foreach (var wBook in vBook) {
                switch (vHeader) {
                    case string wHeader when wHeader.Contains("発行年ごとに書籍数のカウント"):
                        Console.WriteLine($"{wBook.wYear}\t{wBook.wCount}");
                        break;
                    case string wHeader when wHeader.Contains("発行年、価格の順に並べ替えした結果"):
                        Console.WriteLine($"{wBook.PublishedYear}年 {wBook.Price}円 {wBook.Title} ({wBook.CategoryName})");
                        break;
                    case string wHeader when wHeader.Contains("2016年に発行された書籍のカテゴリ一覧"):
                        Console.WriteLine(wBook.ToString());
                        break;
                    case string wHeader when wHeader.Contains("カテゴリ名をアルファベット順に並べ替えした書籍名"):
                        Console.WriteLine($"#{wBook.Category}");
                        foreach (var wBookTitle in wBook.Titles) {
                            Console.WriteLine($"　{wBookTitle}");
                        }
                        break;
                    case string wHeader when wHeader.Contains("「Development」というカテゴリの書籍を発行年ごとに分類して結果"):
                        Console.WriteLine($"#{wBook.Year}");
                        foreach (var w in wBook.Books) {
                            Console.WriteLine($"  {w.wBookInfo.Title}");
                        }
                        break;
                    case string wHeader when wHeader.Contains("4冊以上発行されたカテゴリ名"):
                        Console.WriteLine(wBook);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Linq;

namespace Practice15_1_1 {
    internal class Program {
        static void Main(string[] args) {

            ShowMostEnpensiveBook();
            ShowNumberOfBooksByYear();
            SortByPublicationYearAndPrice();
            ShowCategoriesOfBooksPublishedIn2016();
            GroupBooksByCategory();
            GroupBooksByCategoryAndPublishedYear();
            GetCategoriesWithFourOrMoreBooks();
        }

        /// <summary>
        /// 最も価格の高い書籍の情報を表示する。
        /// </summary>
        public static void ShowMostEnpensiveBook() {
            var wMostExpensiveBook = Library.Books.OrderByDescending(x => x.Price).First();
            Console.WriteLine("---------最も価格の高い書籍----------");
            Console.WriteLine($"書籍名      -  {wMostExpensiveBook.Title}\n価格        -  {wMostExpensiveBook.Price}" +
                              $"\nカテゴリID  -  {wMostExpensiveBook.CategoryId}" +
                              $"\n発行年      -  {wMostExpensiveBook.PublishedYear}");
            Console.WriteLine();
        }

        /// <summary>
        /// 発行年ごとに書籍の数をカウントする。
        /// </summary>
        public static void ShowNumberOfBooksByYear() {
            var wNumberOfBooksByYear = Library.Books.GroupBy(x => x.PublishedYear)
                                                    .Select(y => new {wYear = y.Key, wCount = y.Count()});
            Console.WriteLine("--------発行年ごとに書籍数のカウント--------");
            foreach (var wBook in wNumberOfBooksByYear) {
                Console.WriteLine($"{wBook.wYear}\t{wBook.wCount}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 発行年、価格の順に並べ替える結果を表示する。
        /// </summary>
        public static void SortByPublicationYearAndPrice() {
            var wSortYearAndPrice = Library.Books.OrderBy(x => x.PublishedYear).ThenBy(y => y.Price).Join(Library.Categories,
                                               wBook => wBook.CategoryId,
                                               wCategory => wCategory.Id,
                                               (wBook, wCategory) => new {
                                                   wTitle = wBook.Title,
                                                   wCategory = wCategory.Name,
                                                   wPublishedYear = wBook.PublishedYear,
                                                   wPrice = wBook.Price
                                               });
            Console.WriteLine("--------発行年、価格の順に並べ替えした結果--------");
            foreach (var wSortBook in wSortYearAndPrice) {
                Console.WriteLine($"{wSortBook.wPublishedYear}年 {wSortBook.wPrice}円 {wSortBook.wTitle} ({wSortBook.wCategory})");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 2016年に発行された書籍のカテゴリ一覧を表示する。
        /// </summary>
        public static void ShowCategoriesOfBooksPublishedIn2016() {
            var wBooksPublishedIn2016 = Library.Books.Where(x => x.PublishedYear == 2016);
            Console.WriteLine("--------2016年に発行された書籍のカテゴリ一覧--------");
            foreach (var wBook in wBooksPublishedIn2016) {
                Console.WriteLine(wBook.ToString());
            }
            Console.WriteLine();
        }

        /// <summary>
        /// GroupByメソッドを使い、カテゴリごとに書籍を分類しカテゴリ名をアルファベット
        /// 順に並べ替える。
        /// </summary>
        public static void GroupBooksByCategory() {
            var wBooks = Library.Books.Join(Library.Categories,
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
            Console.WriteLine("--------カテゴリ名をアルファベット順に並べ替えした書籍名--------");
            foreach (var wBook in wBooks) {
                Console.WriteLine($"#{wBook.Category}");
                foreach (var wBookTitle in wBook.Titles) {
                    Console.WriteLine($"　{wBookTitle}");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// カテゴリ"Development"の書籍に対し、発行年ことに分類する。
        /// </summary>
        public static void GroupBooksByCategoryAndPublishedYear() {
            var wBooks = Library.Books.Join(Library.Categories,
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
            Console.WriteLine("--------「Development」というカテゴリの書籍を発行年ごとに分類して結果--------");
            foreach (var wBook in wBooks) {
                Console.WriteLine($"#{wBook.Year}");
                foreach (var w in wBook.Books) {
                    Console.WriteLine($"  {w.wBookInfo.Title}");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// GroupJoinメソッドを使って4冊以上発行されたカテゴリ名を求める。
        /// </summary>
        public static void GetCategoriesWithFourOrMoreBooks() {
            var wCategories = Library.Categories.GroupJoin(Library.Books, x => x.Id,
                                        y => y.CategoryId,
                                        (x, wBooks) => new {
                                            wCategoryName = x.Name,
                                            wBookCount = wBooks.Count()
                                        })
                                        .Where(x => x.wBookCount >= 4)
                                        .Select(x => x.wCategoryName);
            Console.WriteLine("--------4冊以上発行されたカテゴリ名--------");
            foreach (var wCategory in wCategories) {
                Console.WriteLine(wCategory);
            }
        }
    }
}

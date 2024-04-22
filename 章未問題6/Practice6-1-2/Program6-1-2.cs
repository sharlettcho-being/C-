using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_1_2 {
    internal class Program {
        /// <summary>
        /// 書籍のタイトル・価格・ページ数を格納したリストに対しても実装
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var wBooks = new List<Book> {
                new Book{Title = "C#プログラミングの新常識", Price = 3800, Pages = 378},
                new Book{Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312},
                new Book{Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385},
                new Book{Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464},
                new Book{Title = "フレーズ覚えるC#入門", Price = 5300, Pages = 604},
                new Book{Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453},
                new Book{Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348},
             
            };
            //タイトルがワンダフル・C#ライフ”である書籍の価格とページ数を表示する
            DisplayPriceAndPageCountOfWonderfulCSharpLife(wBooks);
            //タイトルに”C#”が含まれている書籍のカウントを表示する
            CountBooksContainingCSharpInTitle(wBooks);
            //タイトルに”C#”が含まれている書籍の平均ページ数を求める
            GetAveragePageCountOfFirstBookOver400Yen(wBooks);
            //価格が4000円以上の本で最初に見つかった書籍のタイトルを表示する
            GetTitleOfFirstBookOver4000Yen(wBooks);
            //価格が4000未満の本の中で最大のページ数を求める
            GetMaxPageCountOfBooksUnder4000Yen(wBooks);
            //ページ数が400以上の書籍を、価格の高い順に表示（タイトルと価格を表示）
            DisplayBooksOver400PagesInDescendingOrderOfPrice(wBooks);
            //タイトルに”C#”が含まれかつ500ページ以下の本のタイトルを表示する
            FindTitlesContainingCSharpAndUnder500Pages(wBooks);            

        }
        /// <summary>
        /// タイトルがワンダフル・C#ライフ”である書籍の価格とページ数を表示する
        /// </summary>
        /// <param name="vBooks">本のタイトル・価格・ページ数を持っているリスト</param>
        public static void DisplayPriceAndPageCountOfWonderfulCSharpLife(List<Book> vBooks) {
            var wPrices = vBooks.FirstOrDefault(x => x.Title.Contains("ワンダフル・C#ライフ")).Price;
            var wPages = vBooks.FirstOrDefault(x => x.Title.Contains("ワンダフル・C#ライフ")).Pages;
            Console.WriteLine("------タイトルがワンダフル・C#ライフ”である書籍　------");
            Console.WriteLine($"価格    : 　{wPrices} \nページ数: 　{wPages}");
        }
        /// <summary>
        /// タイトルに”C#”が含まれている書籍のカウントを表示する
        /// </summary>
        /// <param name="vBooks">本のタイトル・価格・ページ数を持っているリスト</param>
        public static void CountBooksContainingCSharpInTitle(List<Book> vBooks) {
            var wCount = vBooks.Where(x => x.Title.Contains("C#")).Count();
            Console.WriteLine("\n------　タイトルに”C#”が含まれている書籍のカウント　------");
            Console.WriteLine(wCount.ToString());

        }
        /// <summary>
        /// タイトルに”C#”が含まれている書籍の平均ページ数を求める
        /// </summary>
        /// <param name="vBooks">本のタイトル・価格・ページ数を持っているリスト</param>
        public static void GetAveragePageCountOfFirstBookOver400Yen(List<Book> vBooks) {
            var wAverage = vBooks.Where(x => x.Title.Contains("C#")).Average(y => y.Pages);
            Console.WriteLine("\n------　タイトルに”C#”が含まれている書籍の平均ページ数　------");
            Console.WriteLine(wAverage.ToString());
        }
        /// <summary>
        /// 価格が4000円以上の本で最初に見つかった書籍のタイトルを表示する 
        /// </summary>
        /// <param name="vBooks"></param>
        public static void GetTitleOfFirstBookOver4000Yen(List<Book> vBooks) {
            var wTitle = vBooks.FirstOrDefault(x => x.Price > 4000).Title;
            Console.WriteLine("\n------　価格が4000円以上の本で最初に見つかった書籍のタイトル　------");
            Console.WriteLine(wTitle);
        }
        /// <summary>
        /// 価格が4000未満の本の中で最大のページ数を求める
        /// </summary>
        /// <param name="vBooks">本のタイトル・価格・ページ数を持っているリスト</param>
        public static void GetMaxPageCountOfBooksUnder4000Yen(List<Book> vBooks) {
            var wBook = vBooks.Where(x => x.Price < 4000).Max(y => y.Pages);
            Console.WriteLine("\n------　価格が4000未満の本の中で最大のページ数　------");
            Console.WriteLine(wBook);
        }
        /// <summary>
        /// ページ数が400以上の書籍を、価格の高い順に表示（タイトルと価格を表示）
        /// </summary>
        /// <param name="vBooks">本のタイトル・価格・ページ数を持っているリスト</param>
        public static void DisplayBooksOver400PagesInDescendingOrderOfPrice(List<Book> vBooks) {
            var wNewBook = vBooks.OrderByDescending(x => x.Price).Where(x => x.Pages >= 400).ToList();
            Console.WriteLine("\n------　ページ数が400以上の書籍を、価格の高い順に表示　------");
            foreach (var book in wNewBook) {
                Console.WriteLine($"タイトル:  {book.Title} \n価格    :  {book.Price}");
            }
        }
        /// <summary>
        /// タイトルに”C#”が含まれかつ500ページ以下の本のタイトルを表示する
        /// </summary>
        /// <param name="vBooks">本のタイトル・価格・ページ数を持っているリスト</param>
        public static void FindTitlesContainingCSharpAndUnder500Pages(List<Book> vBooks) {
            var wBook2 = vBooks.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            Console.WriteLine("\n------　タイトルに”C#”が含まれかつ500ページ以下の本のタイトル　------");
            foreach (var book in wBook2) {
                Console.WriteLine($"タイトル:   {book.Title}");
            }
        }
    }
}

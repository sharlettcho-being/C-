﻿using Practice13_1_1.Models;
using System;
using System.Linq;

namespace Practice13_1_1 {
    internal class Program {
        static void Main(string[] args) {
            var wFirstAuthour = new Author(1, "菊池寛", new DateTime(1888, 12, 26), "男性");
            var wSecondAuthour = new Author(1, "川端康成", new DateTime(1899, 6, 14), "男性");

            var wBook = new Book(1, "こころ", 2003, new Author(1, "夏目漱石", new DateTime(1867, 2, 9), "男性"));
            var wBook2 = new Book(2, "伊豆の踊子", 2003, new Author(2, "川端康成", new DateTime(1899, 6, 14), "男性")); 
            var wBook3 = new Book(3, "真珠未人", 2002, new Author(3, "真珠未人", new DateTime(1888, 12, 26), "男性"));
            var wBook4 = new Book(4, "注文の多い料理店", 2000, new Author(4, "宮沢賢治", new DateTime(1896, 8, 27), "男性"));

            AddAuthors(wFirstAuthour, wSecondAuthour);
            AddBooks(wBook, wBook2, wBook3, wBook4);
            DisplayAllBookInformationWithAuthor();
            GetBookWithLongestTitle();
            DisplayOldestThreeBooks();
            DisplayBooksByAuthorBirthdateDescending();
        }

        /// <summary>
        /// 著者追加する
        /// </summary>
        public static void AddAuthors(Author vFirstAuthour, Author vSecondAuthour) {
            using (var wDbForAuthor = new BookDbContext()) {
                wDbForAuthor.Authors.Add(vFirstAuthour);
                wDbForAuthor.Authors.Add(vSecondAuthour);
                wDbForAuthor.SaveChanges();
            }
        }

        /// <summary>
        ///書籍を追加する。
        /// </summary>
        public static void AddBooks(Book vBook, Book vBook2, Book vBook3, Book vBook4) {
            using (var wDbforBook = new BookDbContext()) {
                wDbforBook.Books.Add(vBook);
                wDbforBook.Books.Add(vBook2);
                wDbforBook.Books.Add(vBook3);
                wDbforBook.Books.Add(vBook4);
                wDbforBook.SaveChanges();
            }
        }

        /// <summary>
        /// 全ての書籍情報を著者名とともに表示する
        /// </summary>
        public static void DisplayAllBookInformationWithAuthor() {
            using (var wDbBook = new BookDbContext()) {
                var wBooks = wDbBook.Books.Where(x => x.Author.Name != null).ToList();
                foreach (var wBook in wBooks) {
                    Console.WriteLine($"{wBook.Title}\t{wBook.PublishedYear}\t{wBook.Author.Name}");
                }
            }
            Console.WriteLine("----------------------------------------------------------");
        }

        /// <summary>
        /// タイトルの最も長い書籍を求める
        /// 複数ある場合は全てを求める
        /// </summary>
        public static void GetBookWithLongestTitle() {
            using (var wDb = new BookDbContext()) {

                var wMaxLength = wDb.Books.Max(x => x.Title.Length);
                var wLongestTitleBooks = wDb.Books.Where(x => x.Title.Length == wMaxLength).ToList();
                foreach(var wBook in wLongestTitleBooks) {
                    Console.WriteLine(wBook.Title);
                }
            }
            Console.WriteLine("----------------------------------------------------------");
        }

        /// <summary>
        /// 発行年の古い順に3冊だけの書籍を取得し、そのタイトルを表示する
        /// </summary>
        public static void DisplayOldestThreeBooks() {
            using (var wDb = new BookDbContext()) {
                var wOldestBook = wDb.Books.OrderBy(x => x.PublishedYear).Take(3).ToList();
                foreach (var wBook in wOldestBook) {
                    Console.WriteLine($"{wBook.Title}\t{wBook.Author.Name}");
                }
            }
            Console.WriteLine("----------------------------------------------------------");
        }

        /// <summary>
        /// 著者の誕生日の遅い順に並べて書籍のタイトルと発行年を表示する。
        /// </summary>
        public static void DisplayBooksByAuthorBirthdateDescending() {
            using (var wDb = new BookDbContext()) {
                var wAuthorBirthdate = wDb.Books.OrderByDescending(x => x.Author.Birthday).ToList();
                foreach (var wBook in wAuthorBirthdate) {
                    Console.WriteLine($"{wBook.Title}\t{wBook.PublishedYear}");
                }
            }
        }
    }
}

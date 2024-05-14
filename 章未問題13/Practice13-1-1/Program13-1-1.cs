using Practice13_1_1.Models;
using System;
using System.Linq;

namespace Practice13_1_1 {
    internal class Program {
        static void Main(string[] args) {
            AddAuthors();
            AddBooks();
            DisplayAllBookInformationWithAuthor();
            GetBookWithLongestTitle();
            DisplayOldestThreeBooks();
            DisplayBooksByAuthorBirthdateDescending();
        }

        /// <summary>
        /// 著者追加する
        /// </summary>
        public static void AddAuthors() {
            using (var wDbForAuthor = new BookDbContext()) {
                var wFirstAuthour = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "男性",
                    Name = "菊池寛",
                };
                wDbForAuthor.Authors.Add(wFirstAuthour);
                var wSecondAuthour = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "男性",
                    Name = "川端康成",
                };
                wDbForAuthor.Authors.Add(wSecondAuthour);
                wDbForAuthor.SaveChanges();
            }
        }

        /// <summary>
        ///書籍を追加する。
        /// </summary>
        public static void AddBooks() {
            using (var wDbforBook = new BookDbContext()) {
                var wBook = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = new Author {
                        Name = "夏目漱石",
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "男性",
                    }
                };
                wDbforBook.Books.Add(wBook);
                var wBook2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Name = "川端康成",
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "男性",
                    }
                };
                wDbforBook.Books.Add(wBook2);
                var wBook3 = new Book {
                    Title = "真珠未人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Name = "菊池寛",
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "男性",
                    }
                };
                wDbforBook.Books.Add(wBook3);

                var wBook4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = new Author {
                        Name = "宮沢賢治",
                        Birthday = new DateTime(1896, 8, 27),
                        Gender = "男性",
                    }
                };
                wDbforBook.Books.Add(wBook4);

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

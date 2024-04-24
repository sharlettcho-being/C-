using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice7_1_1 {
    internal class Program {
        /// <summary>
        /// 文字列から各アルファベット文字が何文字ずつ現れるかカウントする。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //初期化
            var wText = "Cozy Lummox gives smart squid who asks for job pen";

            //ディクショナリを使った処理
            CountAlphabetCharactersUsingDictionary(wText);

            //ソートディクショナリを使った処理
            CountAlphabetCharactersUsingSortedDictionary(wText);

            //参照のためにコメントとして残しました！
            //wDict = wText.Where(char.IsLetter).GroupBy(char.ToUpper).ToDictionary(x => x.Key, x => x.Count());            
        }

        /// <summary>
        /// ディクショナリを使って各アルファベット文字が何文字ずつ現れるかカウントしました。
        /// 順に並べ替える処理が必要！
        /// </summary>
        /// <param name="vText">文字列</param>
        public static void CountAlphabetCharactersUsingDictionary(string vText) {
            Dictionary<char, int> wDict = new Dictionary<char, int>();

            foreach (char ch in vText.ToUpper()) {
                if (ch >= 'A' && ch <= 'Z') {
                    if (wDict.ContainsKey(ch)) {
                        wDict[ch]++;
                    } 
                    else {
                        wDict.Add(ch, 1);
                    }
                }
            }
            //ディクショナリをキー順に並べ替える
            var wResult = wDict.OrderBy(pair => pair.Key);

            Console.WriteLine("-----ディクショナリを使った結果\"-----");
            //結果を表示する
            foreach (var item in wResult) {
                Console.WriteLine($"'{item.Key}' : \t{item.Value}");
            }
         }

        /// <summary>
        /// ソートディクショナリを使って各アルファベット文字が何文字ずつ現れるかカウントしました。
        /// 順に並べ替える処理が不要！
        /// </summary>
        /// <param name="vText">文字列</param>
        public static void CountAlphabetCharactersUsingSortedDictionary(string vText) {
            SortedDictionary<char, int> wSortedDict = new SortedDictionary<char, int>();

            foreach (char ch in vText.ToUpper()) {
                if (ch >= 'A' && ch <= 'Z') {
                    if (wSortedDict.ContainsKey(ch)) {
                        wSortedDict[ch]++;
                    } 
                    else {
                        wSortedDict.Add(ch, 1);
                    }
                }
            }

            Console.WriteLine("-----ソートディクショナリを使った結果\"-----");

            //結果を表示する
            foreach (var item in wSortedDict) {
                Console.WriteLine($"'{item.Key}' : \t{item.Value}");
            }
        }
    }
}

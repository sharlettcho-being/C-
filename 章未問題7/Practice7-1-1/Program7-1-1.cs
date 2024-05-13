using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice7_1_1 {
    internal class Program {
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
        /// キーが挿入された順序で保持されるので順に並べ替える処理が必要！
        /// </summary>
        /// <param name="vText">文字列</param>
        public static void CountAlphabetCharactersUsingDictionary(string vText) {
            var wDict = new Dictionary<char, int>();

            foreach (char wChar in vText.ToUpper()) {
                if (!char.IsLetter(wChar)) continue;
                if (wDict.ContainsKey(wChar)) {
                    wDict[wChar]++;
                } else {
                    wDict.Add(wChar, 1);
                }
            }

            Console.WriteLine("-----ディクショナリを使った結果\"-----");
            //結果を表示する
            foreach (var wWord in wDict.OrderBy(x => x.Key)) {
                Console.WriteLine($"'{wWord.Key}' : \t{wWord.Value}");
            }
         }

        /// <summary>
        /// ソートディクショナリを使って各アルファベット文字が何文字ずつ現れるかカウントしました。
        /// キーが自動的にソートされ、昇順に保持されるので順に並べ替える処理が不要！
        /// </summary>
        /// <param name="vText">文字列</param>
        public static void CountAlphabetCharactersUsingSortedDictionary(string vText) {
            var wSortedDict = new SortedDictionary<char, int>();

            foreach (char wChar in vText.ToUpper()) {
                if (!char.IsLetter(wChar)) continue;
                if (wSortedDict.ContainsKey(wChar)) {
                    wSortedDict[wChar]++;
                } else {
                    wSortedDict.Add(wChar, 1);
                }
            }

            Console.WriteLine("-----ソートディクショナリを使った結果\"-----");

            //結果を表示する
            foreach (var wWord in wSortedDict) {
                Console.WriteLine($"'{wWord.Key}' : \t{wWord.Value}");
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Practice10_1_3 {
    internal class Program {
        /// <summary>
        /// 文字列配列から単語"time"が含まれている文字列を取り出し
        /// timeの開始位置を全て出力する
        /// 大文字/小文字の区別なく検索
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //初期化
            var wTexts = new[] {
                "Time is money",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable."
            };
            var wRegex = @"[Tt]ime";
            foreach(var wText in wTexts) {
                Match wString = Regex.Match(wText, wRegex);
                if (wString.Success) {
                    Console.WriteLine("{0}{1}", wString.Index, wString.Value);
                }
            }          
        }
    }
}

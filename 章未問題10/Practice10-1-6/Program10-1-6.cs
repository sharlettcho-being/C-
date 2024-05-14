using System;
using System.Text.RegularExpressions;

namespace Practice10_1_6 {
    internal class Program {
        static void Main(string[] args) {
            //初期化
            string wInputData = "ababa 12321 12345 abcdc abab 98789 12ab3 12321 2bab2 @aba@ @###@";

            // 5文字の回文を検索するパターン
            string wSearchFiveCharacterPalindrome = @"\b(\w)(\w)\w\2\1\b";
            //数字や記号だけから成る回文を除外する
            string wExceludePattern = @"\b(\d+|\W+)";

            wInputData = Regex.Replace(wInputData, wExceludePattern, " ");

            // 5文字の回文を抽出
            MatchCollection wMatches = Regex.Matches(wInputData, wSearchFiveCharacterPalindrome);        
            foreach (Match wMatch in wMatches) {
                  Console.WriteLine(wMatch.Value);
            }
        }
    }
}

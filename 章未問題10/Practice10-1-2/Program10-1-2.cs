using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_1_2 {
    internal class Program {
        /// <summary>
        /// テキストファイルから読み込み、3文字以上の数字だけから成る部分文字列をすべて抜き出す。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            var wFilePath = @"C:\Users\sharlettcho\Desktop\Sample10-2.txt";
            var wRegex = @"\d{3,}";
            if (File.Exists(wFilePath)) {
                string[] wLines = File.ReadAllLines(wFilePath);
                foreach (string wLine in wLines) {
                    Match wMatchValue = Regex.Match(wLine, wRegex);
                    if (wMatchValue.Success) {
                        Console.WriteLine(wMatchValue.Value);
                    }              
                }
            }
        }
    }
}

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_1_2 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\Sample10-2.txt";

            var wRegex = @"\d{3,}";
            if (!File.Exists(wFilePath)) return;
            foreach (string wLine in File.ReadAllLines(wFilePath)) {
                Match wMatchValue = Regex.Match(wLine, wRegex);
                if (wMatchValue.Success) {
                     Console.WriteLine(wMatchValue.Value);
                }
            }
        }
    }
}

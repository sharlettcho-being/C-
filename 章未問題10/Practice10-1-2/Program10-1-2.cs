using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_1_2 {
    internal class Program {
        static void Main(string[] args) {

            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Sample10-2.txt";

            // 実際のファイルパスを取得
            string wFilePath = Path.Combine(wCurrentDirectory, wRelativePath);

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

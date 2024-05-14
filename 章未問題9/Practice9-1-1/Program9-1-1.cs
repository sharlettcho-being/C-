using System;
using System.IO;

namespace Practice9_1_1 {
    internal class Program {
        static void Main(string[] args) {

            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Program9-1-1.cs";

            // 実際のファイルパスを取得
            string wFilePath = Path.Combine(wCurrentDirectory, wRelativePath);

            var wCounterClass = new CountClass();

            Console.WriteLine(wCounterClass.CountLinesContainingClassKeywordUsingStreamReader(wFilePath));

            Console.WriteLine(wCounterClass.CountLinesContainingClassKeywordUsingReadAllLines(wFilePath));

            Console.WriteLine(wCounterClass.CountLinesContainingClassKeywordUsingReadAllLines(wFilePath));
        }
    }
}

using System;

namespace Practice9_1_1 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\Program9-1-2.cs";

            var wCounterClass = new CountClass();

            Console.WriteLine(wCounterClass.CountLinesContainingClassKeywordUsingStreamReader(wFilePath));

            Console.WriteLine(wCounterClass.CountLinesContainingClassKeywordUsingReadAllLines(wFilePath));

            Console.WriteLine(wCounterClass.CountLinesContainingClassKeywordUsingReadAllLines(wFilePath));
        }
    }
}

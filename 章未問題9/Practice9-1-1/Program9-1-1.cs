using System;

namespace Practice9_1_1 {
    internal class Program {
        static void Main(string[] args) {
            //ファイルパスの初期化
            var wFilePath = @"C:\SharLettCho\C#研修用\Question3－22\Question3－22\Program.cs";

            var wCounterClass = new CountClass();

            var wCountUsingStreamReader = wCounterClass.CountLinesContainingClassKeywordUsingStreamReader(wFilePath);
            Console.WriteLine(wCountUsingStreamReader);

            var wCountUsingReadAllLines = wCounterClass.CountLinesContainingClassKeywordUsingReadAllLines(wFilePath);
            Console.WriteLine(wCountUsingReadAllLines);

            var wCountUsingReadLines = wCounterClass.CountLinesContainingClassKeywordUsingReadAllLines(wFilePath);
            Console.WriteLine(wCountUsingReadLines);
        }
    }
}

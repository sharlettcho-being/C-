using System;
using System.IO;
using System.Text;

namespace Practice9_1_3 {
    internal class Program {
        static void Main(string[] args) {
            // 第1引数と第2引数がそれぞれ2つのテキストファイルのパスです
            string wTextFilePath = args[0];
            string wBetuTextFilePath = args[1];

            if (!File.Exists(wTextFilePath)) {
                Console.WriteLine("指定された入力ファイルが見つかりませんでした。");
                return;
            }
            using (var wWriter = new StreamWriter(wTextFilePath, append:true))
            using (var wReader = new StreamReader(wBetuTextFilePath, Encoding.UTF8)) {
                 while (!wReader.EndOfStream) {
                     var wLine = wReader.ReadLine();
                     wWriter.WriteLine(wLine);
                 }
            }
        }
    }
}

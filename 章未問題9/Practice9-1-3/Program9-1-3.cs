using System;
using System.IO;
using System.Text;

namespace Practice9_1_3 {
    internal class Program {
        static void Main(string[] args) {
            
            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wFirstRelativePath = @"..\..\File2.txt";
            string wSecondtRelativePath = @"..\..\File.txt";

            // 実際のファイルパスを取得
            string wTextFilePath = Path.Combine(wCurrentDirectory, wFirstRelativePath);
            string wBetuTextFilePath = Path.Combine(wCurrentDirectory, wSecondtRelativePath);

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

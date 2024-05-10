using System;
using System.IO;
using System.Text;

namespace Practice9_1_2 {
    internal class Program {
        static void Main(string[] args) {

            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();
            //読み込むファイル
            var wRelativePathForRead = @"..\..\File.txt";
            //書き出すファイル
            var wRelativePathForWrite = @"..\..\出力.txt";

            // 実際のファイルパスを取得
            string wTextFilePathForRead = Path.Combine(wCurrentDirectory, wRelativePathForRead);

            string wTextFilePathForWrite = Path.Combine(wCurrentDirectory, wRelativePathForWrite);

            int wLineNumber = 0;

            if (!File.Exists(wTextFilePathForRead)) {
                Console.WriteLine("指定された入力ファイルが見つかりませんでした。");
                return;
            }              
            using (var wReader = new StreamReader(wTextFilePathForRead, Encoding.UTF8)) 
            using (var wWriter = new StreamWriter(wTextFilePathForWrite, append: true)) {
                while (!wReader.EndOfStream) {
                    wLineNumber++;
                    wWriter.WriteLine($"{wLineNumber}: {wReader.ReadLine()}");
                }
            }
            Console.WriteLine("別のテキストファイルに出力完了！");
        }
    }
}

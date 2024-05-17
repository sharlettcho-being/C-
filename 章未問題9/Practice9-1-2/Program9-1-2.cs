using System;
using System.IO;
using System.Text;

namespace Practice9_1_2 {
    internal class Program {
        static void Main(string[] args) {

            //読み込むファイル
            var wRelativePathForRead = @"..\..\File.txt";
            //書き出すファイル
            var wRelativePathForWrite = @"..\..\出力.txt";

            int wLineNumber = 0;

            if (!File.Exists(wRelativePathForRead)) {
                Console.WriteLine("指定された入力ファイルが見つかりませんでした。");
                return;
            }              
            using (var wReader = new StreamReader(wRelativePathForRead, Encoding.UTF8)) 
            using (var wWriter = new StreamWriter(wRelativePathForWrite, append: true)) {
                while (!wReader.EndOfStream) {
                    wLineNumber++;
                    wWriter.WriteLine($"{wLineNumber}: {wReader.ReadLine()}");
                }
            }
            Console.WriteLine("別のテキストファイルに出力完了！");
        }
    }
}

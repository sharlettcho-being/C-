using System;
using System.IO;
using System.Text;

namespace Practice9_1_2 {
    internal class Program {
        /// <summary>
        /// テキストファイルを読み込み、行の先頭に行番号を振り、その結果を別のテキストファイルに出力する
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //読み込むファイル
            var wTextFilePathForRead = @"C:\Users\sharlettcho\Desktop\File.txt";
            //書き出すファイル
            var wTextFilePathForWrite = @"C:\Users\sharlettcho\Desktop\出力.txt";

            int wLineNumber = 0;

            if (File.Exists(wTextFilePathForRead)) {
                
                using (var wReader = new StreamReader(wTextFilePathForRead, Encoding.UTF8)) 
                using (var wWriter = new StreamWriter(wTextFilePathForWrite, append: true)) {
                    while (!wReader.EndOfStream) {
                        var wLine = wReader.ReadLine();
                        wLineNumber++;
                        wWriter.WriteLine($"{wLineNumber}: {wLine}");
                    }
                }
                Console.WriteLine("別のテキストファイルに出力完了！");
            } else {
                Console.WriteLine("指定された入力ファイルが見つかりませんでした。");
            }
        }
    }
}

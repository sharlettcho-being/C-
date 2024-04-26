using System;
using System.IO;
using System.Text;

namespace Practice9_1_3 {
    internal class Program {
        /// <summary>
        /// あるテキストファイルの最後に別のテキストファイルの内容を追加する
        /// コマンドラインで２つのテキストファイルのパス名を指定する。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
             if (args.Length < 2) {
                 Console.WriteLine("テキストファイル２つのパスを指定してください。");
                 return;
             }
             // 第1引数と第2引数がそれぞれ2つのテキストファイルのパスです
             string wTextFilePath = args[0];
             string wBetuTextFilePath = args[1];

             Console.WriteLine($"ファイル１{wTextFilePath}");
             Console.WriteLine($"ファイル２ {wBetuTextFilePath}");

             if (File.Exists(wTextFilePath)) {
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
}

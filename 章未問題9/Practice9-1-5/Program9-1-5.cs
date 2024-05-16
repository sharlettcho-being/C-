using System;
using System.IO;

namespace Practice9_1_5 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\Test";

            //ディレクトリ情報を取得
            var wDirectioryInfo = new DirectoryInfo(wFilePath);
            //指定したディレクトリの配下にあるファイルを取得
            var wFiles = wDirectioryInfo.EnumerateFiles("*.*", SearchOption.AllDirectories);

            foreach (var wFile in wFiles) {
                //ファイルのサイズを取得
                double wFileSize = wFile.Length;
                //ファイルサイズをチェックする
                if (wFileSize > 1048576) {
                    Console.WriteLine(wFile.Name);
                }
            }
        }
    }
}

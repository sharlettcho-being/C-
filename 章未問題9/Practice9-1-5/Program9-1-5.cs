using System;
using System.IO;

namespace Practice9_1_5 {
    internal class Program {
        /// <summary>
        /// 指定したディレクトリおよびそのサブディレクトリの配下にあるファイルのサイズが１Ｍバイト以上
        ///のファイル名の一覧を表示する
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Test";

            // 実際のファイルパスを取得
            string wFilePath = Path.Combine(wCurrentDirectory, wRelativePath);

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

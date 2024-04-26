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
            string wDirectory = @"C:\Users\sharlettcho\Desktop\Test";

            //ディレクトリ情報を取得
            var wDirectioryInfo = new DirectoryInfo(wDirectory);
            //指定したディレクトリの配下にあるファイルを取得
            var wFiles = wDirectioryInfo.EnumerateFiles("*.*", SearchOption.AllDirectories);
           
            foreach (var file in wFiles) {
                //ファイルのサイズを取得
                double wFileSize = file.Length;
                //ファイルサイズをチェックする
                if (wFileSize > 1048576) {
                    Console.WriteLine(file.Name);
                }
            }

        }            
    }
}

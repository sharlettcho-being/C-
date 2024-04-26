using System;
using System.IO;

namespace Practice9_1_4 {
    internal class Program {
        /// <summary>
        /// 指定したディレクトリ配下にあるファイルを別のディレクトリにコピーする
        /// コピーするファイル名に「_bak」を付ける
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            string wSourctDirectory = @"C:\Users\sharlettcho\Desktop\Temp";
            string wCopyDirectory = @"C:\Users\sharlettcho\Desktop\";

            //原本のファイルパスのチェック
            if (Directory.Exists(wSourctDirectory)) {
                //コピーするファイルのパスのチェック
                if (Directory.Exists(wCopyDirectory)) {
                    //コピーされるパスにあるファイルの取得
                    string[] wFiles = Directory.GetFiles(wSourctDirectory);
                    foreach (var file in wFiles)
                    {
                        //各ファイルの名前（拡張子抜く）に_bakを追加し、拡張子を付ける
                        string wFilename = Path.GetFileNameWithoutExtension(file) + "_bak" + Path.GetExtension(file);
                        //コピーするファイルの名前とパスを合わせる
                        var wCopyFilename = Path.Combine(wCopyDirectory, wFilename);
                        //ファイルをコピーする
                        File.Copy(file, wCopyFilename, overwrite: true);

                        Console.WriteLine("ファイルコピー完了！");
                    }                    
                    
                }
            }

        }
    }
}

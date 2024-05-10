using System;
using System.IO;

namespace Practice9_1_4 {
    internal class Program {
        static void Main(string[] args) {

            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            //読み込むファイル
            var wRelativePathForSource = @"..\..\Temp";
            //書き出すファイル
            var wRelativePathForCopy = @"..\..\bin\";

            // 実際のファイルパスを取得
            string wSourcetDirectory = Path.Combine(wCurrentDirectory, wRelativePathForSource);

            string wCopyDirectory = Path.Combine(wCurrentDirectory, wRelativePathForCopy);

            if (!Directory.Exists(wSourcetDirectory)) return;
            if (!Directory.Exists(wCopyDirectory)) return;

            //コピーされるパスにあるファイルの取得
            string[] wFiles = Directory.GetFiles(wSourcetDirectory);
            foreach (var wFile in wFiles) {
                //各ファイルの名前（拡張子抜く）に_bakを追加し、拡張子を付ける
                string wFilename = $"{Path.GetFileNameWithoutExtension(wFile)}_bak{Path.GetExtension(wFile)}";

                //コピーするファイルの名前とパスを合わせる
                var wCopyFilename = Path.Combine(wCopyDirectory, wFilename);
                //ファイルをコピーする
                File.Copy(wFile, wCopyFilename, overwrite: true);

                Console.WriteLine("ファイルコピー完了！");
            }
        }
    }
}

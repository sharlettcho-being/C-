using System;
using System.IO;
using System.IO.Compression;

namespace Practice14_1_5 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wZipFilePath = @"..\..\Temp.zip";
            var wOutputFolderPath = @"..\..\";

            ExtractTxtFilesFromZip(wZipFilePath, wOutputFolderPath);
        }

        /// <summary>
        ///指定された ZIP ファイルから .txt ファイルを抽出し、指定された出力フォルダに保存します。
        /// </summary>
        /// <param name="vZipFilePath">抽出元の ZIP ファイルのパス</param>
        /// <param name="vOutputFolderPath">抽出したファイルの保存先フォルダのパス</param>
        public static void ExtractTxtFilesFromZip(string vZipFilePath, string vOutputFolderPath) {
            if (!File.Exists(vZipFilePath)) return;
            // ZIP ファイルを読み取り専用で開く
            using (var wZipFile = ZipFile.OpenRead(vZipFilePath)) {
                foreach (var wEntry in wZipFile.Entries) {
                    // エントリが .txt ファイルであるかをチェックする
                    if (!Path.GetExtension(wEntry.Name).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                        continue;
                     // 出力パス
                     string wOutputPath = Path.Combine(vOutputFolderPath, wEntry.FullName);

                     // 出力先フォルダが存在しない場合は作成する
                     Directory.CreateDirectory(Path.GetDirectoryName(wOutputPath));

                     //テキストファイルを保存
                     wEntry.ExtractToFile(wOutputPath, overwrite: true);
                }
            }
        }
        
    }
}

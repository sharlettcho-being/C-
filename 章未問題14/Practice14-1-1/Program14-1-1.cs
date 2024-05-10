using System.Diagnostics;
using System.IO;

namespace Practice14_1_1 {
    internal class Program {
        static void Main(string[] args) {
            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativeFilePath = @"..\..\Sample14-1.txt";

            // 実際のファイルパスを取得
            string wInputFilePath = Path.Combine(wCurrentDirectory, wRelativeFilePath);

            if (!File.Exists(wInputFilePath)) return;

            var wLines = File.ReadAllLines(wInputFilePath);
            foreach (var wLine in wLines) {
                string wTrimmedPath = wLine.Split(new[] { ' ' }, 2)[0].Trim();
                string wFullpath = Path.Combine(wCurrentDirectory, wTrimmedPath);

                // 相対パスを絶対パスに変換
                string wAbsolutePath = Path.GetFullPath(wFullpath);

                using (Process process = Process.Start(wAbsolutePath)) {
                    process.WaitForExit();
                }
            }
        }
            
    }
}

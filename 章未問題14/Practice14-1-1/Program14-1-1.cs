using System.Diagnostics;
using System.IO;

namespace Practice14_1_1 {
    internal class Program {
        static void Main(string[] args) {

            // 相対パスを使用してファイルにアクセスする例
            string wInputFilePath = @"..\..\Sample14-1.txt";

            if (!File.Exists(wInputFilePath)) return;

            var wLines = File.ReadAllLines(wInputFilePath);
            foreach (var wLine in wLines) {
                string wTrimmedPath = wLine.Split(new[] { ' ' }, 2)[0].Trim();
                // 相対パスを絶対パスに変換
                string wAbsolutePath = Path.GetFullPath(wTrimmedPath);

                if (!File.Exists(wAbsolutePath)) return;

                using (Process wProcess = Process.Start(wAbsolutePath)) {
                    wProcess.WaitForExit();
                }
            }
        }
    }
}

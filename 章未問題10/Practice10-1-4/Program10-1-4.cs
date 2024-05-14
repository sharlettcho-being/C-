using System.Text.RegularExpressions;
using System.IO;

namespace Practice10_1_4 {
    internal class Program {
        static void Main(string[] args) {
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Sample10-4.txt";

            // 実際のファイルパスを取得
            string wFilePath = Path.Combine(wCurrentDirectory, wRelativePath);

            var wPattern = @"[Vv]ersion=""v4.0""";

            if (!File.Exists(wFilePath)) return;
            if (!File.Exists(wFilePath)) return;
            var wLines = File.ReadAllLines(wFilePath);
            using (StreamWriter wWriter = new StreamWriter(wFilePath)) {
                foreach (string wLine in wLines) {
                    string wString = Regex.Replace(wLine, @"\s*=\s*", "=");
                    wString = Regex.Replace(wString, wPattern, @"version=""v5.0""");
                    wWriter.WriteLine(wString);
                }
            }
        }
    }
}

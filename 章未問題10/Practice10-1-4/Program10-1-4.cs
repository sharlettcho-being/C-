using System.Text.RegularExpressions;
using System.IO;

namespace Practice10_1_4 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\Sample10-4.txt";

            var wPattern = @"[Vv]ersion=""v4.0""";

            if (!File.Exists(wFilePath)) return;
            var wLines = File.ReadAllLines(wFilePath);
            using (var wWriter = new StreamWriter(wFilePath)) {
                foreach (string wLine in wLines) {
                    string wString = Regex.Replace(wLine, @"\s*=\s*", "=");
                    wString = Regex.Replace(wString, wPattern, @"version=""v5.0""");
                    wWriter.WriteLine(wString);
                }
            }
        }
    }
}

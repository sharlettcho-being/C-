using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_1_5 {
    internal class Program {
        static void Main(string[] args) {

            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Sample10-5.html";

            // 実際のファイルパスを取得
            string wFilePath = Path.Combine(wCurrentDirectory, wRelativePath);
            string wPattern = @"<[A-Z]+";

            if (!File.Exists(wFilePath)) return;
            if (!File.Exists(wFilePath)) return;
            string[] wLines = File.ReadAllLines(wFilePath);
            using (StreamWriter wWriter = new StreamWriter(wFilePath)) {
                foreach (string wLine in wLines) {
                    string wString = Regex.Replace(wLine, wPattern, m => m.Value.ToLower());
                    wWriter.WriteLine(wString);
                }
            }
        }
    }
}

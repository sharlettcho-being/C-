using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_1_5 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\Sample10-5.html";

            string wPattern = @"<[A-Z]+";

            if (!File.Exists(wFilePath)) return;
            var wLines = File.ReadAllLines(wFilePath);
            using (var wWriter = new StreamWriter(wFilePath)) {
                foreach (string wLine in wLines) {
                    string wString = Regex.Replace(wLine, wPattern, m => m.Value.ToLower());
                    wWriter.WriteLine(wString);
                }
            }
        }
    }
}

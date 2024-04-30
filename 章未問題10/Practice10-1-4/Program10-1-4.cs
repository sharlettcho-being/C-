using System.Text.RegularExpressions;
using System.IO;

namespace Practice10_1_4 {
    internal class Program {
        /// <summary>
        /// テキストファイルかを読み込み、version="v4.0"と書かれた箇所にversion="v5.0"と置き換え
        /// =の前後には任意の数字の空白文字が入っている、出力の時は空白を削除する
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var wFilePath = @"C:\Users\sharlettcho\Desktop\Sample10-4.txt";
            var wPattern = @"[Vv]ersion=""v4.0""";
            
            if (File.Exists(wFilePath)) {
                if (File.Exists(wFilePath)) {
                    string[] wLines = File.ReadAllLines(wFilePath);
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
    }
}

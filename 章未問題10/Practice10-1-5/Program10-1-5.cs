using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_1_5 {
    internal class Program {
        /// <summary>
        /// HTMLファイルを読み込み、<DIV>などのタグ名が大文字になっているものを小文字のタグ名に変換する
        /// <DIV class="my ..">のように属性が記載されている場合も対応する
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var wFilePath = @"C:\Users\sharlettcho\Desktop\Sample10-5.html";
            string wPattern = @"<[A-Z]+";

            if (File.Exists(wFilePath)) {
                if (File.Exists(wFilePath)) {
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
    }
}

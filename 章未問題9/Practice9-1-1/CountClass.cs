using System.IO;
using System.Text;

namespace Practice9_1_1 {
    /// <summary>
    /// 指定されたファイルにclassキーワードが含まれている行数をカウントする
    /// </summary>
    internal class CountClass {
        /// <summary>
        /// StreamReaderを使用し、キーワード"class"が含まれている行数をカウントする
        /// </summary>
        /// <param name="vFilePath">指定したファイルのパス</param>
        /// <returns>行数</returns>
        public int CountLinesContainingClassKeywordUsingStreamReader(string vFilePath) {
            int wCount = 0;
            if (!File.Exists(vFilePath)) {
                return 0;
            }
            using (var wReader = new StreamReader(vFilePath, Encoding.UTF8)) {
                while (!wReader.EndOfStream) {
                    var wLines = wReader.ReadLine();
                    wCount += CountClassKeywords(wLines);
                }
            }
            return wCount;
        }

        /// <summary>
        /// ReadAllLinesを使用し、キーワード"class"が含まれている行数をカウントする
        /// </summary>
        /// <param name="vFilePath">指定したファイルのパス</param>
        /// <returns>行数</returns>
        public int CountLinesContainingClassKeywordUsingReadAllLines(string vFilePath) {
            int wCount = 0;
            if (!File.Exists(vFilePath)) {
                return 0;
            }
            foreach (string wLine in File.ReadAllLines(vFilePath)) {
                wCount += CountClassKeywords(wLine);
            }
            return wCount;
        }

        /// <summary>
        /// ReadLinesを使用し、キーワード"class"が含まれている行数をカウントする
        /// </summary>
        /// <param name="vFilePath">指定したファイルのパス</param>
        /// <returns>行数</returns>
        public int CountLinesContainingClassKeywordUsingReadLines(string vFilePath) {
            int wCount = 0;
            if (!File.Exists(vFilePath)) {
                return 0;
            }
            var wLines = File.ReadLines(vFilePath);
            foreach (var wLine in wLines) {
                wCount += CountClassKeywords(wLine);
            }
            return wCount;
        }

        /// <summary>
        /// classキーワードの前後には空白がある、リテラル文字列やコメントの中にclassという単語が含まれないのチェック
        /// </summary>
        /// <param name="vLines">各行</param>
        /// <returns>カウント</returns>
        public int CountClassKeywords(string vLines) {
            int wCount = 0;
            string[] wWords = vLines.Split(' ');
            for (int i = 0; i < wWords.Length; i++) {
                if (wWords[i] == "class") {
                    wCount++;
                }
            }
            return wCount;
        }
    }
}

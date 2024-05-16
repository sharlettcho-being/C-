using System;
using System.Linq;
using System.Text;

namespace Practice17_1_3 {
    /// <summary>
    /// テキストファイルの中の全角数字を半角数字に置き換える
    /// </summary>
    internal class ChangeDigitZenToHanProcessor : ITextFileProcessor {
        private StringBuilder wConvertedText;

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="vFileName"></param>
        public void Initialize(string vFileName) {
            // 初期化処理が必要な場合に実装する
            wConvertedText = new StringBuilder();
        }

        /// <summary>
        /// 全角数字から半角数字に変換する
        /// </summary>
        /// <param name="vLine">処理するテキストファイルの行</param>
        /// <returns></returns>
        private string ConvertZenkakuToHankaku(string vLine) {
            char[] wZenkakuNumbers = { '０', '１', '２', '３', '４', '５', '６', '７', '８', '９' };
            char[] wHankakuNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if (!vLine.Any(char.IsDigit)) return vLine;
            for (int i = 0; i < wZenkakuNumbers.Length; i++) {
                vLine = vLine.Replace(wZenkakuNumbers[i], wHankakuNumbers[i]);
            }
            return vLine;
        }

        /// <summary>
        /// テキストファイルの各行を処理する
        /// </summary>
        /// <param name="vLines">処理するテキストファイルの行</param>
        public void Execute(string vLines) {
            vLines = ConvertZenkakuToHankaku(vLines);
            wConvertedText.AppendLine(vLines);
        }

        /// <summary>
        /// テキストファイル処理を終了
        /// </summary>
        public void Terminate() {
            Console.WriteLine(wConvertedText.ToString());
        }
    }
}

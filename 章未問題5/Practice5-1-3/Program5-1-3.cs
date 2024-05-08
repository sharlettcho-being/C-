using System;
using System.Linq;
using System.Text;

namespace Practice5_1_3 {
    internal class Program {
        /// <summary>
        /// 空白のカウント、文字列の置き換え、単語のカウント、単語の列挙、文字列の連接
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //初期化
            var wText = "Jackdaws Love my big sphinx of quartz";           

            FindWhiteSpaceCount(wText);

            ReplaceText(wText);

            CalculateTangoCount(wText);

            OutputTango(wText);

            ReplaceOriginalText(wText);
        }

        /// <summary>
        ///空白のカウントを計算
        /// </summary>
        /// <param name="vText"></param>
        public static void FindWhiteSpaceCount(string vText) {
            int wWhiteSpaceCount = 0;
            foreach (char wWord in vText)
                if (char.IsWhiteSpace(wWord)) {
                    wWhiteSpaceCount++;
                }
            Console.WriteLine(wWhiteSpaceCount.ToString());
        }

        /// <summary>
        /// 文字列を置き換えする
        /// </summary>
        /// <param name="vText"></param>
        public static void ReplaceText(string vText) {
            var wReplace = vText.Replace("big", "small");
            Console.WriteLine(wReplace.ToString());
        }

        /// <summary>
        /// 単語がいくつあるかカウントする
        /// </summary>
        /// <param name="vText"></param>
        public static void CalculateTangoCount(string vText) {
            var wTangoCount = vText.Split(' ').Count();
            Console.WriteLine(wTangoCount.ToString());
        }

        /// <summary>
        /// 4文字以下の単語を列挙する
        /// </summary>
        /// <param name="vText"></param>
        public static void OutputTango(string vText) {
            var wWords = vText.Split(' ');
            foreach (var wWord in wWords) {
                if (wWord.Length <= 4) {
                    Console.WriteLine(wWord.ToString());
                }
            }
        }

        /// <summary>
        /// StringBuilderを使って文字列を連結する
        /// </summary>
        /// <param name="vText"></param>
        public static void ReplaceOriginalText(string vText) {
            var wWords = vText.Split(' ');
            var wNewText = new StringBuilder();
            foreach (var wWord in wWords) {
                wNewText.Append(wWord.ToString());
            }
            Console.WriteLine(wNewText.ToString());
        }

    }
}

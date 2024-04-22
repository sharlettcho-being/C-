using System;
using System.Linq;

namespace Practice6_1_1 {
    internal class Program {
        /// <summary>
        /// 数値を格納した配列に対して実装
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //初期化
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //最大値の表示
            FindMaxValue(wNumbers);
            //最後から２つの要素を表示する
            DisplayLastTwoElements(wNumbers);
            // それぞれの数値を文字列に変換する
            ConvertNumbersToStrings(wNumbers);
            // 数の小さい順に並べ、先頭から3つを表示する。
            DisplayFirstThreeNumbersInAscendingOrder(wNumbers);
            //重複を排除し、10より大きい値のカウントを表示する
            CountDistinctValuesGreaterThanTen(wNumbers);

        }
        /// <summary>
        /// 最大値の表示
        /// </summary>
        /// <param name="vNumberes">数値が格納された配列</param>
        public static void FindMaxValue(int[] vNumberes) {
            var wMaxNumber = vNumberes.Max();
            Console.WriteLine("------ 最大値 ------");
            Console.WriteLine(wMaxNumber);
        }
        /// <summary>
        /// 最後から２つの要素を表示する
        /// </summary>
        /// <param name="vNumbers">数値が格納された配列</param>
        public static void DisplayLastTwoElements(int[] vNumbers) {
            var wLastNumbers = vNumbers.Reverse().Take(2);
            Console.WriteLine("------ 最初から2つの要素 ------");
            foreach (var number in wLastNumbers) {
                Console.WriteLine(number);
            }
        }
        /// <summary>
        /// それぞれの数値を文字列に変換する
        /// </summary>
        /// <param name="vNumbers">数値が格納された配列</param>
        public static void ConvertNumbersToStrings(int[] vNumbers) {
            var wTexts = vNumbers.Select(n => n.ToString()).ToArray();
            Console.WriteLine("------ 数値を文字列に変換した結果 ------");
            foreach (var text in wTexts) {
                Console.WriteLine(text);
            }
        }
        /// <summary>
        /// 数の小さい順に並べ、先頭から3つを表示する。
        /// </summary>
        /// <param name="vNumbers">数値が格納された配列</param>
        public static void DisplayFirstThreeNumbersInAscendingOrder(int[] vNumbers) {
            var wNewNumber = vNumbers.OrderBy(x => x).Take(3);
            Console.WriteLine("------ 数の小さい順に並べ、先頭から3つの要素 ------");
            foreach (var number in wNewNumber) {
                Console.WriteLine(number);
            }
        }
        /// <summary>
        /// //重複を排除し、10より大きい値のカウントを表示する
        /// </summary>
        /// <param name="vNumbers">数値が格納された配列</param>
        public static void CountDistinctValuesGreaterThanTen(int[] vNumbers) {
            var wNumbaer2 = vNumbers.Distinct().Where(x => x > 10).Count();
            Console.WriteLine("------ 重複を排除し、10より大きい値のカウント ------");
            Console.WriteLine(wNumbaer2);
        }
    }
}

using System;
using System.Globalization;

namespace Practice5_1_1 {
    internal class Program {
        /// <summary>
        /// 入力された文字列2つが等しいかどうかのチェック
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            Console.WriteLine("文字列を記入お願いします。");
            string wText = Console.ReadLine();

            Console.WriteLine("もう一つの文字列を記入お願いします。");
            string wText2 = Console.ReadLine();

            //入力された文字列２つを比較する
            if (String.Compare(wText, wText2, new CultureInfo("ja-JP"), CompareOptions.IgnoreCase) == 0){
                Console.WriteLine("等しい！");
            } else {
                Console.WriteLine("等しくない！");
            }
        }
    }
}

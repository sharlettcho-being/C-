using System;

namespace Practice5_1_4 {
    /// <summary>
    /// 文字列から一部の文字列を取り出す処理
    /// </summary>
    internal class Program {
        static void Main(string[] args) {
            //初期化
            var wText = "NoveList=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            //作家を取得する
            string wNoveList = GetData(wText, "NoveList=");

            //代表作を取得する
            string wBestWork = GetData(wText, "BestWork=");

            //誕生日を取得する
            string wBorn = GetData(wText, "Born=");

            Console.WriteLine($"作家　: {wNoveList}\n代表作: {wBestWork}\n誕生日: {wBorn}");

        }

        /// <summary>
        /// 文字列の一部を取得する
        /// </summary>
        /// <param name="vText"></param>
        /// <param name="vValue"></param>
        /// <returns></returns>
        public static String GetData(string vText, string vValue) {
            int wStartIndex = vText.IndexOf(vValue) + vValue.Length;
            int wEndIndex = vText.IndexOf(";", wStartIndex);
            if (wEndIndex == -1) {
                wEndIndex = vText.Length;
            }
            return (vText.Substring(wStartIndex, wEndIndex - wStartIndex));
        }
    }
}

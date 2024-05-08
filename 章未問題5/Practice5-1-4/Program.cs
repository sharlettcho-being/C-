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
            var wNoveList = GetData(wText, "NoveList=");

            //代表作を取得する
            var wBestWork = GetData(wText, "BestWork=");

            //誕生日を取得する
            var wBorn = GetData(wText, "Born=");

            Console.WriteLine($"作家　: {wNoveList}\n代表作: {wBestWork}\n誕生日: {wBorn}");

        }

        /// <summary>
        /// 指定されたテキストから指定された値の後に出現するセミコロンまでの部分文字列を取得します。
        /// </summary>
        /// <param name="vText"></param>
        /// <param name="vValue"></param>
        /// <returns>文字列</returns>
        public static String GetData(string vText, string vValue) {
             // 指定された値の Index にその値の長さを加え、取得したい文字列のスタート位置を計算する
            int wStartIndex = vText.IndexOf(vValue) + vValue.Length;

            // スタート位置からセミコロンまでの文字列のエンド位置を計算する
            int wEndIndex = vText.IndexOf(";", wStartIndex);

            // もしセミコロンが見つからない場合は、テキストの最後をエンド位置とする
            if (wEndIndex == -1) {
                wEndIndex = vText.Length;
            }

            // スタート位置からエンド位置までの間の部分文字列を取得し、それを戻り値として返す
            if ((wStartIndex > 0) & (wEndIndex > 0)) {
                return (vText.Substring(wStartIndex, wEndIndex - wStartIndex));
            } 
            else {
                return null;
            }
           
        }
    }
}

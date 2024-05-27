using System.Net;

namespace Practice14_1_4 {
    internal class Program {
        static void Main(string[] args) {
            var wUrl = "https://jisho.org/";
            var wFileName = "HTMLをファイルに保存したもの.html";

            // usingステートメントを使ってWebClientを作成し、リソースを適切に解放する
            using (var wClient = new WebClient()) {
                wClient.DownloadFile(wUrl, wFileName);
            }
        }
    }
}

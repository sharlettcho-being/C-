using System.Net;

namespace Practice14_1_4 {
    internal class Program {
        static void Main(string[] args) {
            var wClient = new WebClient();
            var wUrl = "https://jisho.org/";
            var wFileName = "HTMLをファイルに保存したもの.html";
            wClient.DownloadFile(wUrl, wFileName);
        }
    }
}

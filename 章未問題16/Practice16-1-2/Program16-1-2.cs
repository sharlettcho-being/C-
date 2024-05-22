using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Practice16_1_2 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\C#のソースファイル";

            //指定したディレクトリの配下にある「.cs」ファイルを取得
            var wCSFiles = Directory.GetFiles(wFilePath, "*.cs", SearchOption.AllDirectories);

            // 時間計測の開始
            var wStopwatch = Stopwatch.StartNew();

            var wFilesWithAsyncAwait = wCSFiles.AsParallel().Where(x => {
                var wFileContent = File.ReadAllText(x);
                return wFileContent.Contains("async") && wFileContent.Contains("await");
            });
            // 列挙したファイルのフルパスを表示
            foreach (var wFile in wFilesWithAsyncAwait) {
                Console.WriteLine(wFile);
            }

            // 時間計測の終了
            wStopwatch.Stop();
            Console.WriteLine($"Parallel Time: {wStopwatch.ElapsedMilliseconds} ms");
        }
    }
}

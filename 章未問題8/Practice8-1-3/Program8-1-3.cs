using System;

namespace Practice8_1_3 {
    /// <summary>
    /// ある処理を計測する
    /// </summary>
    internal class Program {
        static void Main(string[] args) {
            var wTimeWatch = new TimeWatch();
            wTimeWatch.Start();
            Console.WriteLine("処理します。");
            Console.WriteLine("処理します。");

            TimeSpan wDuration = wTimeWatch.Stop();
            Console.WriteLine("処理時間は{0}ミリ秒でした", wDuration.TotalMilliseconds);
        }
    }
}

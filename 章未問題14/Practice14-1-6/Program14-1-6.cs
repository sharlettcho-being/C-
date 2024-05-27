using System;

namespace Practice14_1_6 {
    internal class Program {
        static void Main(string[] args) {
            //UTC(協定世界時）
            var wUtcTime = DateTimeOffset.UtcNow;

            //東京の現地時間を取る
            var wTokyoTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            var wTokyoTime = TimeZoneInfo.ConvertTime(wUtcTime, wTokyoTimeZone);
            Console.WriteLine(wTokyoTime);

            //シンガポールの時間を取る
            var wSingaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            var wSingaporeTime = TimeZoneInfo.ConvertTime(wUtcTime, wSingaporeTimeZone);
            Console.WriteLine(wSingaporeTime);
        }
    }
}

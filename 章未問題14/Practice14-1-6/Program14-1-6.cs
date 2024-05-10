using System;

namespace Practice14_1_6 {
    internal class Program {
        static void Main(string[] args) {
            //UTC(協定世界時）
            var wUtcTime = DateTimeOffset.UtcNow;

            //東京の現地時間を取る
            TimeZoneInfo wTokyoTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            DateTimeOffset wTokyoTime = TimeZoneInfo.ConvertTime(wUtcTime, wTokyoTimeZone);
            Console.WriteLine(wTokyoTime);

            //シンガポールの時間を取る
            TimeZoneInfo wSingaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            DateTimeOffset wSingaporeTime = TimeZoneInfo.ConvertTime(wUtcTime, wSingaporeTimeZone);
            Console.WriteLine(wSingaporeTime);
        }
    }
}

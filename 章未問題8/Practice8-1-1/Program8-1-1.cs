using System;
using System.Globalization;

namespace Practice8_1_1 {
    internal class Program {
        /// <summary>
        /// 現在の日時を3種類の書式で表す
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var wCurrentDate = DateTime.Now;

            //〇/〇/〇　〇:〇　の書式での表示
            Console.WriteLine(wCurrentDate.ToString("yyyy/MM/dd  HH:mm"));

            //〇年〇月〇日　〇時〇分〇秒　の書式での表示
            Console.WriteLine(wCurrentDate.ToString("yyyy年MM月dd日 hh時mm分ss秒"));

            var wCulture = new CultureInfo("ja-JP");
            wCulture.DateTimeFormat.Calendar = new JapaneseCalendar();

            //〇〇年〇月〇日（〇曜日）＜和暦＞の書式での表示
            Console.WriteLine(wCurrentDate.ToString("ggyy年M月d日(ddd)", wCulture));
        }
    }
}

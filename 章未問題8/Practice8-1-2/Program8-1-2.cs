using System;

namespace Practice8_1_2 {
    internal class Program {
        /// <summary>
        /// 次の週の指定曜日を求める
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var wToday = DateTime.Today;
            var wDayUntilTarget = wToday.AddDays(7);
            DayOfWeek wTargetDay = DayOfWeek.Sunday; // 次の週の日曜日を求める例
            DateTime wNextWeekDay = GetNextWeekDay(wDayUntilTarget, wTargetDay);
            Console.WriteLine($"次の週の{wTargetDay}は : {wNextWeekDay} です。");
        }

        /// <summary>
        /// 次の週の指定曜日を求める
        /// </summary>
        /// <param name="vDate">次の週の日</param>
        /// <param name="vDayOfWeek">指定した日</param>
        /// <returns>次の週の曜日</returns>
        public static DateTime GetNextWeekDay(DateTime vDate, DayOfWeek vDayOfWeek) {
            var wNextWeekDay = (int)vDayOfWeek - (int)(vDate.DayOfWeek);
            if (wNextWeekDay <= 0) {
                wNextWeekDay += 7;
            }
            return vDate.AddDays(wNextWeekDay);
        }
    }
}

using System;
using System.Linq;
using Practice4_1_1;

namespace Practice4_1_2 {
    internal class Program{
        static void Main(string[] args){
            YearMonth[] wYearMonths = new YearMonth[5]{
            new YearMonth(2124, 4),
            new YearMonth(2124, 5),
            new YearMonth(2124, 6),
            new YearMonth(2124, 7),
            new YearMonth(2124, 8)
            };

            Console.WriteLine("--------配列にある初期値---------");
            // 配列の要素を表示する
            foreach (YearMonth yearMonth in wYearMonths) {
                Console.WriteLine(yearMonth);
            }

            //最初の21世紀を調べる
            var wFirst21Century = FindFirst21stCenturyYearMonth(wYearMonths);
            if(wFirst21Century != null){
                Console.WriteLine($"最初にみつかった21世紀：　{wFirst21Century}");
            }
            else{
                Console.WriteLine("21世紀のデータはありません");
            }

            YearMonth[] wOneMonthAfterChangedMonth = wYearMonths.Select(x => x.AddOneMonth()).ToArray();

            Console.WriteLine("--------1カ月後に変更した値---------");

            foreach (YearMonth nextMonth in wOneMonthAfterChangedMonth) {
                Console.WriteLine(nextMonth);
            }
        }
        //最初にみつかった21世紀を調べる
        public static YearMonth FindFirst21stCenturyYearMonth(YearMonth[] vYearMonths){
            foreach (YearMonth yearMonth in vYearMonths) {
                if (yearMonth.Is21Century){
                    //見つかったYearMonthを返す
                    return yearMonth;
                }
            }
            return null; // 21世紀のYearMonthが見つからなかった場合はnullを返す
        }
    }
}

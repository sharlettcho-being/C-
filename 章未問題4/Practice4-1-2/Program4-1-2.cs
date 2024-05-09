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
            foreach (YearMonth wYearMonth in wYearMonths) {
                Console.WriteLine(wYearMonth);
            }

            //最初の21世紀を調べる
            var wFirst21Century = wYearMonths.Where(x => x.Year >= 2001 && x.Year <= 2100).FirstOrDefault();
            if (wFirst21Century != null){
                Console.WriteLine($"最初にみつかった21世紀：　{wFirst21Century}");
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }

            YearMonth[] wOneMonthAfterChangedMonth = wYearMonths.Select(x => x.AddOneMonth()).ToArray();

            Console.WriteLine("--------1カ月後に変更した値---------");

            foreach (YearMonth wNextMonth in wOneMonthAfterChangedMonth) {
                Console.WriteLine(wNextMonth);
            }
        }
    }
}

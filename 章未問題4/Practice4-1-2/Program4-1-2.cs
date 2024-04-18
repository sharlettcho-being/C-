using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice4_1_1;

namespace Practice4_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YearMonth[] yearMonths = new YearMonth[5]
            {
            new YearMonth(2124, 4),
            new YearMonth(2124, 5),
            new YearMonth(2124, 6),
            new YearMonth(2124, 7),
            new YearMonth(2124, 8)
            };

            Console.WriteLine("--------配列にある初期値---------");
            // 配列の要素を表示する
            foreach (YearMonth yearMonth in yearMonths)
            {
                Console.WriteLine(yearMonth);
            }

            //最初の21世紀を調べる
            YearMonth result = FindFirst21stCenturyYearMonth(yearMonths);
            if(result != null)
            {
                Console.WriteLine($"最初にみつかった21世紀：　{result}");
            }
            else
            {
                Console.WriteLine("21世紀のデータはありません");
            }

            YearMonth[] nextMonths = yearMonths.Select(x => x.AddOneMonth()).ToArray();

            Console.WriteLine("--------1カ月後に変更した値---------");

            foreach (YearMonth nextMonth in nextMonths)
            {
                Console.WriteLine(nextMonth);
            }

        }
        //最初にみつかった21世紀を調べる
        public static YearMonth FindFirst21stCenturyYearMonth(YearMonth[] yearMonths)
        {
            foreach (YearMonth yearMonth in yearMonths)
            {
                if (yearMonth.Is21Century)
                {
                    //見つかったYearMonthを返す
                    return yearMonth;
                }
            }
            return null; // 21世紀のYearMonthが見つからなかった場合はnullを返す
        }
    }
}

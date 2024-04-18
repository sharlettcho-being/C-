using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_1_1
{
    internal class YearMonth
    {
        public int Year { get; private set;}
        public int Month { get; private set; }

        public YearMonth(int year, int month)
        {
            this.Year = year;
            this.Month = month;
        }
        public bool Is21Century
        {
            get
            {
                return Year >= 2001 && Year <= 2100;
            }
        }

        public YearMonth AddOneMonth()
        {
            YearMonth newYearMonth = new YearMonth(Year, Month);
            newYearMonth.Year = Year;
            newYearMonth.Month = Month;

            //12月の場合
            if (Month == 12)
            {
                newYearMonth.Year++;
                newYearMonth.Month = 1;
            }
            else
            {
                newYearMonth.Month++;
            }

            return newYearMonth;
            
        }
        public override string ToString()
        {
            return ($"{Year}年{Month}月");
        }

    }
}

namespace Practice4_1_1 {
    /// <summary>
    /// Year,Monthを持っているクラス
    /// </summary>
    internal class YearMonth{
        /// <summary>
        /// 年の値を取得します。
        /// </summary>
        /// /// <remarks>
        /// このプロパティは年の値を表します。
        /// </remarks>
        public int Year { get; private set;}

        /// <summary>
        /// 月の値を取得します。
        /// </summary>
        /// <remarks>
        /// このプロパティは月の値を表します。
        /// </remarks>
        public int Month { get; private set; }

        public YearMonth(int vYear, int vMonth){
            this.Year = vYear;
            this.Month = vMonth;
        }

        /// <summary>
        /// 21世紀のデータかどうかのチェック
        /// </summary>
        public bool Is21Century{
            get{
                return Year >= 2001 && Year <= 2100;
            }
        }

        /// <summary>
        /// 1カ月後を求める
        /// </summary>
        /// <returns>1カ月後の年・月を返す</returns>
        public YearMonth AddOneMonth(){
            YearMonth wNewYearMonth = new YearMonth(Year, Month);
            wNewYearMonth.Year = Year;
            wNewYearMonth.Month = Month;

            //12月の場合
            if (Month == 12){
                wNewYearMonth.Year++;
                wNewYearMonth.Month = 1;
            }
            else{
                wNewYearMonth.Month++;
            }

            return wNewYearMonth;            
        }

        /// <summary>
        /// ToStringメソッドをオーバーライドする
        /// </summary>
        /// <returns>〇〇年○○月の形を返す</returns>
        public override string ToString(){
            return ($"{Year}年{Month}月");
        }
    }
}

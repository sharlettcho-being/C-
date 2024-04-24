using System;

namespace Practice4_1_1 {
    internal class Program{
        //Constant変数の定義
        private static string C_MESSAGE = "21世紀です。";
        private static string C_MESSAGE2 = "21世紀ではありません。";

        static void Main(string[] args){
            // ユーザーから年を入力してもらう
            Console.Write("年を入力してください: ");
            int wYear = int.Parse(Console.ReadLine());

            Console.WriteLine("月は1～12までの範囲でお願いします。");
            // ユーザーから月を入力してもらう
            Console.Write("月を入力してください: ");
            
            int wMonth = int.Parse(Console.ReadLine());

            YearMonth wCurrentMonth = new YearMonth(wYear, wMonth);
            Console.WriteLine("記入した時期: " + wCurrentMonth);
            if (wCurrentMonth.Is21Century) {
                Console.WriteLine(C_MESSAGE);
            } else {
                Console.WriteLine(C_MESSAGE2);
            }

            YearMonth wNextMonth = wCurrentMonth.AddOneMonth();
            Console.WriteLine("1か月後: " + wNextMonth);
            if (wNextMonth.Is21Century) {
                Console.WriteLine(C_MESSAGE);
            } 
            else {
                Console.WriteLine(C_MESSAGE2);
            }
        }
    }
}

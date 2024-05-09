using System;

namespace Practice4_1_1 {
    internal class Program{

        static void Main(string[] args){

            // ユーザーから年を入力してもらう
            Console.Write("年を入力してください: ");

            int.TryParse(Console.ReadLine(), out int wYear);

            Console.WriteLine("月は1～12までの範囲でお願いします。");
            // ユーザーから月を入力してもらう
            Console.Write("月を入力してください: ");
            
            int.TryParse(Console.ReadLine(), out int wMonth);

            YearMonth wCurrentMonth = new YearMonth(wYear, wMonth);
            Console.WriteLine("記入した時期: " + wCurrentMonth);

            Console.WriteLine(wCurrentMonth.Is21Century ? "21世紀です。" : "21世紀ではありません。");

            YearMonth wNextMonth = wCurrentMonth.AddOneMonth();
            Console.WriteLine("1か月後: " + wNextMonth);

            Console.WriteLine(wNextMonth.Is21Century ? "21世紀です。" : "21世紀ではありません。");
        }
    }
}

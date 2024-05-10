using System;
using System.IO;

namespace Practice4_1_1 {
    internal class Program{

        static void Main(string[] args){
            bool wValidInput = false;
            int wYear = 0;
            int wMonth = 0;

            while (!wValidInput) {
                // ユーザーから年を入力してもらう
                Console.Write("年を入力してください: ");

                if (int.TryParse(Console.ReadLine(), out wYear)) {
                    wValidInput = true;
                } else {
                    // 数字以外の入力の場合、エラーメッセージを表示
                    Console.WriteLine("正しい形式で入力してください。");
                }
            }
            wValidInput = false;
            while (!wValidInput) { 

                Console.WriteLine("月は1～12までの範囲でお願いします。");
                // ユーザーから月を入力してもらう
                Console.Write("月を入力してください: ");

                if (int.TryParse(Console.ReadLine(), out wMonth)) {
                    wValidInput = true;
                } else {
                    // 数字以外の入力の場合、エラーメッセージを表示
                    Console.WriteLine("正しい形式で入力してください。");
                }

            }           
            if (wYear > 0 && wMonth > 0) {
                YearMonth wCurrentMonth = new YearMonth(wYear, wMonth);
                Console.WriteLine("記入した時期: " + wCurrentMonth);

                Console.WriteLine(wCurrentMonth.Is21Century ? "21世紀です。" : "21世紀ではありません。");

                YearMonth wNextMonth = wCurrentMonth.AddOneMonth();
                Console.WriteLine("1か月後: " + wNextMonth);

                Console.WriteLine(wNextMonth.Is21Century ? "21世紀です。" : "21世紀ではありません。");
            } else {
                Console.WriteLine("年と月が０になっているので計算できません！");
            }        

        }
    }
}

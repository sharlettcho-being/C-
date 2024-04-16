using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = -1;
            var names = new List<string> {"Tokyo", "New Delhi", "Bangkok", "London", "Paris",
                        "Berlin", "Canberra", "Hong Kong"};

            //質問①=>FindIndexを使って入力された名を調べる
            Console.WriteLine("都市名を記入お願いします！");
            string wCityName = Console.ReadLine();

            Console.WriteLine("入力された名が何番目にあるか？");

            index = names.FindIndex(s => s.ToLower() == wCityName.ToLower());
            if (index > 0)
                Console.WriteLine(index);
            else Console.WriteLine(index);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("小文字 'o'が含まれている都市名のカウント");

            //質問②=>小文字 'o'が含まれている都市名のカウントを計算する
            int count = names.Where(s => s.Contains('o')).Count();
            Console.WriteLine(count);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("小文字 'o'が含まれている都市名");

            //質問③=>Whereを使って、小文字 'o'が含まれている都市名を表示する
            var count2 = names.Where(s => s.Contains('o')).ToArray();
            foreach(var cityname in count2)
            {
                Console.WriteLine(cityname);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("'B'で始まる都市名の文字数");

            //質問④=>'B'で始まる都市名の文字数
            var result = names.Where(x => x[0] == 'B').Select(x => x.Length);
            foreach(var length in result)
            {
                Console.WriteLine(length);
            }            

        }
    }
}

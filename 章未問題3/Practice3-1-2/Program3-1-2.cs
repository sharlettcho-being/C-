using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_1_2 {
    internal class Program{
        /// <summary>
        /// 都市名が格納されているリストに関しての処理
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args){
            //初期化
            int wIndex = -1;
            var wCityNameList = new List<string> {"Tokyo", "New Delhi", "Bangkok", "London", "Paris",
                        "Berlin", "Canberra", "Hong Kong"};

            //質問①=>FindIndexを使って入力された名を調べる
            Console.WriteLine("都市名を記入お願いします！");
            string wCityName = Console.ReadLine();

            Console.WriteLine("入力された名が何番目にあるか？");

            wIndex = wCityNameList.FindIndex(x => x.ToLower() == wCityName.ToLower());
            if (wIndex > 0) {
                Console.WriteLine(wIndex);
            } 
            else {
                Console.WriteLine(wIndex);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("小文字 'o'が含まれている都市名のカウント");

            //質問②=>小文字 'o'が含まれている都市名のカウントを計算する
            int wCityNameCountIncludeLowerCaseO = wCityNameList.Where(x => x.Contains('o')).Count();
            Console.WriteLine(wCityNameCountIncludeLowerCaseO);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("小文字 'o'が含まれている都市名");

            //質問③=>Whereを使って、小文字 'o'が含まれている都市名を表示する
            var wCityNameIncludeLowerCaseO = wCityNameList.Where(x => x.Contains('o')).ToArray();
            foreach(var cityname in wCityNameIncludeLowerCaseO) {
                Console.WriteLine(cityname);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("'B'で始まる都市名の文字数");

            //質問④=>'B'で始まる都市名の文字数
            var wCitynameLengthBeginingWithB = wCityNameList.Where(x => x[0] == 'B').Select(x => x.Length);
            foreach(var length in wCitynameLengthBeginingWithB) {
                Console.WriteLine(length);
            }         
        }
    }
}

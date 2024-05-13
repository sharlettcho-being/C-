using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_1_1 {
    internal class Program{
        /// <summary>
        /// リストにある整数値に関しての処理
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args){
            var wNumbersList = new List<int> {12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48};

            Console.WriteLine("リストでの要素を８か９で割り切れる数があるかどうか？");
            //質問①＝＞リストでの要素を８か９で割り切れる数があるかどうか
            var wHasElements8Or9byDivisibleNumber = wNumbersList.Exists(x => x % 8 == 0 || x % 9 == 0);
            Console.WriteLine(wHasElements8Or9byDivisibleNumber);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("リストの各要素を2.0で割った値");

            //質問②＝＞リストの各要素を2.0で割った値
            wNumbersList.ForEach(x => Console.WriteLine(x / 2.0));

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("リストでの値が50以上の要素");

            //質問③＝＞リストでの値が50以上の要素
            var wValuesAbove50 = wNumbersList.Where(x => x >= 50);
            foreach(var wItem in wValuesAbove50){
                Console.WriteLine(wItem);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("リストでの値を2倍にした結果");

            //質問④＝＞リストでの値を2倍にしてリストに格納する
            var wDoubledValuesList = wNumbersList.Select(x => x * 2).ToList();
            foreach(var wItem in wDoubledValuesList){
                Console.WriteLine(wItem);
            }
        }
    }
}

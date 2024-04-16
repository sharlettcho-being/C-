using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48};

            Console.WriteLine("リストでの要素を８か９で割り切れる数があるかどうか？");
            //質問①＝＞リストでの要素を８か９で割り切れる数があるかどうか
            var exist = numbers.Exists(x => x % 8 == 0 || x % 9 == 0);
            Console.WriteLine(exist);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("リストの各要素を2.0で割った値");

            //質問②＝＞リストの各要素を2.0で割った値
            numbers.ForEach(x => Console.WriteLine(x / 2.0));

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("リストでの値が50以上の要素");

            //質問③＝＞リストでの値が50以上の要素
            var number = numbers.Where(x => x >= 50);
            foreach(var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("リストでの値を2倍にした結果");

            //質問④＝＞リストでの値を2倍にしてリストに格納する
            List<int> query = numbers.Select(x => x * 2).ToList();
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }


        }
    }
}

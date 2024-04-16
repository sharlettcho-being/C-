using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ユーザーからの入力を受け取る
            Console.WriteLine("インチからメートルへ変換したい場合「itom」、メートルからインチに変換したい場合「mtoi」と記入してください。");
            string wInput = Console.ReadLine();

            //インチからメートルへの変換
            if (wInput == "itom")
            {
                PrintInchToMeterList(1, 10);
            }
            //メートルからインチへの変換
            else if (wInput == "mtoi")
            {
                PrintMeterToInch(1, 10);
            }
            else
            {
                Console.WriteLine("お疲れさまでした！");
            }
        }
        static void PrintInchToMeterList(int vStart, int vEnd)
        {
            Console.WriteLine("インチからメートルへ変換");
            for (int i = vStart; i <= vEnd; i++)
            {
                double wMeter = InchesConverter.ToMeter(i);
                Console.WriteLine("{0} in = {1:0.0000}m", i, wMeter);
            }
        }

        static void PrintMeterToInch(int vStart, int vEnd)
        {
            Console.WriteLine("メートルからインチへ変換");
            for (int i = vStart; i <= vEnd; i++)
            {
                double wInch = InchesConverter.FromMeter(i);
                Console.WriteLine("{0} m = {1:0.0000}in", i, wInch);
            }
        }
    }
}

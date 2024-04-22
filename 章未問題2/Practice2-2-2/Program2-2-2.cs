using System;

namespace Practice2_2_2{
    internal class Program{
        /// <summary>
        /// インチからメートル、メートルからインチへの変換表を出力
        /// </summary>
        /// <param name="args">ユーザーから"itom"か”mtoi”か記入してもらう</param>
        static void Main(string[] args){
            // ユーザーからの入力を受け取る
            Console.WriteLine("インチからメートルへ変換したい場合「itom」、メートルからインチに変換したい場合「mtoi」と記入してください。");
            string wInput = Console.ReadLine();

            //インチからメートルへの変換
            if (wInput == "itom"){
                PrintInchToMeterList(1, 10);
            }
            //メートルからインチへの変換
            else if (wInput == "mtoi"){
                PrintMeterToInch(1, 10);
            }
            else{
                Console.WriteLine("お疲れさまでした！");
            }
        }

        /// <summary>
        /// インチからメートルへの対応表を出力
        /// </summary>
        /// <param name="vStart">開始値</param>
        /// <param name="vEnd">終了値</param>
        static void PrintInchToMeterList(int vStart, int vEnd){
            Console.WriteLine("インチからメートルへ変換");
            for (int i = vStart; i <= vEnd; i++){
                double wMeter = InchesConverter.ToMeter(i);
                Console.WriteLine($"{i} in = {wMeter:0.0000}m");
            }
        }

        /// <summary>
        /// メートルからインチへの対応表を出力
        /// </summary>
        /// <param name="vStart">開始値</param>
        /// <param name="vEnd">終了値</param>
        static void PrintMeterToInch(int vStart, int vEnd){
            Console.WriteLine("メートルからインチへ変換");
            for (int i = vStart; i <= vEnd; i++){
                double wInch = InchesConverter.FromMeter(i);
                Console.WriteLine($"{i} m = {wInch:0.0000} in");
            }
        }
    }
}

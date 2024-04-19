using System;

namespace Practice5_1_2 {
    internal class Program {
        /// <summary>
        /// 数字文字列をカンマ付きの数字文字列に変換
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            int wNumber;
            Console.WriteLine("数字文字列を記入お願いします。");
           int.TryParse(Console.ReadLine(), out wNumber);

           Console.WriteLine($"{wNumber:#,0}");
        }
    }
}

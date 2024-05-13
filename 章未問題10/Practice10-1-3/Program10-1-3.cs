using System;
using System.Text.RegularExpressions;

namespace Practice10_1_3 {
    internal class Program {
        static void Main(string[] args) {
            //初期化
            var wTexts = new[] {
                "Time is money",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable."
            };
            var wRegex = @"[Tt]ime";
            foreach(var wText in wTexts) {
                Match wString = Regex.Match(wText, wRegex);
                if (wString.Success) {
                    Console.WriteLine($"{wString.Index}{wString.Value}");
                }
            }          
        }
    }
}

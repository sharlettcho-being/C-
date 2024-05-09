using System;
using System.Text.RegularExpressions;

namespace Practice10_1_1 {
    internal class Program {
        /// <summary>
        /// 指定された文字列は携帯電話の電話番号かどうか判断する。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var wPhoneNumber = "080-3561-6596";

            var wRegex = @"^0\d{2,4}-\d";

            bool IsMatch = Regex.IsMatch(wPhoneNumber, wRegex);

            if (IsMatch) {
                Console.WriteLine($"{wPhoneNumber} は携帯電話の電話番号です。");
            } else {
                Console.WriteLine($"{wPhoneNumber} は携帯電話の電話番号ではありません。");
            }

        }
    }
}

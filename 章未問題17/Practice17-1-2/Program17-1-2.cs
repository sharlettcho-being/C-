using System;

namespace Practice17_1_2 {
    internal class Program {
        static void Main(string[] args) {
            var wFrom = new YardConverter();
            var wTo = new FeetConverter();
            var wConverter = new DistanceConverter(wFrom, wTo);
            var wConvertValue = wConverter.Convert(12, "To");
            Console.WriteLine(wConvertValue);
        }
    }
}

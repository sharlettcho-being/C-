namespace Practice17_1_3 {
    internal class Program {
        static void Main(string[] args) {
            var wFileName = @"..\..\Sample17-1.txt";
            var wChangeDigit = new ChangeDigitZenToHanProcessor();
            var wTxtProcessor = new TextFileProcessor(wChangeDigit);
            wTxtProcessor.Run(wFileName);
        }
    }
}

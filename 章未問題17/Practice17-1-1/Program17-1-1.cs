namespace Practice17_1_1 {
    internal class Program {
        static void Main(string[] args) {
            var wFileName = @"..\..\Sample17-1.txt";
            TextFileProcessor.Run<ChangeDigitZenToHanProcessor>(wFileName);
        }
    }
}

using System;

namespace Practice7_1_2 {
    internal class Program {
        static void Main(string[] args) {
            var wAbbrs = new Abbreviations();

            wAbbrs.Add("IOC", "国際オリンピック委員会");
            wAbbrs.Add("NPT", "核兵器不拡散条約");

            var wNames = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in wNames) {
                var wfullname = wAbbrs[name];
                if (wfullname == null) {
                    Console.WriteLine("{0}は見つかりません。", name);
                }                    
                else {
                    Console.WriteLine("{0}={1}", name, wfullname);
                }
            }
            Console.WriteLine();

            var wJapanese = "東南アジア諸国連合";
            var wAbbreviation = wAbbrs.ToAbbreviation(wJapanese);
            if (wAbbreviation == null) {
                Console.WriteLine("{0}は見つかりません", wJapanese);
            } 
            else {
                Console.WriteLine("「{0}」の略語は{1}です。", wJapanese, wAbbreviation);
            }
               
            Console.WriteLine();

            foreach (var item in wAbbrs.FindAll("国際")) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

            //演習問題「7.2」の「3」ディクショナルに登録されいる用語の数を返す
            Console.WriteLine("登録されている用語の数は　: {0}", wAbbrs.Count().ToString());

            //演習問題「7.2」の「3」Removeメソッドを使って省略語を削除する
            var wRemoveKey = "WHO";
            var wResult = wAbbrs.Remove(wRemoveKey);
            if(wResult){
                Console.WriteLine("\n{0}が削除できました！", wRemoveKey);
            } 
            else
            {
                Console.WriteLine("\n{0}が見つかりません。", wRemoveKey);
            }
            Console.WriteLine();
            
            var wNewDict = wAbbrs.GetAbbreviationsOnlyThreeCharacter();
            foreach(var item in wNewDict) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
        }
    }
}

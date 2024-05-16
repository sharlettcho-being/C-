using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_2 {
    internal class Program {
        static void Main(string[] args) {
            // 相対パスを使用してファイルにアクセスする例
            string wXMLFilePath = @"..\..\Sample11-2.xml";

            string wSaveFilePath = @"..\..\Sample11 -2New.xml";

            var wXDoc = XDocument.Load(wXMLFilePath);
   
            // 新しいXMLを作成
            var wNewDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", ""),
                new XElement("difficultkanji",
                // 各word要素を変換
                wXDoc.Root.Elements("word")
                    .Select(x =>
                        new XElement("word",
                        new XAttribute("kanji", x.Element("kanji").Value),
                        new XAttribute("yomi", x.Element("yomi").Value)
                        )
                    )
                )
            );
            wNewDoc.Save(wSaveFilePath);
        }
    }
}

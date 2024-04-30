using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_2 {
    internal class Program {
        /// <summary>
        /// XMLファイルの形式を変換し、別のファイルに保存する
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            string wXMLFilePath = "C:\\Users\\sharlettcho\\Desktop\\Sample11-2.xml";
            var wXDoc = XDocument.Load(wXMLFilePath);
   
            // 新しいXMLを作成
            XDocument wNewDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", ""),
                new XElement("difficultkanji",
                    // 各word要素を変換
                    wXDoc.Root.Elements("word").Select(x =>
                        new XElement("word",
                        new XAttribute("kanji", x.Element("kanji").Value),
                        new XAttribute("yomi", x.Element("yomi").Value)
                        )
                    )
                )
            );
            wNewDoc.Save("C:\\Users\\sharlettcho\\Desktop\\Sample11 -2New.xml");
        }
    }
}

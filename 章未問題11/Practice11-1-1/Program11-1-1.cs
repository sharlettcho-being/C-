using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_1 {
    internal class Program {
        static void Main(string[] args) {
            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Sample11-1.xml";
            string wSaveFileRelativePath = @"..\..\Sample11-1.xml";

            // 実際のファイルパスを取得
            string wXMLFilePath = Path.Combine(wCurrentDirectory, wRelativePath);
            string wSaveFilePath = Path.Combine(wCurrentDirectory, wSaveFileRelativePath);

            var wXDoc = XDocument.Load(wXMLFilePath);
            var wElements = wXDoc.Root.Elements();

            DisplayGamenameAndTeammembreCount(wElements);
            DisplaySportsByFirstPlayed(wElements);
            DisplaySportWithMostMember(wElements);
            AddSoccerInfoAndSaveToFile(wXDoc, wSaveFilePath, "サッカー", 11, 1863);

        }

        /// <summary>
        /// XMLファイルから教示名とチームメンバー数を表示する
        /// </summary>
        /// <param name="vElements">XMLファイルの要素</param>
        public static void DisplayGamenameAndTeammembreCount(IEnumerable<XElement> vElements) {
            foreach (var wElement in vElements) {
                XElement wName = wElement.Element("name");
                var wTeamMember = wElement.Element("teammembers");
                Console.WriteLine($"{wName.Value} : {wTeamMember.Value}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 最初にプレーされた年の若い順に漢字の競技名を表示する
        /// </summary>
        /// <param name="vElements">XMLファイルの要素</param>
        public static void DisplaySportsByFirstPlayed(IEnumerable<XElement> vElements) {
            var wPlayerList = vElements.OrderBy(x => (int.Parse(x.Element("firstplayed").Value)));
            foreach (var wPlayer in wPlayerList) {
                Console.WriteLine(wPlayer.Element("name").Attribute("kanji").Value);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// メンバー人数が最も多い競技名を表示する
        /// </summary>
        /// <param name="vElements"></param>
        public static void DisplaySportWithMostMember(IEnumerable<XElement> vElements) {
            var wMaxCount = vElements.Max(x => int.Parse(x.Element("teammembers").Value));
            var wSportWithMostMembers = vElements.FirstOrDefault(x => int.Parse(x.Element("teammembers").Value) == wMaxCount);

            Console.WriteLine(wSportWithMostMembers.Element("name").Value);
            Console.WriteLine();
        }

        /// <summary>
        /// サッカーの情報を追加し、新たなXMLファイルを出力する
        /// </summary>
        /// <param name="vXdoc">存在しているドキュメント</param>
        /// <param name="vFilePath">新たな作成するファイルのパス</param>
        /// <param name="vSoccerName">サッカー名</param>
        /// <param name="vSoccerTeamMembers">チームメンバー数</param>
        /// <param name="vSoccerFirstPlayed">プレーされた年</param>
        public static void AddSoccerInfoAndSaveToFile(XDocument vXdoc, string vFilePath, string vSoccerName, int vSoccerTeamMembers, int vSoccerFirstPlayed) {
            XElement soccerElement = new XElement("ballsport",
            new XElement("name", new XAttribute("kanji", "蹴球"), vSoccerName),
            new XElement("teammembers", vSoccerTeamMembers),
            new XElement("firstplayed", vSoccerFirstPlayed));
            vXdoc.Root.Add(soccerElement);

            // 新しいXMLファイルに保存
            vXdoc.Save(vFilePath);

            Console.WriteLine("サッカーの情報を追加した新しいXMLファイルが作成されました！ "); 
        }
    }
}

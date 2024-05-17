using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Practice12_1_2 {

    /// <summary>
    /// 小説家の情報を表すクラス
    /// </summary>
    [XmlRoot("novelist")]
    [DataContract(Name = "novel")]
    public class NoveList {
        /// <summary>
        /// 小説家の名前を取得または設定
        /// </summary>
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// 小説家の生年月日を取得または設定
        /// </summary>
        [XmlElement(ElementName = "birth")]
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }

        /// <summary>
        /// 小説家の代表作のリストを取得または設定
        /// </summary>
        [XmlArray("masterpeices")]
        [DataMember(Name = "masterpiece")]
        [XmlArrayItem("title", typeof(string))]
        public string[] Masterpieces { get; set; }
    }
    internal class Program {
        static void Main(string[] args) {
            var wNovelist = new NoveList {
                Name = "アーサー・C・クラーク",
                Birth = new DateTime(1917, 12, 16),
                Masterpieces = new string[] {
                    "2001年守宙の旅",
                    "幼年期の終り"
                }
            };

            //Xmlファイルでの設定
            var wSettings = new XmlWriterSettings {
                Indent = true,
                IndentChars = " ",
                Encoding = Encoding.UTF8,
            };

            // 名前空間の出力を制御するためのXmlSerializerNamespacesオブジェクトを作成
            var wNamespaces = new XmlSerializerNamespaces();
            wNamespaces.Add("", ""); // 名前空間を空に設定

            //XmlSerializerを使ってシリアル化にする
            using (var wWriter = XmlWriter.Create("novelist.xml", wSettings)) {
                var wXmlSerializer = new XmlSerializer(wNovelist.GetType());
                wXmlSerializer.Serialize(wWriter, wNovelist, wNamespaces);
            }

            //XmlSerializerを使って逆シリアル化にする
            using (var wReader = XmlReader.Create("novelist.xml")) {
                var wDeserializer = new XmlSerializer(typeof(NoveList));
                var wNoveList = wDeserializer.Deserialize(wReader) as NoveList;
                Console.WriteLine($"{wNoveList.Name}\n{wNoveList.Birth}");
                foreach (var wNovel in wNoveList.Masterpieces) {
                    Console.WriteLine(wNovel);
                }
            }

            //日付の表示についての設定
            var wJsonSettings = new DataContractJsonSerializerSettings {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss"),
            };

            //JSONファイルに逆シリアル化にする
            using (var wStream = new FileStream("novel.json", FileMode.Create, FileAccess.Write))
            using (var wJsonWriter = JsonReaderWriterFactory.CreateJsonWriter(wStream, Encoding.UTF8, true, true, " ")) {
                var wJsonSerializer = new DataContractJsonSerializer(typeof(NoveList), wJsonSettings);
                wJsonSerializer.WriteObject(wJsonWriter, wNovelist);
            }
        }
    }
}

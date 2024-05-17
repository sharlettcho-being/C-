using System;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Practice12_1_1 {
    /// <summary>
    /// 従業員クラス
    /// </summary>
    [XmlRoot("employee")]
    [DataContract(Name = "employee")]
    public class Employee {

        /// <summary>
        /// 従業員の一意の識別子
        /// </summary>
        [XmlElement(ElementName = "id")]
        [IgnoreDataMember]
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// 従業員の名前
        /// </summary>
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// 従業員の採用日
        /// </summary>
        [XmlElement(ElementName = "hiredate")]
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }
    }
    internal class Program {
        static void Main(string[] args) {
            var wEmployees = new Employee[] {
                new Employee{
                    Id = 1,
                    Name = "桜子",
                    HireDate = DateTime.Today,
                },
                new Employee {
                    Id = 2,
                    Name = "桜華",
                    HireDate = new DateTime(2024, 6, 29),
                },
                new Employee {
                    Id = 3,
                    Name = "桜太郎",
                    HireDate = new DateTime (2024,04,25),
                }
            };

            // XMLシリアライゼーション設定
            var wSettings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            // JSONシリアライゼーション設定
            var wJsonSettings = new DataContractJsonSerializerSettings {
                //日付の表示についての設定
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            };

            //オブジェクトをシリアル化にする。
            SerializeObject(wSettings);
            //オブジェクトを逆シリアル化にする。
            DeserializeObject();
            //複数のオブジェクトが格納されている配列をシリアル化にする。
            SerializeObjectArray(wEmployees, wSettings);
            //複数のオブジェクトが格納されている配列を逆シリアル化にする。
            DeserializeObjectArray();
            //複数のオブジェクトが格納されている配列をJSONファイルに出力する
            SerializeObjectArrayToJsonFile(wEmployees, wJsonSettings);
        }

        /// <summary>
        /// オブジェクトをシリアル化にする。
        /// </summary>
        public static void SerializeObject(XmlWriterSettings vSettings) {
            //初期化
            var wEmployee = new Employee {
                Id = 1,
                Name = "桜",
                HireDate = DateTime.Today,
            };

            using (var writer = XmlWriter.Create("Employee.xml", vSettings)) {
                var wSerializer = new XmlSerializer(typeof(Employee));
                wSerializer.Serialize(writer, wEmployee);
            }
        }

        /// <summary>
        /// オブジェクトを逆シリアル化にする。
        /// </summary>
        public static void DeserializeObject() {
            using (var wReader = XmlReader.Create("Employee.xml")) {
                var wDeserializer = new XmlSerializer(typeof(Employee));
                var wEmployee = wDeserializer.Deserialize(wReader) as Employee;
                Console.WriteLine($"Id: {wEmployee.Id}\nName: {wEmployee.Name}\nHireDate: {wEmployee.HireDate}");
            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列をシリアル化にする。
        /// </summary>
        /// <param name="vEmployees">配列</param>
        public static void SerializeObjectArray(Employee[] vEmployees, XmlWriterSettings vSettings) {
            using (var wWriter = XmlWriter.Create("EmployeeUseDataContractSerializer.xml", vSettings)) {
                var wSerializer = new DataContractSerializer(vEmployees.GetType());
                wSerializer.WriteObject(wWriter, vEmployees);
            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列を逆シリアル化
        /// </summary>
        public static void DeserializeObjectArray() {
            using (var wReader = XmlReader.Create("EmployeeUseDataContractSerializer.xml")) {
                var wDeserializer = new DataContractSerializer(typeof(Employee[]));
                var wEmployees = wDeserializer.ReadObject(wReader) as Employee[];
                foreach (var wEmployee in wEmployees) {
                    Console.WriteLine($"Id: {wEmployee.Id}\nName: {wEmployee.Name}\nHireDate: {wEmployee.HireDate}");
                }
            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列をJSONファイルに出力する。
        /// Idはシリアル化対象外。
        /// </summary>
        /// <param name="vEmployees">配列</param>
        public static void SerializeObjectArrayToJsonFile(Employee[] vEmployees, DataContractJsonSerializerSettings vJsonSettings) {
            using (var wStream = new FileStream("Employee.json", FileMode.Create, FileAccess.Write)){
                var wSerializer = new DataContractJsonSerializer(typeof(Employee[]), vJsonSettings);
                wSerializer.WriteObject(wStream, vEmployees);
            }
        }
    }
}

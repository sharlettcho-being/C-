using System;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Practice12_1_1 {
    /// <summary>
    /// EmployeeクラスでId,名前、ひれ日付を持っている。
    /// </summary>
    [XmlRoot("employee")]
    [DataContract(Name = "employee")]
    public class Employee {

        [XmlElement(ElementName = "id")]
        [IgnoreDataMember]
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }           
    }
    internal class Program {
        /// <summary>
        /// 定義されたEmployeeクラスを使ってシリアル化、逆シリアル化にする。
        /// </summary>
        /// <param name="args"></param>
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
            //オブジェクトをシリアル化にする。
            SerializeObject();
            //オブジェクトを逆シリアル化にする。
            DeserializeObject();
            //複数のオブジェクトが格納されている配列をシリアル化にする。
            SerializeObjectArray(wEmployees);
            //複数のオブジェクトが格納されている配列を逆シリアル化にする。
            DeserializeObjectArray();
            //複数のオブジェクトが格納されている配列をJSONファイルに出力する
            SerializeObjectArrayToJsonFile(wEmployees);
        }

        /// <summary>
        /// オブジェクトをシリアル化にする。
        /// </summary>
        public static void SerializeObject() {
            //初期化
            var wEmployee = new Employee {
                Id = 1,
                Name = "桜",
                HireDate = DateTime.Today,
            };

            //Xmlファイルでの設定
            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("Employee.xml", settings)) {
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
                Console.WriteLine("Id: " + wEmployee.Id);
                Console.WriteLine("Name: " + wEmployee.Name);
                Console.WriteLine("HireDate: " + wEmployee.HireDate);
            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列をシリアル化にする。
        /// </summary>
        /// <param name="vEmployees">配列</param>
        public static void SerializeObjectArray(Employee[] vEmployees) {


            var wSettings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var wWriter = XmlWriter.Create("EmployeeUseDataContractSerializer.xml", wSettings)) {
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
                    Console.WriteLine("Id: " + wEmployee.Id);
                    Console.WriteLine("Name: " + wEmployee.Name);
                    Console.WriteLine("HireDate: " + wEmployee.HireDate);
                }

            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列をJSONファイルに出力する。
        /// Idはシリアル化対象外。
        /// </summary>
        /// <param name="vEmployees">配列</param>
        public static void SerializeObjectArrayToJsonFile(Employee[] vEmployees) {
            //日付の表示についての設定
            var wSettings = new DataContractJsonSerializerSettings {
                DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            };

            using (var wStream = new FileStream("Employee.json", FileMode.Create, FileAccess.Write)){
                var wSerializer = new DataContractJsonSerializer(typeof(Employee[]), wSettings);
                wSerializer.WriteObject(wStream, vEmployees);
            }
        }
    }
}

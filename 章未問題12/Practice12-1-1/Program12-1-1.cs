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
        private int _id;
        private string _name;
        private DateTime _hireDate;

        /// <summary>
        /// パラメータなしのコンストラクタ
        /// </summary>
        public Employee() { }

        /// <summary>
        /// パラメータありのコンストラクタ
        /// </summary>
        /// <param name="vId">従業員の一意の識別子</param>
        /// <param name="vName">従業員の名前</param>
        /// <param name="vHireDate">従業員の採用日</param>
        public Employee(int vId, string vName, DateTime vHireDate) {
            _id = vId;
            _name = vName;
            _hireDate = vHireDate;
        }

        /// <summary>
        /// 従業員の一意の識別子
        /// </summary>
        [XmlElement(ElementName = "id")]
        [IgnoreDataMember]
        [DataMember(Name = "id")]
        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 従業員の名前
        /// </summary>
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 従業員の採用日
        /// </summary>
        [XmlElement(ElementName = "hiredate")]
        [DataMember(Name = "hiredate")]
        public DateTime HireDate {
            get { return _hireDate; }
            set { _hireDate = value; }
        }
    }

    internal class Program {
        static void Main(string[] args) {
            var wEmployees = new Employee[] {
                new Employee(1, "桜子", DateTime.Today),
                new Employee (2, "桜華", new DateTime(2024, 6, 29)),
                new Employee (3, "桜太郎", new DateTime (2024,04,25))
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
            SerializeObject(wEmployees[0], wSettings);
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
        public static void SerializeObject(Employee vEmployees, XmlWriterSettings vSettings) {
            using (var writer = XmlWriter.Create("Employee.xml", vSettings)) {
                var wSerializer = new XmlSerializer(typeof(Employee));
                wSerializer.Serialize(writer, vEmployees);
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

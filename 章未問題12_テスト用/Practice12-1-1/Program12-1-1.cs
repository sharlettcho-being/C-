using System;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Schema;

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
        public int Id { get; private set; }

        /// <summary>
        /// 従業員の名前
        /// </summary>
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get;  private set; }

        /// <summary>
        /// 従業員の採用日
        /// </summary>
        [XmlElement(ElementName = "hiredate")]
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Employee() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vId">従業員の一意の識別子</param>
        /// <param name="vName">従業員の名前</param>
        /// <param name="vHireDate">従業員の採用日</param>
        public Employee(int vId, string vName, DateTime vHireDate) {
            this.Id = vId;
            this.Name = vName;
            this.HireDate = vHireDate;
        }

        /// <summary>
        /// オブジェクトをシリアル化にする。
        /// </summary>
        public void SerializeObject(Employee vEmployees, XmlWriterSettings vSettings, string vFileName) {
            using (var writer = XmlWriter.Create(vFileName, vSettings)) {
                var wSerializer = new XmlSerializer(typeof(Employee));
                wSerializer.Serialize(writer, vEmployees);
            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列をシリアル化にする。
        /// </summary>
        /// <param name="vEmployees">配列</param>
        public  void SerializeObjectArray(Employee[] vEmployees, XmlWriterSettings vSettings, string vFileName) {
            using (var wWriter = XmlWriter.Create(vFileName, vSettings)) {
                var wSerializer = new DataContractSerializer(vEmployees.GetType());
                wSerializer.WriteObject(wWriter, vEmployees);
            }
        }

        /// <summary>
        /// 複数のオブジェクトが格納されている配列を逆シリアル化
        /// </summary>
        public  void DeserializeObjectArray(string vFileName) {
            using (var wReader = XmlReader.Create(vFileName)) {
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
        public  void SerializeObjectArrayToJsonFile(Employee[] vEmployees, DataContractJsonSerializerSettings vJsonSettings) {
            using (var wStream = new FileStream("Employee.json", FileMode.Create, FileAccess.Write)) {
                var wSerializer = new DataContractJsonSerializer(typeof(Employee[]), vJsonSettings);
                wSerializer.WriteObject(wStream, vEmployees);
            }
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

            var wFileName = "Employee.xml";

            var wNewEmployee = new Employee();

            //オブジェクトをシリアル化にする。
            wNewEmployee.SerializeObject(wEmployees[0], wSettings, wFileName);

            //複数のオブジェクトが格納されている配列をシリアル化にする。
            wNewEmployee.SerializeObjectArray(wEmployees, wSettings, wFileName);

            //複数のオブジェクトが格納されている配列を逆シリアル化にする。
            wNewEmployee.DeserializeObjectArray(wFileName);

            //複数のオブジェクトが格納されている配列をJSONファイルに出力する
            wNewEmployee.SerializeObjectArrayToJsonFile(wEmployees, wJsonSettings);
        }

        
    }
}

using System;

namespace Practice1_1_3 {
    internal class Program
    {
        /// <summary>
        /// 学生の名前、年齢、学年、クラス番号の表示
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student FStudent = new Student();
            FStudent.Name = "ス";
            FStudent.Birthday = DateTime.Parse("2018-4-10");
            FStudent.Grade = 1;
            FStudent.ClassNumber = 1;

            Console.WriteLine($"名前:{FStudent.Name}\n年齢:{FStudent.GetAge()}\n学年: {FStudent.Grade} \nクラス番号:{FStudent.ClassNumber}");

            Person wPerson = new Student(1, 2, "チョ", DateTime.Parse("2018-4-10"));
            wPerson.Name = "チョ";
            wPerson.Birthday = DateTime.Parse("2012 / 4 / 6");
            ((Student)wPerson).Grade = 2;
            ((Student)wPerson).ClassNumber = 2;
            Console.WriteLine($"名前:{wPerson.Name}\n年齢:{wPerson.GetAge()}\n学年: {((Student)wPerson).Grade} \nクラス番号:{((Student)wPerson).ClassNumber}");

        }
    }
}

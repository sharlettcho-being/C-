using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "ス";
            student.Birthday = DateTime.Parse("2018-4-10");
            student.Grade = 1;
            student.ClassNumber = 1;

            Console.WriteLine("名前: {0} \n年齢: {1} \n学年: {2} \nクラス番号: {3}", student.Name, student.GetAge(), student.Grade, student.ClassNumber);

            Person person = new Student(1, 2, "チョ", DateTime.Parse("2018-4-10"));
            person.Name = "チョ";
            person.Birthday = DateTime.Parse("2012 / 4 / 6");
            ((Student)person).Grade = 2;
            ((Student)person).ClassNumber = 2;
            Console.WriteLine("名前: {0} \n年齢: {1} \n学年: {2} \nクラス番号: {3}", person.Name, person.GetAge(), ((Student)person).Grade, ((Student)person).ClassNumber);

        }
    }
}

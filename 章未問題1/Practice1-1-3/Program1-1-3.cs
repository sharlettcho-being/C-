using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3
{
    internal class Program
    {
        /// <summary>
        /// 学生の名前、年齢、学年、クラス番号の表示
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student FStudent = new Student();
            FStudent.FName = "ス";
            FStudent.FBirthday = DateTime.Parse("2018-4-10");
            FStudent.FGrade = 1;
            FStudent.FClassNumber = 1;

            Console.WriteLine($"名前:{FStudent.FName}\n年齢:{FStudent.GetAge()}\n学年: {FStudent.FGrade} \nクラス番号:{FStudent.FClassNumber}");

            Person FPerson = new Student(1, 2, "チョ", DateTime.Parse("2018-4-10"));
            FPerson.FName = "チョ";
            FPerson.FBirthday = DateTime.Parse("2012 / 4 / 6");
            ((Student)FPerson).FGrade = 2;
            ((Student)FPerson).FClassNumber = 2;
            Console.WriteLine($"名前:{FPerson.FName}\n年齢:{FPerson.GetAge()}\n学年: {((Student)FPerson).FGrade} \nクラス番号:{((Student)FPerson).FClassNumber}");

        }
    }
}

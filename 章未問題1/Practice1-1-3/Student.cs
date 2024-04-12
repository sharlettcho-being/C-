using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3
{
    internal class Student: Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }

        //引数なしのコンストラクタ
        public Student()
        {
            this.Grade = 0;
            this.ClassNumber = 0;
        }

        //引数ありのコンストラクタ
        //基本クラスの変数も呼び出すできる
        public Student(int grade, int className, string name, DateTime birthday): base (name, birthday)
        {
            this.Grade = grade;
            this.ClassNumber = className;
            this.Name = name;
            this.Birthday = birthday;

        }
    }
}

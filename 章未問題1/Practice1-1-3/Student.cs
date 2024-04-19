using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3
{
    internal class Student : Person
    {
        /// <summary>
        /// 学年
        /// </summary>
        public int FGrade { get; set; }

        /// <summary>
        /// クラス番号（組）
        /// </summary>
        public int FClassNumber { get; set; }

        /// <summary>
        /// 引数なしょコンストラクタ
        /// </summary>
        public Student()
        {
            this.FGrade = 0;
            this.FClassNumber = 0;
        }

        /// <summary>
        /// 引数ありのコンストラクタ
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="className"></param>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        public Student(int vGrade, int vClassName, string vName, DateTime vBirthday) : base(vName, vBirthday)
        {
            this.FGrade = vGrade;
            this.FClassNumber = vClassName;
            this.FName = vName;
            this.FBirthday = vBirthday;

        }
    }
}

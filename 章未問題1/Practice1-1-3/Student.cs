using System;

namespace Practice1_1_3 {
    internal class Student : Person
    {
        /// <summary>
        /// 学年
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// クラス番号（組）
        /// </summary>
        public int ClassNumber { get; set; }

        /// <summary>
        /// 引数なしょコンストラクタ
        /// </summary>
        public Student()
        {
            this.Grade = 0;
            this.ClassNumber = 0;
        }

        /// <summary>
        /// 引数ありのコンストラクタ
        /// </summary>
        /// <param name="grade">グレード</param>
        /// <param name="className">クラス名</param>
        /// <param name="name">名前</param>
        /// <param name="birthday">誕生日</param>
        public Student(int vGrade, int vClassName, string vName, DateTime vBirthday) : base(vName, vBirthday)
        {
            this.Grade = vGrade;
            this.ClassNumber = vClassName;
            this.Name = vName;
            this.Birthday = vBirthday;

        }
    }
}

using System;

namespace Practice1_1_3 {
    /// <summary>
    /// 名前、誕生日を持っているクラス
    /// </summary>
    internal class Person{
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 誕生日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 年齢の計算
        /// </summary>
        /// <returns>年齢</returns>
        public int GetAge(){
            DateTime wToday = DateTime.Today;
            var wAge = wToday.Year - Birthday.Year;
            if (wToday < Birthday.AddYears(wAge))
                wAge--;
            return wAge;
        }

        /// <summary>
        /// 引数なしのコンストラクタ
        /// </summary>
        public Person(){
            this.Name = null;
            this.Birthday = DateTime.Now;
        }

        /// <summary>
        /// 引数ありのコンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="birthday">誕生日</param>
        public Person(string vName, DateTime vBirthday){
            this.Name = vName;
            this.Birthday = vBirthday;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3
{
    internal class Person
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 誕生日
        /// </summary>
        public DateTime FBirthday { get; set; }

        /// <summary>
        /// 年齢の計算
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int wAge = today.Year - FBirthday.Year;
            if (today < FBirthday.AddYears(wAge))
                wAge--;
            return wAge;
        }

        /// <summary>
        /// 引数なしのコンストラクタ
        /// </summary>
        public Person()
        {
            this.FName = null;
            this.FBirthday = DateTime.Now;
        }

        /// <summary>
        /// 引数ありのコンストラクタ
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        public Person(string vName, DateTime vBirthday)
        {
            this.FName = vName;
            this.FBirthday = vBirthday;
        }
    }
}

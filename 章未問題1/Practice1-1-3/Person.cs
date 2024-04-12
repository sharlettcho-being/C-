using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set;}
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }

        //引数なしのコンストラクタ
        public Person()
        {
            this.Name = null;
            this.Birthday = DateTime.Now;
        }

        //引数ありのコンストラクタ
        public Person(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}

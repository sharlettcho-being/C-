using System;
using System.Collections.Generic;

namespace Practice13_1_1.Models {
    /// <summary>
    /// 著者を表す
    /// </summary>
    public class Author {
        /// <summary>
        /// 著者の一意の識別子を取得または設定
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 著者の名前を取得または設定
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 著者の生年月日を取得または設定
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 著者の性別を取得または設定
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 著者の書籍のコレクションを取得または設定
        /// </summary>
        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        /// 空のコンストラクタ
        /// </summary>
        public Author() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vId">著者の一意の識別子</param>
        /// <param name="vName">著者の名前</param>
        /// <param name="vBirthday">著者の生年月日</param>
        /// <param name="vGender">著者の性別</param>
        /// <param name="vBooks">著者の書籍のコレクション</param>
        public Author(int vId, string vName, DateTime vBirthday, string vGender) {
            this.Id = vId;
            this.Name = vName;
            this.Birthday = vBirthday;
            this.Gender = vGender;
        }
    }
}

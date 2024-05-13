using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Practice7_1_2 {
    /// <summary>
    /// 省略語と対応する日本語を管理するクラス
    /// </summary>
    internal class Abbreviations {
        private Dictionary<string, string> FDict = new Dictionary<string, string>();
        /// <summary>
        /// コンストラクタ
        /// テキストファイルからの内容を「=」で分ける。
        /// </summary>
        public Abbreviations() {
            try {
                var wLines = File.ReadAllLines("Abbreviations.txt");
                this.FDict = wLines.Select(line => line.Split('=')).ToDictionary(x => x[0], x => x[1]);
            }
            catch {
                Console.WriteLine($"指摘したファイルが見つかりません！");
            }
        }        

    /// <summary>
    /// 要素の追加
    /// </summary>
    /// <param name="abbr">省略語</param>
    /// <param name="japanese">日本語</param>
    public void Add(string vAbbr, string vJapanese) {
            this.FDict[vAbbr] = vJapanese;
        }

        /// <summary>
        /// インデクサ　省略語をキーに取る
        /// </summary>
        /// <param name="abbr">省略語</param>
        /// <returns></returns>
        public string this[string vAbbr] {
            get {
                return FDict.ContainsKey(vAbbr) ? FDict[vAbbr] : null;
            }
        }

        /// <summary>
        /// 日本語から対応する省略語を取り出す
        /// </summary>
        /// <param name="japanese">日本語</param>
        /// <returns></returns>
        public string ToAbbreviation(string vJapanese) {
            return FDict.FirstOrDefault(x => x.Value == vJapanese).Key;
        }

        /// <summary>
        /// 日本語の位置を引数に与え、それが含まれる要素を全て取り出す
        /// </summary>
        /// <param name="substring">文字列</param>
        /// <returns>ディクショナリ</returns>
        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring) {
            foreach (var wText in FDict) {
                if (wText.Value.Contains(substring)) {
                    yield return wText;
                }
            }
        }

        /// <summary>
        /// ディクショナリに登録されている用語の数を返す処理
        /// </summary>
        /// <returns>用語の数を返す</returns>
        public int Count() {
            return FDict.Count;
        }

        /// <summary>
        /// 省略語を引数に受けて該当する項目を削除する処理
        /// </summary>
        /// <param name="vAbbr">省略語</param>
        /// <returns>削除出来たら＝＞trueを返す、要素が見つからないなら＝＞falseを返す</returns>
        public bool Remove(string vAbbr) {
            bool wCanDelete = false;
            if (FDict.ContainsKey(vAbbr)) { 
               FDict.Remove(vAbbr);
                wCanDelete = true;
            }
            return wCanDelete;
        }

        /// <summary>
        /// 3文字の省略語だけを取り出す処理
        /// </summary>
        /// <returns>ディクショナリを返す</returns>
        public Dictionary<string, string> GetAbbreviationsOnlyThreeCharacter() {
            return FDict.Where(x => x.Key.Length == 3).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}

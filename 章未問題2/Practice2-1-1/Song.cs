
namespace Practice2_1_1{
    internal class Song{
        /// <summary>
        /// 歌のタイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// アーテイスト名
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// 演奏時間
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// 引数ありのコンストラクタ
        /// </summary>
        /// <param name="vTitle">歌のタイトル</param>
        /// <param name="vArtistName">アーテイスト名</param>
        /// <param name="vLength">演奏時間</param>
        public Song(string vTitle, string vArtistName, int vLength){
            this.Title = vTitle;
            this.ArtistName = vArtistName;
            this.Length = vLength;
        }

    }
}

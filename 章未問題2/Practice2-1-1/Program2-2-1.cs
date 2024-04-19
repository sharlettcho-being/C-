using System;

namespace Practice2_1_1{
    internal class Program{
        /// <summary>
        /// 配列に格納された歌の名前、アーテイスト名、演奏時間を表示する
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args){
            // Songクラスのインスタンスを作成し、配列に格納
            Song[] wSongs = new Song[3];

            wSongs[0] = new Song("なごり雪", "イルカさん", 193);
            wSongs[1] = new Song("未来へ", "キロロさん", 1191);
            wSongs[2] = new Song("糸", "中島みゆきさん", 264);

            // 配列に格納された曲の情報を表示する
            for (int i = 0; i < wSongs.Length; i++){
                int wMinute = wSongs[i].Length / 60;

                int wSecond = wSongs[i].Length % 60;

                string result = wMinute.ToString() + ":" + wSecond.ToString();

                Console.WriteLine("歌のタイトル:\t" + wSongs[i].Title);
                Console.WriteLine("アーティスト名:\t" + wSongs[i].ArtistName);
                Console.WriteLine("演奏時間:\t" + result);
                Console.WriteLine();
            }
        }
    }
}

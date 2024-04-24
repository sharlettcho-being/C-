using System;
using System.Diagnostics;

namespace Practice8_1_3 {
    /// <summary>
    /// 処理時間を計測するクラス
    /// </summary>
    internal class TimeWatch {

        private Stopwatch FStopwatch;

        /// <summary>
        /// コンストラクタで Stopwatch オブジェクトを初期化する
        /// </summary>
        public TimeWatch(){
            FStopwatch = new Stopwatch();
        }
        /// <summary>
        /// 時間計測を開始する。
        /// </summary>
        public void Start() {
            FStopwatch.Start();
        }

        /// <summary>
        /// 時間の計測を停止し、計測した時間の経過を返す
        /// </summary>
        /// <returns>計測した時間の経過</returns>
        public TimeSpan Stop() {
            FStopwatch.Stop();
            return FStopwatch.Elapsed;
        }
    }
}

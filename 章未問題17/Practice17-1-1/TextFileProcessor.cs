using System.IO;
using System.Text;

namespace Practice17_1_1 {
    /// <summary>
    /// テキストファイルを処理するためのフレームワークを提供する
    /// </summary>
    internal abstract class TextFileProcessor {
        /// <summary>
        /// 指定されたテキストファイル処理クラスを実行します。
        /// </summary>
        /// <typeparam name="T">テキストファイル処理クラスの型。</typeparam>
        /// <param name="wFileName">処理するテキストファイルのパス。</param>
        public static void Run<T>(string wFileName) where T : TextFileProcessor, new() {
            var wSelf = new T();
            wSelf.Process(wFileName);
        }

        /// <summary>
        /// テキストファイルを初期化、実行、終了
        /// </summary>
        /// <param name="vFileName">処理するテキストファイルのパス</param>
        private void Process(string vFileName) {
            Initialize(vFileName);
            using (var wStreamReader = new StreamReader(vFileName, Encoding.UTF8)) {
                while (!wStreamReader.EndOfStream) {
                    string wLine = wStreamReader.ReadLine();
                    Execute(wLine);
                }
            }
            Terminate();
        }

        /// <summary>
        /// 初期化する
        /// </summary>
        /// <param name="wFileName">処理するテキストファイルのパス</param>
        protected virtual void Initialize(string wFileName) { }

        /// <summary>
        /// テキストファイルの各行を処理する
        /// </summary>
        /// <param name="wLine">処理するテキストファイルの行</param>
        protected virtual void Execute(string wLine) { }

        /// <summary>
        /// テキストファイル処理を終了
        /// </summary>
        protected virtual void Terminate() { }
    }
}

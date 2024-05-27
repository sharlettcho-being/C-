using System.IO;

namespace Practice17_1_3 {
    /// <summary>
    /// テキストファイルの処理を行うためのインターフェース
    /// </summary>
    public interface ITextFileProcessor {
        void Initialize(string vFileName);
        void Execute(string vLine);
        void Terminate();
    }

    /// <summary>
    /// テキストファイルを処理するためのフレームワークを提供する
    /// </summary>
    internal class TextFileProcessor {
        private ITextFileProcessor wTxtProcessor;

        /// <summary>
        /// TextFileProcessor クラスのインスタンスを初期化
        /// </summary>
        /// <param name="vChangeDigit">テキストファイル処理を変更するためのオブジェクト</param>
        public TextFileProcessor(ITextFileProcessor vChangeDigit) {
            this.wTxtProcessor = vChangeDigit;
        }

        /// <summary>
        /// 指定されたテキストファイル処理クラスを実行します。
        /// </summary>
        /// <param name="vFilename">処理するテキストファイルのパス</param>
        public void Run(string vFilename) {
            wTxtProcessor.Initialize(vFilename);
            using (var wStreamReader = new StreamReader(vFilename)) {
                while (!wStreamReader.EndOfStream) {
                    string wLine = wStreamReader.ReadLine();
                    wTxtProcessor.Execute(wLine);
                }
            }
            wTxtProcessor.Terminate();
        }
    }
}

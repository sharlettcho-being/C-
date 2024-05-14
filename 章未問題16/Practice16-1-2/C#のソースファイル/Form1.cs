using System;
using System.Windows.Forms;
using System.IO;

namespace Practice16_1_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e) {
            // 実行されるアプリケーションのカレントディレクトリを取得
            string wCurrentDirectory = Directory.GetCurrentDirectory();

            // 相対パスを使用してファイルにアクセスする例
            string wRelativePath = @"..\..\Abbreviations.txt";

            // 実際のファイルパスを取得
            string wFilePath = Path.Combine(wCurrentDirectory, wRelativePath);

            //指定されたファイルパスにファイルが存在しない場合、処理を中断する
            if (!File.Exists(wFilePath)) return;

            using (var wReader = new StreamReader(wFilePath)) {
                while (!wReader.EndOfStream) {
                    var wLines = await wReader.ReadLineAsync();
                    ShowText.Text += wLines + Environment.NewLine;
                }
            }
        }
        
    }
}

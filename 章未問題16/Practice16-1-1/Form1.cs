using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Practice16_1_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e) {
            // 相対パスを使用してファイルにアクセスする例
            string wFilePath = @"..\..\Abbreviations.txt";

            //指定されたファイルパスにファイルが存在しない場合、処理を中断する
            if (!File.Exists(wFilePath)) return;

            using (var wReader = new StreamReader(wFilePath)) {
                while (!wReader.EndOfStream) {
                    var wStringBuilder = new StringBuilder();
                    while (!wReader.EndOfStream) {
                        wStringBuilder.AppendLine(await wReader.ReadLineAsync());
                    }
                    FTextBoxLoaded.Text += wStringBuilder.ToString();
                }
            }
        }
        
    }
}

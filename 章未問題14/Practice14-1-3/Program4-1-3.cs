using System;
using System.Configuration;

namespace Practice14_1_3 {
    internal class Program {
        static void Main(string[] args) {

            // 構成ファイルのルート要素を取得
            Configuration wConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // MyAppSettings セクションが存在しない場合は、新しいセクションを追加
            if (wConfig.GetSection("MyAppSettings") == null) {
                wConfig.Sections.Add("MyAppSettings", new MyAppSettings());
            }

            // MyAppSettings セクションから CalendarOption を取得
            var wSettings = wConfig.GetSection("MyAppSettings") as MyAppSettings ?? new MyAppSettings();
            CalendarOption wCalendarOption = new CalendarOption("yyyy年MM月dd日(dddd)", "1990/1/1", "2100/12/31", true);
            wSettings.CalendarOption = wCalendarOption;

            // 構成ファイルを保存
            wConfig.Save(ConfigurationSaveMode.Modified);
        }
    }

    /// <summary>
    /// カレンダーオプションの設定を表します。
    /// </summary>
    public class CalendarOption: ConfigurationElement {
        /// <summary>
        /// 文字列のフォーマットを設定
        /// </summary>
        [ConfigurationProperty("StringFormat")]
        public string StringFormat {
            get { return (string)this["StringFormat"]; }
            set { this["StringFormat"] = value; }
        }

        /// <summary>
        /// 最小値を設定
        /// </summary>
        [ConfigurationProperty("Minimum")]
        public string Minimum {
            get { return (string)this["Minimum"]; }
            set { this["Minimum"] = value; }
        }

        /// <summary>
        /// 最大値を設定
        /// </summary>
        [ConfigurationProperty("Maximum")]
        public string Maximum {
            get { return (string)this["Maximum"]; }
            set { this["Maximum"] = value; }
        }

        /// <summary>
        /// 週の最初の曜日が月曜日かどうかを表す
        /// </summary>
        [ConfigurationProperty("MondayIsFirstDay")]
        public bool MondayIsFirstDay {
            get { return (bool)this["MondayIsFirstDay"]; }
            set { this["MondayIsFirstDay"] = value; }
        }

        public CalendarOption() { }

        public CalendarOption(string vStringFormat, string vMinimum, string vMaximum, bool vMondayIsFirstDay) {
            this.StringFormat = vStringFormat;
            this.Minimum = vMinimum;
            this.Maximum = vMaximum;
            this.MondayIsFirstDay = vMondayIsFirstDay;
        }
    }

    /// <summary>
    /// アプリケーションの設定セクションである MyAppSettings を表します。
    /// </summary>
    public class MyAppSettings : ConfigurationSection {
        /// <summary>
        /// カレンダーオプションを取得または設定
        /// </summary>
        [ConfigurationProperty("CalendarOption")]
        public CalendarOption CalendarOption {
            get { return (CalendarOption)this["CalendarOption"]; }
            set { this["CalendarOption"] = value; }
        }
    }
}

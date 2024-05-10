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
            MyAppSettings settings = wConfig.GetSection("MyAppSettings") as MyAppSettings;

            // 新しい設定値をセット
            settings.CalendarOption.StringFormat = "yyyy年MM月dd日(dddd)";
            settings.CalendarOption.Minimum = "1990/1/1";
            settings.CalendarOption.Maximum = "2100/12/31";
            settings.CalendarOption.MondayIsFirstDay = true;

            // 構成ファイルを保存
            wConfig.Save(ConfigurationSaveMode.Modified);
        }
    }

    /// <summary>
    /// カレンダーオプションの設定を表します。
    /// </summary>
    public class CalendarOption: ConfigurationElement {
        [ConfigurationProperty("StringFormat")]
        public string StringFormat {
                get { return (string)this["stringFormat"]; }
                set { this["StringFormat"] = value; }
        }

        [ConfigurationProperty("Minimum")]
        public string Minimum {
            get { return (string)this["minimum"]; }
           set { this["Minimum"] = value; }
        }

         [ConfigurationProperty("Maximum")]
         public string Maximum {
            get { return (string)this["maximum1"]; }
            set { this["Maximum"] = value; }
        }

         [ConfigurationProperty("MondayIsFirstDay")]
         public bool MondayIsFirstDay {
            get { return (bool)this["IsFirstDay"]; }
            set { this["MondayIsFirstDay"] = value; }
        }
    }

    /// <summary>
    /// アプリケーションの設定セクションである MyAppSettings を表します。
    /// </summary>
    public class MyAppSettings : ConfigurationSection {
        [ConfigurationProperty("CalendarOption")]
        public CalendarOption CalendarOption {
            get { return (CalendarOption)this["CalendarOption"]; }
            set { this["CalendarOption"] = value; }
        }
    }
}

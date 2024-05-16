namespace Practice17_1_2 {
    /// <summary>
    /// 長さの変換を行うための抽象基底クラス
    /// メートルから他の単位へ、他の単位からメートルへの変換およびその逆の変換を提供
    /// </summary>
    public abstract class ConverterBase {
        protected abstract double Ratio { get; }

        public abstract string UnitName { get; }

        public double FromMeter(double wValue) {
            return wValue / this.Ratio;
        }

        public double ToMeter(double wValue) {
            return wValue * this.Ratio;
        }
    }

    /// <summary>
    /// メートルを基準とするため、変換比率は常に1
    /// </summary>
    public class MeterConverter : ConverterBase {
        protected override double Ratio { get { return 1; } }
        public override string UnitName { get { return "メートル"; } }
    }

    /// <summary>
    /// フィートを基準とするため、変換比率は常に0.3048
    /// </summary>
    public class FeetConverter : ConverterBase {
        protected override double Ratio { get { return 0.3048; } }
        public override string UnitName { get { return "フィート"; } }
    }

    /// <summary>
    /// インチを基準とするため、変換比率は常に0.0254
    /// </summary>
    public class InchConverter : ConverterBase {
        protected override double Ratio { get { return 0.0254; } }
        public override string UnitName { get { return "インチ"; } }
    }

    /// <summary>
    /// ヤードを基準とするため、変換比率は常に0.9144
    /// </summary>
    public class YardConverter : ConverterBase {
        protected override double Ratio { get { return 0.9144; } }
        public override string UnitName { get { return "ヤード"; } }
    }

    /// <summary>
    /// マイルを基準とするため、変換比率は常に1609.344
    /// </summary>
    public class MileConverter : ConverterBase {
        protected override double Ratio { get { return 1609.344; } }
        public override string UnitName { get { return "マイル"; } }
    }

    /// <summary>
    /// キロメートルを基準とするため、変換比率は常に1000
    /// </summary>
    public class KilometerConverter : ConverterBase {
        protected override double Ratio { get { return 1000; } }
        public override string UnitName { get { return "キロメートル"; } }
    }
    /// <summary>
    /// 異なる単位間で距離の変換を行う
    /// 2つの変換器を使用して、指定された方向に距離を変換する
    /// </summary>
    public class DistanceConverter {
        public ConverterBase From { get; private set; }
        public ConverterBase To { get; private set; }

        /// <summary>
        /// DistanceConverter クラスの新しいインスタンスを初期化
        /// </summary>
        /// <param name="vFromValue">変換元の単位を表す ConverterBase のインスタンス。</param>
        /// <param name="vToValue">変換先の単位を表す ConverterBase のインスタンス。</param>
        public DistanceConverter(ConverterBase vFromValue, ConverterBase vToValue) {
            this.From = vFromValue;
            this.To = vToValue;
        }

        /// <summary>
        /// 指定された指示に基づいて距離の変換を行います。
        /// </summary>
        /// <param name="wValue">変換する距離の値</param>
        /// <param name="vInstruction">メートルから変換したいか、メートルに変換したいか</param>
        /// <returns>変換された距離の値</returns>
        public double Convert(double wValue, string vInstruction) {
            if (vInstruction == "From"){
                return this.From.ToMeter(wValue);
            } else {
                return this.To.ToMeter(wValue);
            }
        }
    }
}

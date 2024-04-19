
namespace Practice2_2_2{
    /// <summary>
    /// インチとメートルの単位変換クラス
    /// </summary>
    internal class InchesConverter{
        public static readonly double C_Ratio = 0.0254;

        /// <summary>
        /// インチからメートルを求める
        /// </summary>
        /// <param name="vMeter"></param>
        /// <returns></returns>
        public static  double FromMeter(double vMeter){
            return vMeter / C_Ratio;
        }

        /// <summary>
        /// メートルからインチを求める
        /// </summary>
        /// <param name="vInch"></param>
        /// <returns></returns>
        public static double ToMeter(double vInch){
            return vInch * C_Ratio;
        }
    }
}

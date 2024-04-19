using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice1_1_2
{
    internal class Program
    {
        /// <summary>
        /// X、Yプロパティを持っているクラス
        /// </summary>
        class MyClass
        {
            public int FX { get; set; }
            public int FY { get; set; }

            //コンストラクタ
            public MyClass(int x, int y)
            {
                this.FX = x;
                this.FY = y;
            }
        }
        /// <summary>
        /// X、Yプロパティを持っている構造体
        /// </summary>

        struct MyStruct
        {
            public int FX { get; set; }
            public int FY { get; set; }

            //コンストラクタ
            public MyStruct(int x, int y)
            {
                this.FX = x;
                this.FY = y;
            }
        }
        /// <summary>
        /// MyClassとMyStructが持っているプロジェクトを表示する。
        /// MyClassとMyStructが持っているプロジェクトを2倍にしてを表示する。
        /// </summary>
        /// <param name="myClass"></param>
        /// <param name="myStruct"></param>
        static void PrintObjects(MyClass vMyClass, MyStruct vMyStruct)
        {
            Console.WriteLine($"クラスの値( {vMyClass.FX}, {vMyClass.FY}) ");
            Console.WriteLine($"構造体の値( {vMyStruct.FX}, {vMyStruct.FY}) ");


            //値を２倍にする
            vMyClass.FX = vMyClass.FX * 2;
            vMyClass.FY = vMyClass.FY * 2;
            vMyStruct.FX *= 2;
            vMyStruct.FY *= 2;

            Console.WriteLine($"クラスの2倍の値( {vMyClass.FX}, {vMyClass.FY}) ");
            Console.WriteLine($"構造体の2倍の値( {vMyStruct.FX}, {vMyStruct.FY}) ");

        }
        static void Main(string[] args)
        {
            // MyClassのインスタンスを作成
            var FmyClass = new MyClass(1, 2);

            // MyStructのインスタンスを作成
            var FmyStruct = new MyStruct(3, 4);

            // PrintObjectsメソッドを呼び出す
            PrintObjects(FmyClass, FmyStruct);

            Console.WriteLine($"Mainメソッドでのクラスの値( {FmyClass.FX}, {FmyClass.FY}) ");
            Console.WriteLine($"Mainメソッドでの構造体の値( {FmyStruct.FX}, {FmyStruct.FY}) ");

        }
    }
}

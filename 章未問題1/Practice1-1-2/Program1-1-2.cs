using System;

namespace Practice1_1_2 {
    internal class Program
    {
        /// <summary>
        /// X、Yプロパティを持っているクラス
        /// </summary>
        class MyClass
        {
            public int X { get; set; }
            public int Y { get; set; }

            //コンストラクタ
            public MyClass(int vX, int vY)
            {
                this.X = vX;
                this.Y = vY;
            }
        }
        /// <summary>
        /// X、Yプロパティを持っている構造体
        /// </summary>

        struct MyStruct
        {
            public int X { get; set; }
            public int Y { get; set; }

            //コンストラクタ
            public MyStruct(int vX, int vY)
            {
                this.X = vX;
                this.Y = vY;
            }
        }
        /// <summary>
        /// MyClassとMyStructが持っているプロジェクトを表示する。
        /// MyClassとMyStructが持っているプロジェクトを2倍にしてを表示する。
        /// </summary>
        /// <param name="myClass">myClassインスタンス</param>
        /// <param name="myStruct">myStructインスタンス</param>
        static void PrintObjects(MyClass vMyClass, MyStruct vMyStruct)
        {
            Console.WriteLine($"クラスの値( {vMyClass.X}, {vMyClass.Y}) ");
            Console.WriteLine($"構造体の値( {vMyStruct.X}, {vMyStruct.Y}) ");


            //値を２倍にする
            vMyClass.X = vMyClass.X * 2;
            vMyClass.Y = vMyClass.Y * 2;
            vMyStruct.X *= 2;
            vMyStruct.Y *= 2;

            Console.WriteLine($"クラスの2倍の値( {vMyClass.X}, {vMyClass.Y}) ");
            Console.WriteLine($"構造体の2倍の値( {vMyStruct.X}, {vMyStruct.Y}) ");

        }
        static void Main(string[] args)
        {
            // MyClassのインスタンスを作成
            var wMyClass = new MyClass(1, 2);

            // MyStructのインスタンスを作成
            var wMyStruct = new MyStruct(3, 4);

            // PrintObjectsメソッドを呼び出す
            PrintObjects(wMyClass, wMyStruct);

            Console.WriteLine($"Mainメソッドでのクラスの値( {wMyClass.X}, {wMyClass.Y}) ");
            Console.WriteLine($"Mainメソッドでの構造体の値( {wMyStruct.X}, {wMyStruct.Y}) ");

        }
    }
}

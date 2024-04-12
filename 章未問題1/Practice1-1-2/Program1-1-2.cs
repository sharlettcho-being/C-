using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice1_1_2
{
    internal class Program
    {
        class MyClass
        {
            public int X { get; set; }
            public int Y { get; set; }

            //コンストラクタ
            public MyClass(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        struct MyStruct
        {
            public int X { get; set; }
            public int Y { get; set; }

            //コンストラクタ
            public MyStruct(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        static void PrintObjects(MyClass myClass, MyStruct myStruct)
        {
            Console.WriteLine("クラスの値　({0}, {1})", myClass.X, myClass.Y);
            Console.WriteLine("構造体の値　({0}, {1})", myStruct.X, myStruct.Y);


            //値を２倍にする
            myClass.X = myClass.X * 2;
            myClass.Y = myClass.Y * 2;
            myStruct.X *= 2;
            myStruct.Y *= 2;
           
            Console.WriteLine("クラスの2倍の値　({0}, {1})", myClass.X, myClass.Y);
            Console.WriteLine("構造体の2倍の値　({0}, {1})", myStruct.X, myStruct.Y);            

        } 
         static void Main(string[] args)
        {
            // MyClassのインスタンスを作成
            MyClass myClass = new MyClass(1, 2);

            // MyStructのインスタンスを作成
            MyStruct myStruct = new MyStruct(3, 4);

            // PrintObjectsメソッドを呼び出す
            PrintObjects(myClass, myStruct);

            Console.WriteLine("Mainメソッドでのクラスの値　({0}, {1})", myClass.X, myClass.Y);
            Console.WriteLine("Mainメソッドでの構造体の値　({0}, {1})", myStruct.X, myStruct.Y);

        }
    }
}

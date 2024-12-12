using System;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Demo_ C__Basics_Session_02_603
{
internal class Program
    {
    static void Main(string[] args)
    {


    }

    }
}
namespace Demo_ C__Basics_Session_02_603
    {
internal class Progran
{
static void Main(string[] args)
    {
        #region Error Types
        #region Syntax Error - Copilation Error
        console MriteLine("Hello");
        iint X;
        #endregion
        #endregion
        #region RunTime Error

        int X = 5;
        int y = 6;

Console.WriteLine(X / y);
        #endregion
        #region Logical Error
        int A = 10;
        int B = 5;
        Console.WriteLine(Sum(A, B));
        #endregion
        #region Warning
                int X = 8; // 4 Byte
                Console WriteLine(X)
        #endregion
        #region CTS - CLS
            int X = 5;// Wigyte

        string Name = "test";// 8 Byte
        Name = "Ali"; // 6 byte
        #endregion
        #region Value Type

        int X; // 4 Byte
               //Console.WriteLine(X);
        X =4;

        int y =  9; // 4 Byte
        Y = X; //4
        X++; 5

Console.WriteLine(X);
Console WriteLine(y);
        #endregion
        #region Reference Type
        Point P01;

        P01 = new Point();

        Point P02 = new Point(); 

        P02 = P01;
        P01.X = 10;
        Console.WriteLine(P02.X);
        #endregion
        #region Object

        //Point PO1 = new Point();

        //01.
object obj01 = new object();

        //obj = 1;

        //obj = Hello;

        //obj = 'A';

        //obj = true ;

        object obj02 = new object();

        Console.WriteLine(obj01.GetHashCode());
        Console.WriteLine(obj02.GetHashCode());
        obj02 = obj01;
        #endregion
        #region Fractions and Discard
        //int Nun01 = 1233644444;
        long Num02 = 12334444444444444;
double Num03 = 22.2;

        float Num04 = 22.2F;

        decimal Num05 = 22.2m;

        int Num06 = 1.000.060;
        Console.WriteLine();
        #endregion

    }
}
}
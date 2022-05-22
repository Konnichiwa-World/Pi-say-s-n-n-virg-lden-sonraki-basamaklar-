using System;
using System.Collections;

class program
{
    public static void Main(string[] args)
    { a1:
        System.Console.WriteLine("Pi sayısının, virgülden sonra kaçıncı basamağında ne var?\nLütfen basamak giriniz:");
        Int32 x =Int32.Parse(Console.ReadLine());

        System.Console.WriteLine(Convert.ToInt32((Math.PI*(Math.Pow(10,x)))%10));goto a1;
    }
}

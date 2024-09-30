using System;
using System.Numerics;

class Program
{
    /*
    Создайте класс Helper и определите в нем статический метод Swap типа void,
    который принимает 2 переменные типа int и меняет их значения местами.
     */

    public class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;

        }
    }

   
    public static void Main(string[] args)
    {
        int num1 = 3;
        int num2 = 58;

        Helper.Swap(ref num1, ref num2);
        Console.WriteLine(num1); //58
        Console.WriteLine(num2); //3
        Console.ReadKey();
    }
}
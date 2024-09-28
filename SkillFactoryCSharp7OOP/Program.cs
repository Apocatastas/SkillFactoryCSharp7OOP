using System;
using System.Numerics;

class Program
{
    class Obj
    {
        public int Value;
    }

    static Obj operator +(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value + b.Value
        };
    }

    static Obj operator -(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value - b.Value
        };
    }

    public static void Main(string[] args)
    {

        Console.ReadKey();
    }
}
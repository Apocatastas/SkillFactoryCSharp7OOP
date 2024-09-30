using System;
using System.Numerics;

class Program
{

    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        Obj()
        {
        Parent = "System.Object";
        DaysInWeek = 7;
        MaxValue = 2000;

    }
}


    public static void Main(string[] args)
    {

        Console.ReadKey();
    }
}
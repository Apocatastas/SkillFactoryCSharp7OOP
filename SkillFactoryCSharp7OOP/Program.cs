using System;
using System.Numerics;

class Program
{
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;

        }

        // Индексатор по массиву
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }


    }









    public static void Main(string[] args)
    {

        Console.ReadKey();
    }
}
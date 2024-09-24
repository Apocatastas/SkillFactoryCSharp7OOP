using System;

class Program
{
    //Для класса DerivedClass создайте 2 конструктора: один, принимающий
    //2 параметра — name и description, второй — принимающий 3 параметра name,
    //description и counter.


    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }

        virtual public void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        override public void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter): this(name,description)
        {
            Counter = counter;
        }
    }

    public static void Main(string[] args)
    {

    }
}
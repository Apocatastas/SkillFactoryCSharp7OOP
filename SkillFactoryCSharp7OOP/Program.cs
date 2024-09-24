using System;

class Program
{
    class BaseClass
    {
        protected string Name;

        public virtual int Counter
        {
            get;
            set;
        }

        public BaseClass()
        {
           
        }

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

        public int counter;

        public override int Counter
        {
            get
            {
                return counter;
            }
            
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Счётчик не может быть отрицательным");
                }
                else
                {
                    counter = value;
                }
            }
        }

        override public void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }

        public DerivedClass()
        { 
           
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
        DerivedClass obj = new DerivedClass();
        obj.Display();
        Console.ReadKey();
    }
}
using System;
using System.Numerics;

class Program
{
    /*
     Создайте классы для следующих объектов компьютера:
    процессор (Processor),
    материнская карта (MotherBoard),
    видеокарта (GraphicCard). Унаследуйте их от класса ComputerPart.

Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.
     */

    public class Processor : ComputerPart
    {
        public override void Work()
        {

        }
    }

    public class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }

    public class GraphicCard : ComputerPart
    {
        public override void Work()
        {

        }
    }


    public abstract class ComputerPart
    {
        public abstract void Work();
    }
   
    public static void Main(string[] args)
    {

        Console.ReadKey();
    }
}
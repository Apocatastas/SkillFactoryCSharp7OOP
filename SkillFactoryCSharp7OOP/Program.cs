using System;
using System.Numerics;


/*
С учётом полученных знаний по наследованию обобщений,
дополните схему классов автомобиля, добавив классы для электромобиля и бензинового
— ElectricCar и GasCar.

Подумайте, какой класс или классы можно сделать абстрактными.
Сделайте абстрактными их и их члены (по возможности).
*/

public abstract class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;
    public abstract void Changepart<TCarPart>(TCarPart newPart) where TCarPart : CarPart;
   
}


class ElectricCar<TEngine> : Car<ElectricEngine>
{
    public override void Changepart<TCarPart>(TCarPart newPart)
    {

    }
}

class GasCar<TEngine> : Car<GasEngine>
{

    public override void Changepart<TCarPart>(TCarPart newPart)
    {
      
    }
}

public class Engine
{ }

public class CarPart { }

public class ElectricEngine : Engine
{

}

public class GasEngine : Engine
{

}

public class Battery : CarPart
{

}

public class Differential : CarPart
{

}

public class Wheel : CarPart
{

}
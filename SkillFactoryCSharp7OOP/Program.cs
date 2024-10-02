using System;
using System.Numerics;


/*
Установите ограничения на универсальные типы в классе Car.
Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine,
а параметр newPart метода ChangePart мог бы принимать только типы частей машины
(Battery, Differential, Wheel).
*/

public class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;
    public virtual void Changepart<TCarPart>(TCarPart newpart) where TCarPart : CarPart
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
using System;
using System.Numerics;


/*
Добавьте к схеме классов автомобиля следующие классы частей автомобиля:
Battery, Differential, Wheel.
Также добавьте в класс Car виртуальный обобщённый метод без реализации
— ChangePart, который будет принимать один параметр — newPart универсального типа.
*/

public class Car<T1>
{
    public T1 Engine;
    public virtual void Changepart<T2>(T2 newpart)
    {
    }
}

public class ElectricEngine
{

}

public class GasEngine
{

}

public class Battery
{

}

public class Differential
{

}

public class Wheel
{

}
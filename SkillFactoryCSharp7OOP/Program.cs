using System;
using System.Numerics;


/*
Создайте класс-обобщение Car для автомобиля.
Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый).
Для типов двигателей также создайте классы — ElectricEngine и GasEngine.

В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.
*/


public class Car <T>
    {
    public T Engine;
    }

public class ElectricEngine
    {

    }

public class GasEngine
{

}
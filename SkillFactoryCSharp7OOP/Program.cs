using System;

/*
-------
Базовый уровень:
--------------
✓ Использование наследования;
✓ Использование абстрактных классов или членов класса;
✓ Использование принципов инкапсуляции;
✓ Использование переопределений методов/свойств;
✓ Использование минимум 4 собственных классов;
✓ Использование конструкторов классов с параметрами;
✓ Использование обобщений;
✓ Использование свойств;
✓ Использование композиции классов.
-------------------
Продвинутый уровень:
-------------------
✓ Использование статических элементов или классов;
Использование обобщенных методов;
✓ Корректное использование абстрактных классов (использовать их там, где это обусловлено параметрами системы);
✓ Корректное использование модификаторов элементов класса (чтобы важные поля не были доступны для полного контроля извне, использование protected);
✓ Использование свойств с логикой в get и/или set блоках.
-------------------
Усложненный уровень:
-------------------
✓ Использование методов расширения;
Использование наследования обобщений;
✓ Использование агрегации классов;
✓ Использование индексаторов;
✓ Использование перегруженных операторов.
*/

public abstract class Delivery
{
    public Adress physicalAdress;
    public DateTime deliveryDate;
    public static string AdressFrom = "Адрес офиса отправки для рассчета пути доставки";

    public virtual void IncreaseByPeriod(int days) { }
    public abstract void ShowDeliveryTime();

    public void ShowAdress()
    {
        Console.Write("Adress");
    }

}

public class HomeDelivery : Delivery
{
    public override void ShowDeliveryTime()
    {
        Console.Write("Доставка по адресу {0} планируется {1}",physicalAdress,deliveryDate);
    }
}

public class PickPointDelivery : Delivery
{
    public override void ShowDeliveryTime()
    {
        Console.Write("Доставка в пункт выдачи планируется {0}", deliveryDate);
    }
}

public class ShopDelivery : Delivery
{
    public override void IncreaseByPeriod(int days)
    {
        base.IncreaseByPeriod(days+2); //добавляем срок на процессинг магазином
    }

    public override void ShowDeliveryTime()
    {
        Console.Write("Доставка в магазин планируется {0}", deliveryDate);
    }
}

class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public OrderPositions positions;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.physicalAdress);
    }

    public Order(int orderNumber, OrderPositions orderPositions)
    {
        Number = orderNumber;
        positions = orderPositions;
    }

    // ... Другие поля
}

class OrderPosition //Позиция в заказе. Строка в корзине с одинаковыми товарами с суммарной скидкой и ценой
{
    public Item item;
    public int quantity;
    public byte discount;
    public Price price;

}

class OrderPositions
{
    // Закрытое поле, хранящее книги в виде массива
    private OrderPosition[] orderPositions;

    // Конструктор с добавлением массива книг
    public OrderPositions(OrderPosition[] positions)
    {
        this.orderPositions = positions;
    }

    // Индексатор по массиву
    public OrderPosition this[int index]
    {
        get
        {
            // Проверяем, чтобы индекс был в диапазоне для массива
            if (index >= 0 && index < orderPositions.Length)
            {
                return orderPositions[index];
            }
            else
            {
                return null;
            }
        }

        private set
        {
            // Проверяем, чтобы индекс был в диапазоне для массива
            if (index >= 0 && index < orderPositions.Length)
            {
                orderPositions[index] = value;
            }
        }
    }
}
    public class Price
{
    public double cost;
    public string currency;

    //логика вычисления цены по курсу валюты
}

class Item
{
    public string name;
    public string pictureURL;
    public double weight;
    public string description;
    public Gabarites size;
    public string composition;
    public Price price;
    public bool visiblity;

    public Item(string itemName, string itemDescription, Price itemPrice)
    {
        name = itemName;
        description = itemDescription;
        price = itemPrice;
    }

}

public abstract class Person
{
    protected string name;
    protected string surname;
    protected string fatherName;

    public Adress physicalAdress;
    public Adress lawAdress;

    public string CallPolitely()
    {
        return name + " " + fatherName;
    }

    public Person()
    {
        name = "";
        surname = "";
        fatherName = "";

        physicalAdress = new Adress();
        lawAdress = new Adress();
}

}

class Manufacturer : Person { }
class Client : Person { }
public class Adress
{
    public string adressString;
}

class Gabarites
{
    public double height;
    public double width;
    public double depth;
    public string measurementType;

    public static Gabarites operator +(Gabarites a, Gabarites b)
    {
        return new Gabarites
        {
            height = a.height + b.height, 
            width = a.width + b.width,
            depth = a.depth + b.depth
            
        };
    }

    public static Gabarites operator -(Gabarites a, Gabarites b)
    {
        return new Gabarites
        {
            height = a.height - b.height,
            width = a.width - b.width,
            depth = a.depth - b.depth

        };
    }




}

static class StringExtensions
{
    public static char FirstSymbol(this string source)  // Возвращает первый символ строки для облегчения поиска по каталогу товаров
    {
        return source[0];

    }

    public static string MakeFirstCapital(this string source)  // Чтобы сделать первую букву названия товара заглавной по умолчанию
    {
        char[] buf = source[0].ToString().ToUpper().ToCharArray();
        source.Remove(0, 1);
        source.Prepend(buf[0]);
        return source;

    }
}
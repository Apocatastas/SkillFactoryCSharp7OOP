using System;
using System.Numerics;


    /*
    Для класса int создайте 2 метода расширения: GetNegative() и GetPositive().

    Метод GetNegative должен возвращать отрицательное значение переменной
    (если оно положительно), либо саму переменную (если оно отрицательно или равно 0).

    Метод GetPositive должен, наоборот, возвращать положительное значение
    (если оно отрицательно), либо саму переменную (если оно положительно или равно 0).
    */


    static class IntExtensions
    {
        public static int GetNegative(this int source)
        {
            if (source > 0) return (-1 * source);
            else  return source;
        }

        public static int GetPositive(this int source)
        {
            if (source < 0) return (-1 * source);
            else return source;
        }
    }

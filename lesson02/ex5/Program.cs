/// Напишите программу, кот. выводит случайное число из отрезка
/// [10, 99] и показывает наибольшую цифру.

/// Console.WriteLine (23 / 10) / = 2
/// Console.WriteLine (23 % 10) / = 3

/// Решение 1
//void Ex01()
//{
//    int val = new Random().Next(10, 100);
//    int a = val / 10;
//    int b = val % 10;
//    Console.WriteLine(val);
//
//   if (a > b)
//    {
//        Console.WriteLine(a);
//    }
//    else
//    {
//        Console.WriteLine(b);
//    }
//};
//Ex01();

// Решение 2
// int RandomInt(int min, int max)
// {
//     return new Random().Next(min, max);
// }
// void Ex01(int val)
// {
//     int a = val / 10;
//     int b = val % 10;
//     Console.WriteLine(val);
//    if (a > b)
//     {
//         Console.WriteLine(a);
//     }
//     else
//     {
//         Console.WriteLine(b);
//     }
// };
// Ex01(RandomInt(10, 100));

// Решение 3

string Ex01(int val)
{
    string result = string.Empty;
    int a = val / 10;
    int b = val % 10;
    result = Convert.ToString(val) + " ";
    if (a > b)
    {
        result = result + "max" + Convert.ToString(a);
    }
    else
    {
        result = result + "max" + Convert.ToString(b);
    }
    return result;
}

Console.WriteLine(Ex01(RandomInt(10, 100)));

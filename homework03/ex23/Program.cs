﻿// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Ведите число: ");
int N = Convert.ToInt32(Console.ReadLine());;
int a = 1;

while (a <= N)
{
    int b = a*a*a;
    Console.WriteLine(b);
    a++;
};
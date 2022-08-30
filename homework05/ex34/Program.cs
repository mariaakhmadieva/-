// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[4];
int count = 0;
Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        Console.Write(" " + arr[i]);
    }

foreach (int element in arr)
{
    if (element % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество четных чисел " + count);

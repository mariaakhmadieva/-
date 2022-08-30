// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] arr = new double[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().NextDouble();
    Console.Write(" " + arr[i]);
}
double max = arr.Max();
double min = arr.Min();

double diff = max - min;

Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: " + diff);
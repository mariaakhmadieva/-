//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

System.Console.Write("Количество чисел = ");
int arrayLen = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLen];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0) count++;
}

Console.WriteLine($"Количество чисел больше нуля: {count}");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
char[] arr = num.ToString().ToCharArray();


int sum = 0;
while (arr[i] <= arr.Length);
{
    sum = arr[i] + sum;
    i++;
}
Console.WriteLine(sum);
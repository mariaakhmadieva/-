// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Ведите пятизначное число: ");
int val = Convert.ToInt32(Console.ReadLine());

if (val > 9999 && val < 100000)
{
    char[] array = val.ToString().ToCharArray();
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
    Console.WriteLine("Число не является палиндромом");
    };
}
else
{
    Console.WriteLine("Число не пятизначное");
};
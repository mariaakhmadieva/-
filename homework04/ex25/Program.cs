// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// Еще раз зафиксируем: нужно написать именно ЦИКЛ, а не метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 2;
int multiplication = A;
  
while (count <= B)
{
  multiplication = multiplication*A;
  count++;
};
Console.WriteLine(multiplication);
// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Input(string text)
{
  bool f = false;
  int number = 0;
  while (!f)
  {
    System.Console.Write(text);
    string str = Console.ReadLine();
    f = int.TryParse(str, out number);
  }
  return number;
}

int m = Input("Первое число: ");
int n = Input("Второе число: ");
int t = m;

void Sum()
{
    int sum = 0;
    while (m <=n) 
    {
        sum = sum + m; 
        m++;
    }
    System.Console.Write($"Cумма натуральных элементов в промежутке от {t} до {n} равна {sum}.");
}

Sum();
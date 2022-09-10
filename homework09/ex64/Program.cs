// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

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

void ShowIntegers()
{
    while (m <=n) 
    {
        System.Console.Write(m + " "); 
        m++;
    }
}

ShowIntegers();
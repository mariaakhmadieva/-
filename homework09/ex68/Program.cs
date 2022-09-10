// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

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

int m = Input("Первое число m: ");
int n = Input("Второе число n: ");

int Akkerman(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 & n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else return 0;

}

Console.WriteLine($"A(m,n) = {Akkerman(m, n)}");

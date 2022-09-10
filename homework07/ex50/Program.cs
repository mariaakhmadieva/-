// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int m = Input("Количество строк: ");
int n = Input("Количество столбцов: ");

int[,] CreateArray(int rows, int columns)
{
  return new int[rows, columns];
}

void Fill(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);

  for (int row = 0; row < rows; row++)
  {
    for (int column = 0; column < columns; column++)
    {
      array[row, column] = new Random().Next(-100, 100);
    }
  }
}

void Print(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);

  for (int row = 0; row < rows; row++)
  {
    for (int column = 0; column < columns; column++)
    {
      Console.Write($"{array[row, column],5}");
    }
    Console.WriteLine();
  }
}

void FindNumber(int[,] array)
{
    Console.Write("Введите индекс строки: ");
    int findrow = 0;
    int.TryParse(Console.ReadLine(), out findrow);

    Console.Write("Введите индекс столбца: ");
    int findcol = 0;
    int.TryParse(Console.ReadLine(), out findcol);

    if (findrow < m && findcol < n)
    {
        Console.WriteLine($"Значение в индексе [{findrow},{findcol}] = {array[findrow, findcol]}");
    }
    else
    {
        Console.WriteLine($"Такого индекса в массиве нет.");
    }
    return;
}


int[,] matrix = CreateArray(m, n);
Fill(matrix);
Print(matrix);
FindNumber(matrix);




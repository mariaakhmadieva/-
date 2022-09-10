//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Average(int[,] array)
{
    for (int col = 0; col < n; col++)
    {
        double sum = 0;
        for (int row = 0; row < m; row++)
        {
            sum = sum + array[row, col];
        }
        sum = Math.Round(sum / m, 1);
        Console.WriteLine();
        Console.Write($"Столбец {col + 1}: {sum}  ");
    }
    return;
}


int[,] matrix = CreateArray(m, n);
Fill(matrix);
Print(matrix);
Average(matrix);

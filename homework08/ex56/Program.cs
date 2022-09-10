// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int[,] matrix = CreateArray(m, n);
Fill(matrix);
Print(matrix);

int SumArrayRow(int[,] array, int row)
{
    int sum = array[row, 0];
    for (int column = 1; column < n; column++)
        {
            sum += array[row, column];
        }
    return sum;
}

int MinLine = 0;
int MinSum = SumArrayRow(matrix, 0);
for (int row = 1; row < m; row++)
    {
    int TempSumLine = SumArrayRow(matrix, row);
    if(MinSum > TempSumLine)
        {
            MinSum = TempSumLine;
            MinLine = row;
        }
    }

Console.WriteLine($"Минимальная сумма {MinSum}, строка {MinLine + 1}.");


//  Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Streamline(int[,] array)
{
    for(int row = 0; row < m; row++)
        {
        for(int column = 0; column < n; column++)
            {
            for(int k = 0; k < n - 1; k++)
                {
                if(array[row, k] < array[row, k + 1])
                    {
                    int temp = array[row, k + 1];
                    array[row, k + 1] = array[row, k];
                    array[row, k] = temp;
                    }
                }
            }
        }
    return;
}

Console.WriteLine();
Streamline(matrix);
Print(matrix);
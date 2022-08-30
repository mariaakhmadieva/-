// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[11];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 100);
}

Console.WriteLine("[{0}]", string.Join(", ", arr));

var even = arr.Where((element, index) => index % 2 != 0);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: {1}", even.Count(), even.Sum());

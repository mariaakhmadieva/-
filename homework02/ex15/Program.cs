Console.WriteLine("Ведите число от 1 до 7");
int val = Convert.ToInt32(Console.ReadLine());
if (val == 6 || val == 7)
{
    Console.WriteLine("День является выходным");
}
else
{
    Console.WriteLine("День не является выходным");
};

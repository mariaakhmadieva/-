Console.WriteLine("Введите Ваше число ");
int val = Convert.ToInt32(Console.ReadLine());
if (val > 99)
{
    char[] array = val.ToString().ToCharArray();
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
};
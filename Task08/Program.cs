int i = 1;
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + N);
while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}
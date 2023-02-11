Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue > secondValue)
{
    Console.WriteLine(firstValue + " = max ");
}
if (secondValue > firstValue)
{
    Console.WriteLine(secondValue + " = max ");
}
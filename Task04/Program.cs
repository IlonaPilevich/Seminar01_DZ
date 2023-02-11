Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());

int max = firstValue;

if (firstValue > max) max = firstValue;
if (secondValue > max) max = secondValue;
if (thirdValue > max) max = thirdValue;
Console.Write(" max = ");
Console.WriteLine(max);
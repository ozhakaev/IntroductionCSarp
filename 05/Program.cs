double a,b,c;
Console.WriteLine("Введите число a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число c: ");
c = Convert.ToDouble(Console.ReadLine());

double max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine("Введите начальное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int j = a; j <= n; j++)
{
    Console.Write($"{j} ");
}
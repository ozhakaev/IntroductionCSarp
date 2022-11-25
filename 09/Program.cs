Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while(i<=n)
// {
//     Console.Write($"{i} ");
//     i=i+2;
// }
Console.WriteLine();
for (int j = 1; j <= n; j++)
{
    if (j % 2 == 0) Console.Write($"{j} ");
}

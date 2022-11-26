// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
if ((n >= 10000) && (n <= 99999))
{
    int a,b = 0,t = n;
    while (n > 0)
    {
        a = n % 10;
        b = (b * 10) + a;
        n = n / 10;
    }
    if (t == b) Console.WriteLine($"Число {t} является палиндромом"); else Console.WriteLine($"Число {t} не является палиндромом");
}
else
{
    Console.WriteLine("Неправильное число, введите пятизначное число");
}


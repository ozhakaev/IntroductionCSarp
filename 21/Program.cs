// 21. Задать номер четверти, показать диапазоны для возможных координат

void FindCoor(int n)
{
    if (n == 1)
    {
        Console.WriteLine("I четверть плоскости - (x > 0) & (y > 0)");
    }
    else if (n == 2)
    {
        Console.WriteLine("II четверть плоскости - (x < 0) & (y > 0)");
    }
    else if (n == 3)
    {
        Console.WriteLine("III четверть плоскости - (x < 0) & (y < 0)");
    }
    else if (n == 4)
    {
        Console.WriteLine("IV четверть плоскости - (x > 0) & (y < 0)");
    }
    else
    {
        Console.WriteLine("Такой четверти не существует");
    }
}

int n;
Console.WriteLine("Введите номер четверти");
n = Convert.ToInt32(Console.ReadLine());

FindCoor(n);

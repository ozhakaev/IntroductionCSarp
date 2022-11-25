Console.WriteLine("Введите число от 10 до 99: ");
int a = Convert.ToInt32(Console.ReadLine());
int first, second;
if (10 <= a && a <= 99)
{
    first = a / 10;
    second = a % 10;
    if (first < second)
    {
        Console.WriteLine($"Максимальная цифра: {second}");
    }
    else if (first > second)
    {
        Console.WriteLine($"Максимальная цифра: {first}");
    }
    else
    {
        Console.WriteLine("Цифры равны");
    }
}
else
{
    Console.WriteLine("Неправильное число");
}

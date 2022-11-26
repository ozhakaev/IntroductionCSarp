// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
void FindNumber(double x, double y)
{
    if((x > 0) && (y > 0))
    {
        Console.WriteLine("I четверть плоскости");
    }
    if((x < 0) && (y > 0))
    {
        Console.WriteLine("II четверть плоскости");
    }
    if((x < 0) && (y < 0))
    {
        Console.WriteLine("III четверть плоскости");
    }
    if((x > 0) && (y < 0))
    {
        Console.WriteLine("IV четверть плоскости");
    } else
    {
        Console.WriteLine("Вы ввели нулевые координаты X и Y.");
    }
}

double x, y;
Console.WriteLine("Введите число X и Y");
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());

FindNumber(x, y);

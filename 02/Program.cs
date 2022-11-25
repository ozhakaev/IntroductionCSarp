double a,b;
Console.WriteLine("Введите число a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
b = Convert.ToDouble(Console.ReadLine());

if ((a*a) == b){
    Console.WriteLine($"Число {b} является квадратом числа {a}");
} else if ((b*b) == a){
    Console.WriteLine($"Число {a} является квадратом числа {b}");
} else {
    Console.WriteLine("Оба числа не являются кватратом по отношению друг к другу");
}
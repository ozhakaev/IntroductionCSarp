int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b) Console.WriteLine($"{b} является квадратом {a}");
else if (b*b == a) Console.WriteLine($"{a} является квадратом {b}");
else Console.WriteLine("Не является");
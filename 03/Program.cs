double a,b;
Console.WriteLine("Введите число a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
b = Convert.ToDouble(Console.ReadLine());

if (a < b){
    Console.WriteLine($"Число {b} больше числа {a}");
} else if (a > b){
    Console.WriteLine($"Число {a} больше числа {b}");
} else {
    Console.WriteLine("Числа равны");
}
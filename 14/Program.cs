Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if ((a%b) == 0){
    Console.WriteLine("Число a кратно числу b");
} else {
    Console.WriteLine($"Остаток: {a%b}");
}
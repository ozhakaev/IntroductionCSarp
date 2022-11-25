int a = Convert.ToInt32(Console.ReadLine());
int result = a / 10 / 10 % 10;
if (result != 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("NO");
}

// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool holiday = false;
while (day <= 7)
{
    if ((day == 6) || (day == 7)) holiday = true; break;
}

if (holiday)
{
    Console.WriteLine("Выходной день недели");
} else {
    Console.WriteLine("Будний день недели");
}
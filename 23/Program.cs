﻿double x1, y1, x2, y2, distance;
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt((x2 - x1) * (x2 - x1) + Math.Pow(y2 - y1, 2));

Console.WriteLine(distance);
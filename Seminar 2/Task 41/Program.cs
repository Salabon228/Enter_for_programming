﻿// ========================== Задача 41 ===========================
// 41. Выяснить являются ли три числа сторонами треугольника

void Triangle(int a, int b, int c)
{
    if (a >= b + c | b >= a + c | c >= a + b)
    {
        System.Console.WriteLine("треугольника с такими сторонами не существует");
    }
    else
    {
        System.Console.WriteLine("Такой треугольник СУЩЕСТВУЕТ");
    }
}
Triangle(4, 4, 7);
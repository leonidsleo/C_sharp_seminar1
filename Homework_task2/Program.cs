﻿// Семинар 1. Домашняя работа. Задача 2.
// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число a - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);

if (a == b)
{
    Console.WriteLine($"A = {a} равно B = {b}");
}
else
    if (a > b)
    {
        Console.WriteLine($"A = {a} больше B = {b}");
    }
    else
    {
        Console.WriteLine($"A = {a} меньше B = {b}");
    }
Console.Write("Программа завершена!");
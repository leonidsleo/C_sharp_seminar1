﻿// Семинар 1. Домашняя работа. Задача 2.
// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Определить какое число больше из двух!");
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
    Console.WriteLine();
    Console.WriteLine("Ответ:");
    Console.WriteLine($"Число a = {a} равно b = {b};");
}
else
    if (a > b)
    {
        Console.WriteLine();
        Console.WriteLine("Ответ:");
        Console.WriteLine($"Число a = {a} больше b = {b};");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ответ:");
        Console.WriteLine($"Число a = {a} меньше b = {b};");
    }
Console.WriteLine();
Console.Write("Программа завершена!");
// Семинар 1. Домашнее задание. Задача №4.
//Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число a - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c - ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("c = ");
Console.WriteLine(c);

if (a > b && a > c)
{
    Console.WriteLine("ОТВЕТ:");
    Console.WriteLine($"Максимальное число = {a}");
}
if (a < b && b > c)
{
    Console.WriteLine("ОТВЕТ:");
    Console.WriteLine($"Максимальное число = {b}");
}
if (c > b && a < c)
{
    Console.WriteLine("ОТВЕТ:");
    Console.WriteLine($"Максимальное число = {c}");
}
if (a == b && a > c)
{
    Console.WriteLine("ОТВЕТ:");
    Console.WriteLine($"Максимальное число = {a}");
}
if (a == c && a > b)
{
    Console.WriteLine("ОТВЕТ:");
    Console.WriteLine($"Максимальное число = {a}");
}
if (c == b && a < c)
{
    Console.WriteLine("ОТВЕТ:");
    Console.WriteLine($"Максимальное число = {c}");
}
Console.Write("Программа завершена!");
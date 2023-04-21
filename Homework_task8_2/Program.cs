// Семинар 1. ДЗ. Задача №8.
// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Найти все четные числа от 1 до N?");
Console.WriteLine();

Console.Write("Введите значение окончания поиска N - ");
//int N = Convert.ToInt32(Console.ReadLine());
double N = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение начала поиска x - ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("ОТВЕТ:");
Console.WriteLine($"Все четные числа от {x} до {N} :  ");
for (double i = x; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.ReadKey();

Console.WriteLine();
Console.WriteLine();
Console.Write("Программа замершена!");
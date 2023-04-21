// Семинар1. ДЗ. Задача №6
// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Определить, является ли число четным?");
Console.Write("Введите число - ");
double a = Convert.ToDouble(Console.ReadLine());

double b = a / 2;
double c = b % 1;

if (c == 0)
{
    Console.WriteLine();
    Console.WriteLine("Ответ:");
    Console.WriteLine($"Число {a} - является четным;");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Ответ:");
    Console.WriteLine($"Число {a} - не является четным;");
}
Console.WriteLine();
Console.Write("Прграмма завершена!");
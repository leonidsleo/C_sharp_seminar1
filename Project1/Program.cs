// Семинар1. Знакомство с языками. Семинар 1
// Проект1: 
//int numberCity = 10;
//int number2 = 15;
//int number3 = 20;
//string user = "Leonid";

//Console.Write($"Привет, {user}");
//Console.WriteLine(user);

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine()); //сделали конвертацию в числа для сложения
Console.Write($"Привет, - {num + 100}");
//Будет выводить Привет, - 400 (100+300)

Console.Write("Введите число ");
string num = Console.ReadLine(); // тип строка
Console.Write($"Привет, - {num + 100}");
//Будет выводить Привет, - 100300 (100+300)
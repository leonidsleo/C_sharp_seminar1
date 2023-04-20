//Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру. 
//3 -> Среда  
//5 -> Пятница

Console.WriteLine("Введите номер дня недели ");
int num = Convert.ToInt32(Console.ReadLine()); //если нам надо вычислять или сравнивать числа, обязательно конвертируем в номер.
//string num = Console.ReadLine(); с такими операторами не работает
//int num = Console.ReadLine(); - с такими операторами не работает

if (num > 7)
{
    Console.Write("Такого дня недели не существует");
}
if (num < 1)
{
    Console.Write("Такого дня недели не существует");
}
if (num == 1)
{
    Console.Write("День недели понедельник");
}
if (num == 2)
{
    Console.Write("День недели вторник");
}
if (num == 3)
{
    Console.Write("День недели среда");
}
if (num == 4)
{
    Console.Write("День недели четверг");
}
if (num == 5)
{
    Console.Write("День недели пятница");
}
if (num == 6)
{
    Console.Write("День недели суббота");
}
if (num == 7)
{
    Console.Write("День недели воскресенье");
}
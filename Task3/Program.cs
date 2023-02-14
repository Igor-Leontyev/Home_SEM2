using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

switch(day){


    case 1:
        Console.WriteLine("Понедельник");
        Console.WriteLine("Не выходной");
        break;
    case 2:
        Console.WriteLine("Вторник");
        Console.WriteLine("Не выходной");
        break;
    case 3:
        Console.WriteLine("Среда");
        Console.WriteLine("Не выходной");
        break;
    case 4:
        Console.WriteLine("Четверг");
        Console.WriteLine("Не выходной");
        break;
    case 5:
        Console.WriteLine("Пятница");
        Console.WriteLine("Не выходной");
        break;
    case 6:
        Console.WriteLine("Суббота");
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Воскресение");
        Console.WriteLine("Выходной");
        break;
    default:Console.WriteLine("Нет такого дня недели");
        break;

}
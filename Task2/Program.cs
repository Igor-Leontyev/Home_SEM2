using System;
Console.WriteLine("Введите  число");
string str = Console.ReadLine();
if (str.Length >= 3)
{
    Console.WriteLine($"{str} -> {str[2]}");
}
else
{
    Console.WriteLine($"НЕТ ТРЕТЕЙ ЦИФРЫ"); 
}
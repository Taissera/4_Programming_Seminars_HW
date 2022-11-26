/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7)
{
    if (number != 6 && number != 7)
    {
        Console.WriteLine("нет");
    }
    else
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("Ввели число не от 1 до 7");
}
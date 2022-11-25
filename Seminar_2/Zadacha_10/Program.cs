/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number}: {secondDigit}");
}
else
{
    Console.WriteLine("Вы ввели НЕ трёхзначное число");
}

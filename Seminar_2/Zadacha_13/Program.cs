/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int initialNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (initialNumber > 0) 
{
   count++;
   initialNumber /= 10;
}
// Console.WriteLine($"Количество цифр введённого числа равно {count}");
int numberLength = count;
int index = 0;
int digit = 10;
if (numberLength < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (index < numberLength)
    {
        digit = 10 * 10;
        index++;
    }
    Console.WriteLine($"Рязряд числа: {digit}");
}
  

/*
int firstDigit = number / 10;
int secondDigit = number % 100;

Console.WriteLine($" Первое число {firstDigit}");
Console.WriteLine($" Второе число {secondDigit}");
*/

/*
if (number < 100)
{
Console.WriteLine("третьей цифры нет");
}
*/
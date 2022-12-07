/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine()),
number2 = Convert.ToInt32(Console.ReadLine()), 
number3 = Convert.ToInt32(Console.ReadLine());
int maxNumber = number1;

if (number1 > number2)
{
    maxNumber = number1;
}
else 
{
    maxNumber = number2;
}
if (maxNumber > number3)
{
    Console.Write($"максимальное число {maxNumber}");
}
else
{
    Console.Write($"максимальное число {number3}");
}



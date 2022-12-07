/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);

if (number < 0)
{
    Console.WriteLine($"Введите положительное значение:");
    number = Convert.ToInt32(Console.ReadLine());
}
else
{
    int i = 2;
    Console.Write($"чётные числа от 1 до {number}: ");
    while (i < number)
    {
        if (i %2 == 0)
        {
        Console.Write($"{i} ");
        }
    i += 1;
    }
}




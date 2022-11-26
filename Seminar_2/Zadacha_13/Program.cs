/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// считаем разряд числа
int NumberDigit(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int numDigit = NumberDigit(number);
// проверяем что число трехзначное или больше
if (numDigit <= 2)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
/*
Находим третью цифра введённого числа. Используем функцию Math.Pow() – возведения числа в степень. 
В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).
*/
    if (numDigit > 3)
    {
        number = number / Convert.ToInt32(Math.Pow(10, numDigit - 3));
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра введённого числа: {number}");
}
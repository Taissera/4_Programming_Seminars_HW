/*
Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели НЕ число или 0. Введите целое число больше 0");
        }
    }
    return result;
}

int lin = GetNumber("Введите число");
for(int i = 1; i <= lin; i++)
{
    Console.Write($" {Math.Pow(i,3)}, ");
}
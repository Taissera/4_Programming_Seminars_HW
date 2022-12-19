/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumberFromConsole (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine ("Ввели не число. Введите число");
        }
    }
    return result;
}

var b1 = GetNumberFromConsole ("Введите первую координату первой прямой: ");
var k1 = GetNumberFromConsole ("Введите вторую координату первой прямой: ");
var b2 = GetNumberFromConsole ("Введите первую координату второй прямой: ");
var k2 = GetNumberFromConsole ("Введите вторую координату второй прямой: ");

var x = (double) -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");

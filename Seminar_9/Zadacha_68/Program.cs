/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1) break;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}


int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return GetAkkerman(m - 1, 1);
    }
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}

Console.WriteLine("Введите два неотрицательных числа M и N");
int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");

GetAkkerman(m, n);
Console.WriteLine($"A({m},{n}) = {GetAkkerman(m, n)}");

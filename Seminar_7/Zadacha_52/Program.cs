/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// 1. функция ввода числа
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
    }
    return result;
}

// 2. функция задачи рандомного массива
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

// 3. функция печати массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{ matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int m = GetNumber("введите количество строк: ");
int n = GetNumber("введите количество столбцов: ");
int[,] array = GetArray(m, n);
PrintMatrix(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avrg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avrg += array[i, j];
    }
    Console.Write($"{ avrg / array.GetLength(0)}    ");
}

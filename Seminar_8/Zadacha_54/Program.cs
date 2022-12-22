/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// ввода числа
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

// рандомный двумерный массив
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

// печать массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("введите количество строк: ");
int n = GetNumber("введите количество столбцов: ");
int[,] array = GetArray(m, n);
Console.WriteLine("Исходный массив:");
PrintMatrix(array);

Console.WriteLine("Сортировка массива по убыванию:");
// сортировка элементов каждой строки массива по убыванию
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] > array[i, z + 1])
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
PrintMatrix(array);

Console.WriteLine("Сортировка массива по возрастанию:");
// сортировка элементов каждой строки массива по возрастанию
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1]) 
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
PrintMatrix(array);
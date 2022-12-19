/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// инициализирует новый массив трехзначных положительных чисел в диапазоне от 100 до 999
int[] GetArray (int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    return array;
}

// считает количество элементов массива, значения которых являются чётными
int Count (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int [] array = GetArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine($"В массиве [{string.Join(",", array)}] количество элементов, значения которых являются чётными равно {Count(array)}");
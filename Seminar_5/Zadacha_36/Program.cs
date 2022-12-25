/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// инициализирует новый массив в значении -99 до 100
int[] GetArray (int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-99,101);
    }
    return array;
}

// считает сумму элементов, индекс которых является нечётным
int SummOddIndexElemnts (int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i %2 != 0)
        {
            summ = summ + array[i];
        }
    }
    return summ;
}

Console.WriteLine("Введите размер массива");
int [] array = GetArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"В массиве [{string.Join(",", array)}] сумма элементов, стоящих на нечётных позициях равна {SummOddIndexElemnts(array)}");

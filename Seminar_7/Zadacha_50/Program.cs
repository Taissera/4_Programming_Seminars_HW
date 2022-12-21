/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Write("Введите строку: ");
int ind1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int ind2 = Convert.ToInt32(Console.ReadLine()) - 1;

Random random = new Random();
int n = random.Next(1, 31);
int m = random.Next(1, 31);

int[,] array = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 100);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (ind1 < 0 | ind1 > array.GetLength(0) - 1 | ind2 < 0 | ind2 > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", array[ind1, ind2]);
}
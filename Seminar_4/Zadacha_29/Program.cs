/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = new int [8];
Random rnd = new Random();

for (long i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
// поскольку в условии задачи не указано сколько цифр должно быть в числе, я использую Next()
// если нужно выводить двух или трёхзначные числа, то можно использовать Next(0,100) и Next(0,1000) соответственно
    //array[i] = new Random().Next(0,100);
    //array[i] = new Random().Next(0,1000);
}

Console.Write($"[");
Console.Write(string.Join(",", array));
Console.Write($"]");




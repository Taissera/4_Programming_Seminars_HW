/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// ввод числа
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

// генератор уникальных двузначных чисел
HashSet<int> numbers = new HashSet<int>();
Random rnd = new Random();
int GenerateUniqueNumber()
{
    while (true)
    {
        var n = rnd.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

// рандомный трехмерный массив из неповторяющихся значений
int[,,] Get3DArray(int m, int n, int v)
{
    int[,,] array = new int[m, n, v];
    //Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = GenerateUniqueNumber(); // array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

// печать массива
void Printmatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int m = GetNumber("введите размер массива m: ");
int n = GetNumber("введите размер массива n: ");
int v = GetNumber("введите размер массива v: ");
int[,,] array = Get3DArray(m, n, v);
Printmatrix3D(array);
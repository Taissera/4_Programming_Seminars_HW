/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

/* произведение матриц

Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.
Формула: C[i,j] = Sum(A[i,k]*B[k,j]) 
Где матрица A имеет размер M х K, матрица B — K х N, и матрица C — M х N
*/

void ProductMatrix (int[,] matrixA, int[,] matrixB, int[,] matrixC)

{
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      int summ = 0;
      for (int k = 0; k < matrixA.GetLength(1); k++)
      {
        summ += matrixA[i,k] * matrixB[k,j];
      }
      matrixC[i,j] = summ;
    }
  }
}

/*
Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором.
В этом случае говорят, что матрицы согласованы. 
*/

Console.WriteLine("Задайте две матрицы.");
int m = GetNumber("введите количество строк первой матрицы: ");
int k = GetNumber("введите количество столбцов первой матрицы (равно количеству строк во второй матрице): ");

int[,] matrixA = GetArray(m, k);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixA);

int n = GetNumber("введите количество столбцов второй матрицы: ");
int[,] matrixB = GetArray(k, n);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixB);

Console.WriteLine("Произведение матриц:");
int[,] matrixC = new int[m,n];
ProductMatrix(matrixA, matrixB, matrixC);
PrintMatrix(matrixC);
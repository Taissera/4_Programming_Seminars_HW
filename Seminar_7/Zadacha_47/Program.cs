/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

//получить числа с консоли
int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//задать матрицу и заполнить ее вещественными числами

/*
array[i, j] = -5.0+ rnd.NextDouble()*(-5.0 + 10.5);

Это будет вещественное рандомное число от -5 до 10.5.

Если это все забить в Math.Round() то будет округление )
*/
double [,] GetMatrix(int m, int n)
{
    double [,] matrix = new double [m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j ] = Math.Round(-99.0 + rnd.NextDouble() * (-99.0 + 100.0), 1);
        }
    }
    return matrix;
}

//распечатать матрицу
void PrintMatrix(double [,] matrix)
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

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов");

double [,] matrix = GetMatrix(m,n);

PrintMatrix(matrix);
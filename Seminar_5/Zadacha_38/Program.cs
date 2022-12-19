/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/*
------------------------------------------------------------------
-------------------- решение для целого числа --------------------
------------------------------------------------------------------
*/

/*
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

// находит Max и Min элементы массива
int DiffMaxMin (int [] array)
{
    int diffMaxMin = 0;
    int minNumber = 0;
    int maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        if (array[i] < maxNumber && array[i] < minNumber) minNumber = array[i];
    }
    Console.WriteLine($"* максимальное число {maxNumber}");
    Console.WriteLine($"* минимальное число {minNumber}");
    diffMaxMin = maxNumber - minNumber;
    return diffMaxMin;
}

Console.WriteLine("Введите размер массива");
int [] array = GetArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"В массиве [{string.Join(",", array)}]:");
int result = DiffMaxMin(array);
Console.WriteLine($"* разница между max элементом и min элементом равна {result}");
*/


/*
------------------------------------------------------------------
---------------- решение для вещественного числа -----------------
------------------------------------------------------------------
*/
// инициализирует новый массив в значении -2.5 до 10.5

double[] GetArray (int length)
{
    double [] array = new double [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(-2.5 + rnd.NextDouble() * (-2.5 + 10.5), 1);
    }
    return array;
}

int GetNumberFromConsole (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine ("Ввели не число. Введите число");
        }
    }
    return result;
}

// метод, который будет печатать массив
void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// находит Max и Min элементы массива
double DiffMaxMin (double [] array)
{
    double diffMaxMin = 3.5;
    double minNumber = -2.5;
    double maxNumber = 10.5;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        if (array[i] < maxNumber && array[i] < minNumber) minNumber = array[i];
    }
    Console.WriteLine($"* максимальное число {maxNumber}");
    Console.WriteLine($"* минимальное число {minNumber}");
    diffMaxMin = maxNumber - minNumber;
    return diffMaxMin;
}

int Darray = GetNumberFromConsole ("Введите размерность массива");
double [] startArray = GetArray (Darray);
PrintArray (startArray);
// на этом этапе распечатали массив, но ещё не выполнили вычисления

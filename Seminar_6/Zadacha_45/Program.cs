/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

// метод, который будет выдавать заполненный массив случайными числами
int[] InitArray (int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,9);
    }
    return array;
}

// метод, который будет печатать массив
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// получение числа с консоли, для того, чтобы задать размерность массива
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

// метод, который будет копировать массив
int [] CopyArray (int [] array)
{
    int [] result = new int [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result [count] = array [i];
        count++;
    }
    return result;
}

int dimension = GetNumberFromConsole ("Введите размерность массива");
int [] startArray = InitArray (dimension);
PrintArray(startArray);
int [] finalArray = CopyArray (startArray);
PrintArray(finalArray);


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber (string message)
{
    bool isCorrest = false;
    int result = 0;

    while (!isCorrest)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(),out result))
        {
            isCorrest = true;
        }
    else
    {
        Console.WriteLine("Ввели НЕ число");
    }
    }
    return result;
}


int NumDigitSumm (int number)
{
    int count = Convert.ToString(number).Length;
    int numDigit = 0;
    int summ = 0;
    for (int i = 0; i <= count; i++)
    {
        numDigit = number - number % 10;
        summ = summ + (number - numDigit);
        number = number / 10;
    }
    return summ;
}

int number = GetNumber("Введите число N: ");
int summ = NumDigitSumm(number);

Console.WriteLine($"Сумма цифр введённого числа {number} = {summ}");

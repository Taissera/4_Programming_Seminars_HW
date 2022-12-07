/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int Exp(int number1, int number2)
{
  int result = 1;
  for(int i=1; i <= number2; i++)
  {
    result = result * number1;
  }
    return result;
}
  int number1 = GetNumber("Введите число A: ");
  int number2 = GetNumber("Введите число B: ");
  
  int exp = Exp(number1, number2);
  Console.WriteLine($"Число {number1} в степени {number2} = {exp}");

  
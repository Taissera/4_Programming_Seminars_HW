/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// печатает массив
void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}

// запрашивает ввод чисел, читает строку и создаёт массив

Console.WriteLine ("Введите числа через запятую:");
string? numbers = Console.ReadLine();
string [] array = new string [numbers!.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
  if (numbers[i] == ',')
  {
    j++;
  }
  else
  {
    array[j] = array[j]+$"{numbers[i]}";
  }
}
j++;

// выводит массив 
int [] resultArray = new int[j];
PrintArray (resultArray, array);

// считает кол-во элементов, которые > 0
int sum = 0;
for (int i = 0; i < j; i++)
{
  if (resultArray[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ($"Количество чисел, которые больше нуля: {sum}.");
/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
// Вычисляется по формуле: AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
    }
    return result;
}
int x1 = GetNumber("ввод x1" );
int x2 = GetNumber("ввод x2" );
int y1 = GetNumber("ввод y1" );
int y2 = GetNumber("ввод y2" );
int z1 = GetNumber("ввод z1" );
int z2 = GetNumber("ввод z2" );
double sum1 = Math.Pow((x2 - x1), 2);
double sum2 = Math.Pow((y2 - y1), 2);
double sum3 = Math.Pow((z2 - z1), 2);
double result = Math.Sqrt(sum1 + sum2 + sum3);
Console.WriteLine(result);


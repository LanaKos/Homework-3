/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = GetNumber("Введите x1:");
int y1 = GetNumber("Введите y1:");
int z1 = GetNumber("Введите z1:");
int x2 = GetNumber("Введите x2:");
int y2 = GetNumber("Введите y2:");
int z2 = GetNumber("Введите z2:");

int GetNumber(string message)
{
    int result =0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или 0. Введите корректное число:");
        }
    }

    return result;
}

double sum1 = Math.Pow((x2 - x1), 2);
double sum2 = Math.Pow((y2 - y1), 2);
double sum3 = Math.Pow((z2 - z1), 2);

double result = Math.Sqrt(sum1 + sum2 + sum3);

Console.WriteLine(result);

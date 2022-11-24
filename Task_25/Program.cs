// Задача 25: Напишите цикл, который принимает
//  на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int footing = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int index = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"А в степени В = {GetExponent(footing, index)}");

int GetExponent(int numIn, int exp)
{
    if (exp == 0) return 1;
    int result = numIn;
    for (int i = 1; i < exp; i++)
    {
        result *= numIn;
    }
    return result;
}
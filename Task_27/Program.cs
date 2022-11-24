// Задача 27: Напишите программу, которая принимает на вход
//  число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int numIn = Convert.ToInt32(Console.ReadLine());

var result = GetSumDigit(numIn);
Console.Write($"Сумма цифр в числе = {result}");

int GetSumDigit(int num)
{
    int sum = 0;
    int digit = num;
    for (int i = 1; i <= digit; i++)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}


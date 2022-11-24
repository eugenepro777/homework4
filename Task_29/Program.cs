// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
Console.Write("Введите количество элементов массива: ");
int numElements = Convert.ToInt32(Console.ReadLine());//задаём количество элементов
Console.WriteLine();

var newArray = FillArray(numElements);
PrintArray(newArray);

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}

int[] FillArray(int length) //метод возвращает заполненный массив 
{
    int[] result = new int[length];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 101);//генерируется значение от 0 до 100
    }
    return result;
}
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] nums = new int[10, 10];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        if (m > nums.GetLength(0) || n > nums.GetLength(1))
        {

            Console.WriteLine($"Такого числа в массиве нет");

        }

        if (i == m || j == n)

        {
            Console.WriteLine($"Число массива на заданной позиции: {nums[m, n]}");



        }
        break;
    }
}

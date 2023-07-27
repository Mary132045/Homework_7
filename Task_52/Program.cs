// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите количество строк массива: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[i, j];

void nums(int i, int j)
{
    int k, l;
    Random rand = new Random();
    for (k = 0; k < i; k++)
    {
        Console.WriteLine();
        for (l = 0; l < j; l++)
        {
            randomArray[k, l] = rand.Next(1, 9);
            Console.Write($"{randomArray[k, l]} ");
        }
        Console.WriteLine();
    }
}

void avg(int i, int j)
{
    Console.Write("Среднее арифметическое по столбцам массива: ");
    int k, l;
    Random rand = new Random();
    for (l = 0; l < j; l++)
    {
        double sum = 0;
        for (k = 0; k < i; k++)
        {
            sum = sum + randomArray[k, l];
        }
        Console.Write($"{sum / (k):F2}  ");
    }
}
nums(i, j);
avg(i, j);

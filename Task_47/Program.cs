// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] nums = new double[3,4];

    
    for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        nums[i,j] = new Random().Next(-10, 100);
    }
}

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        Console.Write(nums[i,j] / 10  + " ");
    }
    Console.WriteLine();
}
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-999, 1000) / 10.0;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5}\t");
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, cols];
FillArray(array);
PrintArray(array);
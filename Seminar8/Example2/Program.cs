//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
PrintArray(ChangeArray(array));

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21); ;
}
void PrintArray(int[,] array)
{
    Console.Write(" ");
    for (int j = 0; j < array.GetLength(1) - 1; j++) Console.Write("____");
    Console.Write("___");
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j],3}|");
        System.Console.WriteLine();
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write("___|");
        System.Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ChangeArray(int[,] array)
{
    int[,] newArray = new int[rows, cols];
    for (int i = 0; i < array.GetLength(1); i++)
        for (int j = 0; j < array.GetLength(0); j++)
            newArray[i, j] = array[j, i];
    return newArray;
}




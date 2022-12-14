// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// рассматриваем только квадратные массивы.
// и потом надо найти сумму элементов обратной диагонали.(начинать с нижнего левого угла)

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}
void Summa(int[,] array)
{
    int sum = 0;
    int secondSum = 0;
    int checkSS=0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum += array[i, j];

            if (array.GetLength(0) - 1 == i + j)

                secondSum = secondSum + array[i, j];

            if (array.GetLength(0) - i -1 == j)

                checkSS = checkSS + array[i, j];
        }
    Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");
    Console.WriteLine($"Сумма элементов обратной диагонали равна {secondSum}");
    Console.WriteLine($"Сверка с формулой с урока {checkSS}");
}
Console.WriteLine("Введите количество строк и столбцов двумерного квадратного массива");
int cvadro = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[cvadro, cvadro];
FillArray(array);
PrintArray(array);
Summa(array);

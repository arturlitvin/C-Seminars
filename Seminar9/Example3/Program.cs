﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите целое число");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Последовательность чисел от {m} до {n}:{SummaRec(n)}");


// string SummaRec(int N)
// {
//     if (N < m) return "";
//     return SummaRec(N - 1) + " " + N;
// }

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N большее M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(int M, int N)
{
    if (M == N) return M.ToString();
    else return (PrintNumbers(M, N - 1) + ", " + N);
}
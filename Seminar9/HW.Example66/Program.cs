// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите целое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от {M} до {N} равна {SummaRec(N)}");



int SummaRec(int N)
{
    if (N == (M - 1)) return 0;
    if (M > N) (M, N) = (N, M);
    return N + SummaRec(N - 1);
}


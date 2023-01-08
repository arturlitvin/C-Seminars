// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Последовательность чисел от 1 до {n}: {While(n)}");
Console.WriteLine($"Последовательность чисел от 1 до {n}:{SummaRec(n)}");

// int While(int n)
// {
//     int xxx = n - n + 1;
//     while (true)
//     {
//         Console.Write($"{xxx} ");
//         xxx++;
//         if (xxx == n) break;
//     }
//     return n;

// }

string While(int n)
{
    string res = " ";
    while (true)
    {
        res = n.ToString() + " " + res;
        n--;
        if (n == 0) break;
    }
    return res;
}

string SummaRec(int N)
{
    if (N == 0) return "";
    return SummaRec(N - 1) + " " + N;
}
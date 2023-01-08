// посчитать сумму всех целых чисел от 1 до N , где N вводится с клавиатуры

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от 1 до {N} равна {SummaFor(N)}");
Console.WriteLine($"сумма чисел от 1 до {N} равна {SummaWhile(N)}");
Console.WriteLine($"сумма чисел от 1 до {N} равна {SummaRec(N)}");

int SummaFor(int N)
{
    int sum = 0;
    for (int i = 1; i <= N; i++) sum += i;
    return sum;
}

int SummaWhile(int N)
{
    int sum = 0;
    while (true)
    {
        sum += N;
        N--;
        if (N == 0) break;
    }
    return sum;
}

int SummaRec(int N)
{
    if (N == 0) return 0;
    return N + SummaRec(N - 1); // в себе прячем sum+=N и N--
}

//5 + (4 + (3 + (2 + (1 + 0))))
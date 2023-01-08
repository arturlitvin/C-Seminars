// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр введённого числа {n} равна {SummaRec(n)}");


int SummaRec(int n)
{
    if (n == 0) return 0;
    return n % 10 + (SummaRec(n / 10));
}




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе = {Summ(num)}");

int Summ(int num)
{
    int x = 0;

    while (num > 0)
    {
        x = x + num % 10;
        num = num / 10;
    }
    return x;
}


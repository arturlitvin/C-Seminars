// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void CheckPal(int n)
{
    int n1 = n / 10000 % 10;
    int n2 = n / 1000 % 10;
    int n4 = n / 10 % 10;
    int n5 = n % 10;
    if (n > 99999 || n < 10000) Console.WriteLine("Неверное число");
    else if (n1 == n5 && n2 == n4) Console.WriteLine("Введенное число - Паллиндром");
    else Console.WriteLine("Введенное число не является паллиндром");
}

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
CheckPal(n);
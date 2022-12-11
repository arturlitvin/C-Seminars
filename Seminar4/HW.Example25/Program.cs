// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите интересующую вас степень числа");
int deg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} в {deg} степени равно {Result(num, deg)}");

double Result(int num, int deg)
{
    int num1 = 1;
    for (int i = 0; i < deg; i++)
    {
        num1 = num1 * num;
    }
    return num1;
}
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Факториал числа {num} равен {x}");

// int Factorial(int num)
// int i = 1;
// int x = 1;
// while (i <= num)
// {
//     x = x * i;
//     i++;
// }
// Console.WriteLine($"Факториал числа {num} равен {x}");

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал числа {num} равен {Fact(num)}");

int Fact(int num)
{
    int x = 1;
    for (int i = 1; i <= num; i++) x = i * x;
    return x;
}

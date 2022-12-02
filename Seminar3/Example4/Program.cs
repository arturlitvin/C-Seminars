// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

/* Решение в строку(моё)

Console.WriteLine("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int square = 0;
int first = 1;
while (first <= num)
{
    square=first*first;
    Console.Write($"{square} ");
    first++;
}
*/
// Решение с урока:
try
{
Console.WriteLine("введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <= n;i++)
{
    Console.Write($"{i*i} ");
}
}
catch
{
    Console.WriteLine("вы что-то сделали не так");
}
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % (7 * 23) == 0)
{
Console.WriteLine("Число одновременно кратно числам 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно числам 7 и 23 одновременно");
}

/// Остановился на 2-м семинаре C# 1:20:29 sec
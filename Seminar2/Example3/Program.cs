Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1 % num2;
if (num3 == 0)
{
    Console.WriteLine($"Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток={num3}");
}
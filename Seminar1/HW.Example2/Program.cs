Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число, отличное от первого");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.WriteLine($"Вы ввели ввели два одинаковых числа, они равны: {num1} = {num2}");
}
else if (num1>num2)
{
    Console.WriteLine($"Максимальное число: {num1}, Минимальное число: {num2}");
}
else 
{
    Console.WriteLine($"Максимальное число: {num2}, Минимальное число: {num1}");
}
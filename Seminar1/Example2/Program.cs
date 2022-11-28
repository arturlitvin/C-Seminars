Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число, отличное от первого");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.WriteLine("Вы ввели одинаковые числа");
}
else if
(num2 == num1 / num2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if (num1 == num2 / num1)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Квадраты чисел отсутствуют");
}
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("В указанном диапазоне нет четных чисел");
}

else if (num > 0)
{
    int print = 2;
    while (print <= num) 
    {
        Console.Write($"{print} ");
        print += 2;
    }
}
else
{
    int print = 0;
    while (print >= num) 
    {
        Console.Write($"{print} ");
        print = print - 2;
    }
}
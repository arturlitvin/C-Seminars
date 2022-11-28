Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("В указанном диапазоне нет четных чисел");
}

else if (num > 0)
{
    int even = 2;
    while (even <= num)
    {
        Console.Write($"{even} ");
        even += 2;
    }
}
else
{
    int even = 0;
    while (even >= num)
    {
        Console.Write($"{even} ");
        even = even - 2;
    }
}
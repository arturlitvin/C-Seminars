Console.WriteLine("Enter an integer number");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;
if (number > 99)
{
    while (number >= 1000)
    {
        number /= 10;
        x = number % 10;
    }
    Console.WriteLine($"the third number from the left is {x}");
}
else
{
    Console.WriteLine($"Нифига, тут всего 2 знака");
}

// разобраться с задачей и придумать второй вариант решения
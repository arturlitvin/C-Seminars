Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 || number < -99)
{
    while (number >= 1000 || number <= -1000)
    {
        number = number / 10;
    }
    int x = number % 10;
    if (x < 0) x = -x;
    Console.WriteLine($"Третья цифра слева: {x}");
    
}
else Console.WriteLine($"Третья цифра слева отсутствует");
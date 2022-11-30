Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;

if (number > 999)
{
    while (number >= 1000)
    {
        number = number / 10;
        x = number % 10;
    }
    Console.WriteLine($"Третья цифра слева: {x}");
}
else if (number>99&&number<=999)
   {
     x = number % 10;
    Console.WriteLine($"Третья цифра слева: {x}");
   }
else
{
    Console.WriteLine($"Третья цифра слева отсутствует");
}

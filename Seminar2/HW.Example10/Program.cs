Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int second = num % 100 / 10;
if ((num < 100 || num > 999) && (num > (-100) || num < (-999))) Console.WriteLine("Введенное число не соответствует условиям");
else if (second < 0) Console.WriteLine($"Вторая цифра введённого числа:{-second}");
else Console.WriteLine($"Вторая цифра введённого числа:{second}");
int num = new Random().Next(10, 100);
Console.WriteLine($"Сгенерировано случайное число: {num}");
int max = num / 10;
if (num % 10 > max) max = num % 10;
Console.WriteLine($"Наибольшая цифра в этом числе это: {max}");

for (int i = 0; i <= num; i++) Console.WriteLine($"{i}");
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Сгенерировано случайное число: {num}");
// int first = num / 100;
// int third = num % 10;
// int newnum = first * 10 + third;
// Console.WriteLine(newnum);

// Выше моё решение, ниже с урока. Оба верные.

int num = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число: {num}");
int first = num / 100;
int third = num % 10;
Console.WriteLine($"{first}{third}");
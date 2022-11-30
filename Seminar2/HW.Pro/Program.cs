Console.WriteLine("Введите колличество программистов, которое произнёс робот : ");
int n = Convert.ToInt32(Console.ReadLine());
int pro = n % 100;
int pro1 = n % 10;
if (pro >= 11 && pro <= 14) Console.WriteLine($"Робот сказал, что в комнате {n} программистов");
else if (n < 0) Console.WriteLine("Вы ввели отрицательное число, робот не мог сказать такую фигню");
else if (pro1 >= 2 & pro1 <= 4) Console.WriteLine($"Робот сказал, что в комнате {n} программиста");
else if (pro1 == 1) Console.WriteLine($"Робот сказал, что в комнате {n} программист");
else Console.WriteLine($"Робот сказал, что в комнате {n} программистов");
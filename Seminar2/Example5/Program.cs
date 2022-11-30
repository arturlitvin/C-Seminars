// Console.WriteLine("Введите первое целое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 /num2 == num2) 
// Console.WriteLine("Первое число является квадратом второго");
// else if (num2 / num1 == num1)
// Console.WriteLine("Второе число является квадратом первого");
// else Console.WriteLine("Квадраты чисел отсутствуют"); 

//Выше моё решение, рабочее...Не знал про команду(||)-или

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 /num2 == num2 || num2 / num1 == num1) // || - или
Console.WriteLine("Одно из чисел является квадратом другого");
else Console.WriteLine("Квадраты чисел отсутствуют");
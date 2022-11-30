// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % (7 * 23) == 0)
// {
// Console.WriteLine("Число одновременно кратно числам 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число не кратно числам 7 и 23 одновременно");
// }

/// Остановился на 2-м семинаре C# 1:20:29 sec

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 4 == 0 && num % 6 == 0)//пример сдвоенных условий; && - И
Console.WriteLine("Число одновременно кратно числам 4 и 6");//Если всего одно условие, фигурные скобки можно не ставить...Вроде так, подходит и для сдвоенных условий
else Console.WriteLine("Число не кратно числам 4 и 6 одновременно");
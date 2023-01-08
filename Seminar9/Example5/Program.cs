// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите интересующую Вас степень ранее введённого числа");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} в {b}-й степени  равно {DegreeRec(a,b)}");


int DegreeRec(int a,int b)
{
    if (b==0) return 1;
   return a*(DegreeRec(a,b-1));
}
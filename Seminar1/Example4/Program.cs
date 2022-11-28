Console.WriteLine ("Enter a three-digit integer number");
int number = Convert.ToInt32(Console.ReadLine( ));
int lastDigit = number % 10;//Оператор остатка % вычисляет остаток от деления левого операнда на правый.
Console.WriteLine ($"Last digit of you number is {lastDigit}");
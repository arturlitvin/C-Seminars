// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
try//пытается выполнить программный код
{
Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x,y);
Console.WriteLine(CheckKoord2(x,y));
}
catch//если не получилось, то уходим в этот блок
{
    Console.WriteLine("Надо было вводить именно целое число, цифрами");
}
void CheckKoord(int x, int y)//Ничего не возвращает, но что-то делает
{
if (x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
else if (x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
else if (x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
else if (x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
else Console.WriteLine("Точка находится на оси");
}
string CheckKoord2(int x, int y)
{
    string res;
if (x > 0 && y > 0) res = "Это четверть № 1";
else if (x > 0 && y < 0) res ="Это четверть № 4";
else if (x < 0 && y > 0) res ="Это четверть № 2";
else if (x < 0 && y < 0) res ="Это четверть № 3";
else res ="Точка находится на оси";
return res;
}
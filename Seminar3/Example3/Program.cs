// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// d = √ [(x2-x1)в квадрате + (y2-y1) в квадрате]
try
{
    Console.WriteLine("Введите координаты четырёх точек");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    double r = distance(x1, y1, x2, y2);
    Console.WriteLine($"Расстояние между точками равно {r}");
}
catch
{
    System.Console.WriteLine("Вы ввели не числовое значение");
}
double distance(int x1, int y1, int x2, int y2)
{

    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return d;
}


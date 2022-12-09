// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

//37 минут 38 секунд-время для видео


// int Max(int side1, int side2, int side3)
// {
//     int result = side1;
//     if (side2 > result) result = side2;
//     if (side3 > result) result = side3;
//     return result;
// }



// Console.WriteLine("Введите длину первой стороны");
// int side1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину первой стороны");
// int side2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину первой стороны");
// int side3 = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine($"Максимальная длина равна: {Max(side1, side2, side3)}");
// int max=0;
// if (side1>side2) { max=side1;}
// else max=side2;
// if (side3>max) {max=side3;}

// bool check = false;
// if (max < side1 + side2 + side3-max)
// {
//     check = true;
// }
// if (check) {Console.WriteLine("Такой треугольник может существовать");}
// else Console.WriteLine("Такой треугольник существовать не может");

// Console.WriteLine("Введите длину первой стороны");
// int side1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину первой стороны");
// int side2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину первой стороны");
// int side3 = Convert.ToInt32(Console.ReadLine());

// if(side1<side2+side3||side2<side1+side3||side3<side1+side2) {Console.WriteLine("Такой треугольник может существовать");}
// else {Console.WriteLine("Такой треугольник существовать может");}




bool IsTriangle (int a, int b, int c)
{
    if ((a<b+c) && (b<a+c) && (c<a+b)) return true;
    else return false;
}

Console.WriteLine("Введите три числа.");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (IsTriangle(a,b,c)) Console.WriteLine("Треугольник существует!");
else Console.WriteLine("Треугольник не существует!");
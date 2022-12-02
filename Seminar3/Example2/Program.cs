
//Вариант 1
// Console.WriteLine("Введите номер четверти(от 1 до 4)");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1) Console.WriteLine("x > 0, y > 0");
// else if (num == 2) Console.WriteLine("x < 0, y > 0");
// else if (num == 3) Console.WriteLine("x < 0, y < 0");
// else if (num == 4) Console.WriteLine("x > 0, y < 0");
// else Console.WriteLine("Вы ввели неверный номер");

/* Вариант2
try
{
    Console.WriteLine("Введите номер четверти(от 1 до 4)");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.WriteLine("x > 0, y > 0");
else if (num == 2) Console.WriteLine("x < 0, y > 0");
else if (num == 3) Console.WriteLine("x < 0, y < 0");
else if (num == 4) Console.WriteLine("x > 0, y < 0");
else Console.WriteLine("Число не соответствует параметрам");
}
catch
{
    Console.WriteLine("Нужно ввести число");
}*/

//Вариант 2

try
{
    Console.WriteLine("Введите номер четверти(от 1 до 4)");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(quarter(num));
}
catch
{
    Console.WriteLine("Нужно ввести число цифрами, другое не допускается");
}

string quarter(int num)
{
    string res;
    if (num == 1) res = ("x > 0, y > 0");
    else if (num == 2) res = ("x < 0, y > 0");
    else if (num == 3) res = ("x < 0, y < 0");
    else if (num == 4) res = ("x > 0, y < 0");
    else res = ("Число не соответствует параметрам");
    return res;
}

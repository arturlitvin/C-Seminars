Console.WriteLine("Введите день недели цифрой (от 1 до 7):");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7) Console.WriteLine("Введенноё число не соответствует условиям");
else if (day > 0 && day < 6) Console.WriteLine("Это будний день");
else Console.WriteLine("Выходной");
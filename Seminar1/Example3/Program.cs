Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine()); //конвертируем строку в числовое значение, т.к. информация считанная с терминала это всегда строковый тип данных
int minusnum = -num;
while (minusnum <= num) // выводит все числа от введённого до 25
{
    Console.Write($"{minusnum} ");
    minusnum++;
}
Console.WriteLine();
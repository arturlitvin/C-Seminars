Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine()); //конвертируем строку в числовое значение, т.к. информация считанная с терминала это всегда строковый тип данных
int square = num*num;
//Console.WriteLine("Квадрат введенного числа равен: "+square);
Console.WriteLine($"Квадрат введенного числа равен: {square}");

if (num>9)//Внимание! После if (;)-точка с запятой не ставятся, иначе это будет ошибкой 
{ 
    Console.WriteLine("Вы ввели число больше 9");
}
else
{
    Console.WriteLine("Вы ввели число меньше 10");
}

while (num<=25) // выводит все числа от введённого до 25
{
    Console.Write ($"{num} ");
num++;
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{

    int[] array = new int[size];
    int i = 0;
    while (i < size)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return array;

}
void PrintArrayAndCount(int[] array)
{
    int x = 0;
    int i = 0;
    Console.WriteLine();
    while (i < array.Length)
    {
        Console.Write($"{array[i]}  ");
        if (array[i] > 0) x++;
        i++;
    }
    Console.WriteLine();
    Console.WriteLine($"Колличество чисел больше нуля равно {x}");
}


Console.WriteLine("Введите колличество чисел:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size); ;
PrintArrayAndCount(array);
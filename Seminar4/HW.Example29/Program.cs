// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int[] CreateArray(int size)
{

    int[] array = new int[size];
    int i = 0;
    while (i < size)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int size = 8;
int[] array = CreateArray(size); ;
PrintArray(array);
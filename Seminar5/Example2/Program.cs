// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    // for (int i = 0; i < array.Length; i++)
    //     Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void PrintNewArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{-el} ");
    Console.WriteLine();
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
PrintNewArray(array);
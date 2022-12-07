//Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
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

// void PrintCount(int[] array) // void ничего не возвращает!
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] >= 10 && array[i] <= 99) count ++;
//     Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] {count} ");
// }
int PrintCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99) count ++;
    return count;
}

int size = 15;
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine(PrintCount(array));
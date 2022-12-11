double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * 10000000000;
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}  ");

    Console.WriteLine();
}

void PrintDiff(double[] array)

{
    double min = array[0];
    double max = array[0];
    int i = 0;
    double diff = 0;
    while (i < array.Length)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        i++;
    }
    diff = max - min;
    Console.WriteLine($"Минимальный элемент = {min}, max = {max}, Разница = {diff}");
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine();
PrintDiff(array);
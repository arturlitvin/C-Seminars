// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(-9, 10);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
//         Console.Write($"{el} ");
//     // for (int i = 0; i < array.Length; i++)
//     //     Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }
// bool Check(int[] array)
// {
//     Console.WriteLine("Введите искомое число");
//     int num = Convert.ToInt32(Console.ReadLine());

//     int ch = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (num == array[i]) ch = ch + 1;
//     }
//     if (ch > 0)
//         return true;
//     else return false;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] array = CreateArray(size);
// PrintArray(array);

// if (Check(array))
//     Console.WriteLine("Искомое число присутствует в массиве");
// else Console.WriteLine("В массиве нет такого числа");

//Выше моё решение, ниже второе моё,согласно уроку

// int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(-9, 10);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
//         Console.Write($"{el} ");
//     // for (int i = 0; i < array.Length; i++)
//     //     Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }
// bool Check(int num, int[] array)
// {


//     int ch = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (num == array[i]) ch = ch + 1;
//     }
//     if (ch > 0)
//         return true;
//     else return false;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintArray(array);
// if (Check(num, array))
//     Console.WriteLine("Искомое число присутствует в массиве");
// else Console.WriteLine("В массиве нет такого числа");

// А ещё ниже решение с урока

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да 
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
bool CheckNumberIn(int number, int[] array) 
{ 
    bool find = false; 
    foreach (int el in array) 
    { 
        if (el == number) 
        { 
            find = true; 
            break; 
        } 
    } 
    return find; 
} 
 
Console.Write("Введите размерность массива "); 
int size=Convert.ToInt32 (Console.ReadLine()); 
Console.Write("Введите число "); 
int number=Convert.ToInt32 (Console.ReadLine()); 
int[] maxArray=CreateArray(size); 
PrintArray(maxArray); 
Console.WriteLine(CheckNumberIn(number,maxArray));

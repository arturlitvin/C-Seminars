// Напишите программу, которая принимает на вход числа через цикл 
// (в случае пустой строки ввод прекращается) 
// и проверяет находятся ли там квадраты чисел каждого к каждому. И если да, выводит какое именно число является квадратом какого.

// сначала пользователь пишет сколько чисел введет

Console.WriteLine("Введите сколько чисел будете вводить:");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count]; // Создаём новый пустой массив данной командой
int result = 0;

for (int i = 0; i < count; i++) array[i] = Convert.ToInt32(Console.ReadLine());

// цикл проверки

for (int j = 0; j < count - 2; j++)
{
    for (int k = j + 1; k < count - 1; k++)
    {
        if (array[j] == array[k] * array[k])
        {
            Console.WriteLine($"Число {array[j]} является квадратом {array[k]}");
            result++;
        }
        else if (array[k] == array[j] * array[j])
        {
            Console.WriteLine($"Число {array[k]} является квадратом {array[j]}");
            result++;
        }
    }
}
if (result==0) Console.WriteLine("Квадраты чисел не обнаружены");

// Решение с урока, не моё
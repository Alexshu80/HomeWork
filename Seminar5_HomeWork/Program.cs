// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// // Ввод метода создания массива из случайных положительных трехзначных чисел
// int [] CreateRandomArray(int size)
// {
//     // Создание массива размером size
//     int [] array = new int [size];
//     // цикл на заполнение массива случайными трехзначными числами в промежутке от 100 до 999
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// // Метод вывода массива на экран
// void ShowArray(int[] array)
// {
//     Console.Write("[ ");
//     // цикл вывода элемнтов массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// // Ввод метода на поиск количества четных элементов
// int Qnt (int[] array)
// {
//     // задание счетчика
//     int count = 0;
//     // цикл перебора элементов массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         // проверка условия четности, деления на 2 без остатка
//         if (array[i] % 2 == 0) count++;
//     }
//     // возврат счетчика
//     return count;
// }

// // Ввод размера массива
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// // Создание массива
// int[] array = CreateRandomArray(size);
// // Вывод массива на экран
// ShowArray(array);
// Console.WriteLine();
// // Вывод результата
// int res = Qnt(array);
// Console.WriteLine($"Количество четных чисел в массиве равно {res}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// // Ввод метода создания массива из случайных положительных чисел
// int [] CreateRandomArray(int size, int min, int max)
// {
//     // Создание массива размером size
//     int [] array = new int [size];
//     // цикл на заполнение массива случайными трехзначными числами в промежутке от min до max
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// // Метод вывода массива на экран
// void ShowArray(int[] array)
// {
//     Console.Write("[ ");
//     // цикл вывода элемнтов массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// // Ввод метода на поиск суммы элементов на нечетных позициях
// int Sum (int[] array)
// {
//     // Ввод переменной для суммы
//     int sum = 0;
//     // цикл на перебор элементов массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         // Проверка четности индекса. Рассчет суммы элементов в случае удовлетворения условию
//         if (i % 2 != 0) sum += array[i];
//     }
//     // Возврат суммы
//     return sum;
// }

// // Ввод размера массива и границ в которых формируется массив
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимум: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимум: ");
// int max = Convert.ToInt32(Console.ReadLine());
// // Создание массива
// int[] array = CreateRandomArray(size, min, max);
// // Вывод массива на экран
// ShowArray(array);
// Console.WriteLine();
// // Проверка количества элементов массива и вывод результата или сообщения.
// if (size < 2) Console.WriteLine("Нет элементов на нечетных позициях");
// else 
// {
//     int res = Sum(array);
//     Console.WriteLine($"Сумма элементов на нечетных позициях равна {res}");
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Ввод метода на заполнение массива
double [] CreateArray(int size)
{
    // Создание массива размером size
    double [] array = new double [size];
    // цикл на заполнение массива
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

// Метод вывода массива на экран
void ShowArray(double[] array)
{
    Console.Write("[ ");
    // цикл вывода элемнтов массива
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

// Ввод метода на поиск разницы между мин и макс элементами
double Diff (double[] array)
{
    // Ввод переменных
    double diff = 0;
    double min = array[0];
    double max = array[0];
    // цикл на перебор элементов массива
    for (int i = 0; i < array.Length; i++)
    {
        // Поиск мин и макс элементов
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    // определение разницы и возврат значения
    diff = max - min;
    return diff;
}

// Ввод размера массива
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
// Создание массива
double[] array = CreateArray(size);
// Вывод массива на экран
ShowArray(array);
Console.WriteLine();
// Проверка количества элементов массива и вывод результата или сообщения.
if (size < 2) Console.WriteLine("Мало элементов массива");
else 
{
    double res = Diff(array);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {res}");
}
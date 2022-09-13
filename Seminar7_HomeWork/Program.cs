// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// // Ввод метода создания двумерного массива m на n вещественных чисел
// double [,] CreateRandom2dArray(int m, int n, int min, int max)
// {
//     // создание массива
//     double[,] array = new double[m,n];
//     // цикл в цикле на заполнение массива случайными вещественными числами 
//     // в промежутке от min до max с округлением до первого знака
//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             array[i,j] = Math.Round(new Random().Next(min, max+1)* new Random().NextDouble(), 1);
//     return array;            
// }

// // Ввод метода на вывод массива на экран
// void Show2dArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// // Ввод данных
// Console.Write("Введите количство строк m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальную границу промежутка: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальную границу промежутка: ");
// int max = Convert.ToInt32(Console.ReadLine());

// // Вызов функций на создание и вывод на экран массива
// double[,] array = CreateRandom2dArray(m, n, min, max);
// Show2dArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void Show2dArray (int[,] array, int x, int y)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     }
//     Console.WriteLine();
//     if (x < array.GetLength(0) && y < array.GetLength(1)) Console.WriteLine("Ваше число: " + array[x,y]);
//     else Console.WriteLine("Такого элемента нет");
// }


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальную границу промежутка: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальную границу промежутка: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows, cols, min, max);

// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Show2dArray(array, x, y);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод создания двумерного массива
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}

// Метод вывода массива на экран
void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    }
}

// Метод поиска среднего значения по столбцам
void AvgCols (int[,] array)
{
    //Вывод сообщения:
    Console.WriteLine("Среднее значение элементов в столбцах:");
    // Цикл в цикле перебора элементов. Идем по столбцам
    for (int j = 0; j < array.GetLength(1); j++)
    {
        // Ввод переменной для суммы элементов в столбце
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        // Вывод расчета среднего с округлением до первого знака
        Console.Write(Math.Round(sum/array.GetLength(0),1) + " ");
     }
    
}

// Ввод значений
Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
// Создание массива с помощью метода
int[,] array = CreateRandom2dArray(rows, cols, min, max);
// Вывод массива на экран
Show2dArray(array);
Console.WriteLine();
// Вывод средних значений
AvgCols(array);
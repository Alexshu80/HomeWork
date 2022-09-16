// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Создание метода сортировки
// int[,] OrderArray(int[,] array)
// {
       // Цикл в цикле для перебора элементов 
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
           // Ввод переменной для промежуточного хранения     
//         int tmp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
               // Дополнительный цикл для сравнения и сортировки 
//             for (int k = 0; k < array.GetLength(1)-1; k++)
//             {
//                 if (array[i,k] < array[i,k+1])
//                 {
//                     tmp =  array[i,k+1];
//                     array[i,k+1] = array[i,k];
//                     array[i,k] = tmp;
//                 }
//             }                
//         }        
//     }
//     return array;
// }




// // Ввод значений
// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// // Создание массива с помощью метода
// int[,] array = CreateRandom2dArray(rows, cols, min, max);
// // Вывод массива на экран
// Show2dArray(array);
// Console.WriteLine();

// Вызов сортировки и вывод нового массива на экран
// int[,] array2 = OrderArray(array);
// Show2dArray(array2);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
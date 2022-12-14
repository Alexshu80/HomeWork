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

// // Метод поиска строки с наименьшей суммой элементов
// void MinRow(int[,] array)
// {
//     // Создание вспомогательного одномерного массива для хранения сумм элементов 
//     int[] sumArray = new int[array.GetLength(0)];
//     // цикл в цикле для перебора эементов и нахождения сумм в строках с записью результатов в одномерный массив
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         sumArray[i] = sum;
        
//     }
//     // Сравнение элементов вспомогательного массива и вывод результата = номера строки
//     int current = sumArray[0];
//     int iMin = 0;
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         if (sumArray[i] < current)
//         {
//             current = sumArray[i];
//             iMin = i;
//         }
        

//     }
//     Console.WriteLine("Строка с наименьшей суммой элементов: " + iMin);
    
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
// // Вызов метода для показа строки с наименьшей суммой элементов
// MinRow(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Создание метода на спиральное заполнение массива 4х4
int [,] SpiralArray(int n)
{
    // Создание пустого массива размером 4 на 4
    int[,] array = new int[4,4];
    // Ввод первого элемента
    array[0,0] = n;
    // циклы на заполнение остальных элементов
    for (int i = 1; i < 4; i++)
    {
        array[0,i] = array[0,i-1] + 1;
    }
    
    for (int i = 1; i < 4; i++)
    {
        array[i,3] = array[i-1,3] + 1;
    }
    
    for (int i = 2; i >= 0; i--)
    {
        array[3,i] = array[3,i+1] + 1;
    }
    
    for (int i = 2; i >= 1; i--)
    {
        array[i,0] = array[i+1,0] + 1;
    }
    
    for (int i = 1; i < 3; i++)
    {
        array[1,i] = array[1,i-1] + 1;
    }

    for (int i = 2; i < 3; i++)
    {
        array[i,2] = array[i-1,2] + 1;
    }
    // Заполнение последнего элемента
    array[2,1] = array[2,2] + 1;

    return array;
}
// Ввод данных и вывод массива
Console.Write("Введите значение начального алемента массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = SpiralArray(n);
Show2dArray(array);
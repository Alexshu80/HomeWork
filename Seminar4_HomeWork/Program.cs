// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Ввод метода
// void Power (int a, int b)
// {
//     // ввод переменной результат
//     int result = a;
//     // запуск цикла на количество степеней раз
//     for (int i = 1; i < b; i++)
//     {
//         result = result * a;    
//     }
//     // Вывод результата
//     Console.WriteLine($"{a} в степени {b} равно {result}");
// }
// // Ввод данных
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// // Условие на случай степени равной 0
// if (b == 0) Console.WriteLine($"{a} в степени 0 равно 1");
// else Power(a, b);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Ввод метода
// void Sum(int num)
// {
//     // Ввод переменной
//     int summ = 0;
//     // Запуск цикла уменьшаем число на разряд
//     for (int i = num; i != 0; i = i/10)
//     {
//         // Складываем остаток от деления на 10
//         summ = summ + (i % 10);
//     }
//     // Вывод результата
//     Console.WriteLine($"Сумма цифр в числе равна {summ}");
    
// }

// // Ввод числа
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// // Проверка на случай отрицательного числа. Не знаю нужна ли?
// if (n < 0)
// {
// n = n * (-1);
// Sum(n);
// } 
// else Sum(n);


// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// // Ввод метода создания и заполнения массива
// int [] CreateArray (int size)
// {
//     // создание массива размером size
//     int [] array = new int [size];
//     // Запуск цикла на последовательное заполнение массива
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите {i} элемент массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // Ввод метода на вывод массива на экран
// void ShowArray(int[] array)
// {
//     // Вывод пустой строки, сообщения и скобки
//     Console.WriteLine();
//     Console.WriteLine("Ваш массив:");
//     Console.Write("[ ");
//     // Запуск цикла на последовательный вывод элементов массива
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// // Ввод размера массива и вызов методов на вывод и заполнение массива
// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateArray(size));

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// // Ввод метода на ввод чисел, организован с помощью массива
// int [] CreateArray(int size)
// {
//     // Создание массива размером size
//     int [] array = new int [size];
//     // цикл на заполнение массива
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите {i+1}е число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // Метод вывода массива на экран
// void ShowArray(int[] array)
// {
//     // цикл вывода элемнтов массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
// }

// // Ввод метода на поиск чисел больше ноля
// int HowMany (int[] array)
// {
//     // Ввод счетчика
//     int count = 0;
//     // цикл на перебор элементов массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         // Проверка условия
//         if (array[i] > 0) count++;
//     }
//     // возврат счетчика
//     return count;
// }

// // Ввод количества чисел
// Console.Write("Сколько чисел будете вводить?: ");
// int size = Convert.ToInt32(Console.ReadLine());
// // Создание массива
// int[] array = CreateArray(size);
// // Вывод чисел на экран
// Console.WriteLine("Вы ввели:");
// ShowArray(array);
// Console.WriteLine();
// // Вывод результата.
// int res = HowMany(array);
// Console.WriteLine($"Чисел тут больше ноля: {res}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Метод поиска x
double FoundX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

// Метод поиска y
double FoundY (double x, double b1, double k1, double b2, double k2)
{
    double y = k1 * x + b1;
    return y;
}

// Ввод данных
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
// Вызов x и y  и вывод на экран
double resx = FoundX(b1, k1, b2, k2);
double resy = FoundY(resx, b1, k1, b2, k2);
Console.WriteLine($"Искомая точка: ({resx}; {resy})");



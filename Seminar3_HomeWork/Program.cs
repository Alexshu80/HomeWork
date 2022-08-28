// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Ввод метода
// void Mirror(int num)
// {
//     // Определение отдельных цифр числа
//     int a = num / 10000;
//     int b = (num % 10000) / 1000;
//     int c = (num % 100) / 10;
//     int d = num % 10;           
//     // Проверка условия палиндрома и вывод сообщения
//     if (a == d && b == c) Console.WriteLine("Это число палиндром");
//     else Console.WriteLine("Это число не палиндром");
// }

// // Ввод числа для проверки
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// // Проверка введенного числа на удовлетворение условию и вывод результата
// if (x > 99999 || x < 10000) Console.WriteLine("Число не удовлетворяет условию");
// else Mirror(x);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// // Ввод метода
// void Dist(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     // Рассчет расстояния
//     int num = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
//     double d = Math.Sqrt(num);
//     // Вывод результата с округлением до второго знака
//     Console.WriteLine("Расстояние между точками равно: " + Math.Round(d, 2));
//     // return d;
// }

// // // Ввод координат
// Console.WriteLine("Введите координаты первой точки");
// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// // Вызов функции
// Dist(x1, x2, y1, y2, z1, z2);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Ввод метода
void Cube (int num)
{
    // Перебор чисел с помощью цикла и вывод значений
    int index = 1;
    while (index <= num)
    {
        Console.Write(index*index*index + " | ");
        index++;
    }
}
// Ввод числа N
Console.Write("Введите число N: ");
// Проверка на удовлетворение условию и вывод сообщения или результата
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0) Console.WriteLine("Введенное число не удовлетворяет условию");
else Cube(n);


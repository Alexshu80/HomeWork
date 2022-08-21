/*
//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a;
int b;

// Ввод данных
Console.Write("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());

// Сравнение двух чисел и вывод большего
if (a > b)
{
    Console.WriteLine("Большее число " + a);
}
else
{
    Console.WriteLine("Большее число " + b);
}
*/

/*
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a;
int b;
int c;

// Ввод данных
Console.Write("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
c = Convert.ToInt32(Console.ReadLine());

// Сравнение первых двух чисел, после чего сравнение большего числа с третьим и вывод результата
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Большее число " + a);
    }
    else
    {
        Console.WriteLine("Большее число " + c);
    }
    
}
else
{
    if (b > c)
    {
        Console.WriteLine("Большее число " + b);
    }
    else
    {
        Console.WriteLine("Большее число " + c);
    }
}
*/

/*
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


int a;

// Ввод данных
Console.Write("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

// Проверка наличия остатка после деления на 2 и вывод результата
if (a % 2 == 0)
{
Console.WriteLine("четное");
}
else
{
   Console.WriteLine("нечетное"); 
}
*/


// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a;

// Ввод данных
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

int current = 1;

// Организация цикла
while(current <= a)
{
    // Проверка условия и вывод значения
    if (current % 2 == 0)
    Console.Write(current + " ");
    current++;
}


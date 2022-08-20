
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



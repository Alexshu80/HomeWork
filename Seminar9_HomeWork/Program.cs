// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

//Запрос данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

// Вывод данных
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

// // Рекурсия числа от m до n
// string IntervalMN(int m, int n)
// {
//     // точка остановки рекурсии
//     if( m>=n ) return n.ToString();
//     // рекурентный выход метода
//     return m + " " + IntervalMN(m+1,n);
// }

// // Ввод данных и вывод результата с проверкой условия
// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// string res = (m < n) ? IntervalMN(m,n) : IntervalMN(n,m);
// PrintData("Числа в заданном промежутке: ",res);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Рекурсивный расчет суммы чисел от m до n
int SumMN(int m, int n)
{
       //точка остановки рекурсии     
    if (m >= n) return n;
       //рекурсивный расчет суммы и ее вывод 
    return m + SumMN(m+1,n);
}

// Ввод значений и вывод результата с проверкой условия
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int res = (m < n) ? SumMN(m,n) : SumMN(n,m);
PrintData("Сумма чисел в заданном промежутке: ",res.ToString());



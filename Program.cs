// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30// See https://aka.ms/new-console-template for more information

int Recours(int m, int n)                                       // метод находит сумму натуральных элементов в промежутке от M до N
{
    if (m > n) return 0;                                        // условие выхода из рекурсии
    return (m + Recours(m + 1, n));
}

Console.Clear();				                                //  очистка консоли
Console.WriteLine("Введите число m: ");	                        //  запрос первого числа
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");	                        //  запрос второго числа
int n = Convert.ToInt32(Console.ReadLine());
if (n < m)
    Console.WriteLine("Число n должно быть больше числа m.");	                        //  запрос первого числа
else
    Console.WriteLine($"Сумма элементов от {m} до {n} равна {Recours(m, n)}.");
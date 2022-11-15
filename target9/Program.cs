// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
//  числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число больше 1:");
// int n = Convert.ToInt32(Console.ReadLine());

// string NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     else if (number == 0) return " ";
//     Console.Write("{0,4}", number);
//     return NumberCounter (number - 1);
// }
// Console.WriteLine($"{NumberCounter(n)} ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите целое число ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// void NumberSum (int m, int n, int sum)
// {
//     if (m > n) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от m до n: {sum}"); 
//         return;
//     }
//     sum = sum + (m++);
//     NumberSum(m, n, sum);
// }

// NumberSum(m, n, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число n:");
int n = Convert.ToInt32(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");
// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
//  Console.Write ("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// string SumRec(int n)
// {
//     if (n==0) return " ";
//     return SumRec(n-1) + " " + Convert.ToString(n);

// }

// Console.WriteLine($" {SumRec(n)} ");



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     return  n % 10 + SumRec(n/10);
//   }
// Console.WriteLine(SumRec(n));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите целое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Pow(int a, int b)
// {
//     if (b == 0) return 1;
//     return Pow(a,b-1)*a;
//   }
// Console.WriteLine(Pow(a,b));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
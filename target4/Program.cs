﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);
// int razryad=0;
// while (num % 10 >0)
// {
//     razryad++;
//     num/=10;
// }
// Console.WriteLine(razryad);

// void SumNumbers(int num)
// {
//     int razryad=0;
//     while (num % 10 >0)
//     {
//         razryad++;
//         num/=10;
//     }
//     Console.WriteLine(razryad);
// }

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число больше 1");
// int num = Convert.ToInt32(Console.ReadLine());
// int proizv = 1;
// int count = 1;
// while (count < num) 
// {
//     proizv = proizv * (count+1);
//     count++;
// }
// Console.WriteLine(proizv);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
//  и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];

// for (int i=0; i<8; i++)
// {
// array [i] = new Random().Next(0,2);
// Console.Write(array[i]+" ");
// }

// Задача 35: Задайте одномерный массив из 13 случайных чисел от 0 до 100. Найдите количество 
// элементов массива, значения которых лежат в отрезке [40,99].
// int[] CreateFillArray()
// {
//     int[] arr = new int[13];
//     for (int i = 0; i < 13; i++)
//     {
//         arr[i] = new Random().Next(0, 101);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }
// int count = 0;
// int[] arr = CreateFillArray();
// for (int i = 0; i < 13; i++)
// {
//     if (arr[i] >= 40 && arr[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// bool Checktriangle(int a, int b, int c)
// {
//     bool x = false;
//     if ((a + b > c) && (b + c > a) && (a + c > b)) x = true;
//     return x;
// }
// Console.WriteLine(Checktriangle(a, b, c));

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// int n= Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

//     for (int i=0;i<n;i++) 
//     {
//         if (i == 0) array[i]=0;
//         else if (i == 1) array[i]=1;
//         else array[i] = array[i-1]+array[i-2];
//     }

//    void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for ( int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// PrintArray(array);

// Console.WriteLine("Введите пятизначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// CheckPalindrom(x);

// void CheckPalindrom(int x)
// {
//     if (x >= 10000 && x < 100000)
//     {
//         int a = x / 10000;
//         int b = x % 10;
//         int c = ((x / 1000) % 10);
//         int d = ((x % 100) / 10);
//         if (a == b && c == d)
//         {
//             Console.WriteLine("да");
//         }
//         else Console.WriteLine("нет");
//     }
//     else Console.WriteLine("вы ввели недопустимое число");
// }

// void CountNumbers(int num)
// {
//     int razryad = 0;
//     while (num % 10 > 0)
//     {
//         razryad++;
//         num /= 10;
//     }
//     Console.WriteLine(razryad);
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// double b = Convert.ToInt32(Console.ReadLine());
// Vozved(a, b);

// void Vozved(double a, double b)
// {
//     double log = 0;
//     if (b > 0)
//     {
//         log = Math.Pow(a, b);
//         Console.WriteLine(log);
//     }
//     else Console.WriteLine("Введите положительное второе число");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// SumNumbers(x);

// void SumNumbers(int x)
// {
//     int sum = 0;
//     while (x != 0)
//     {
//         sum += x % 10;
//         x = x / 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
int[] array = new int[8];
CreateFillArray(array);

void CreateFillArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}:\t");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < 8; i++) Console.WriteLine(array[i]);
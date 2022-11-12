// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] Fillimageay(int m, int n)
// {
//     int[,] mat = new int[m, n];
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             mat[i, j] = new Random().Next(0, 10);
//         }
//     }
//     Console.WriteLine();
//     return mat;
// }

// void Printimageay(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] mas = Fillimageay(m, n);
// Printimageay(mas);
// Console.WriteLine();


// int[] mas2 = new int[10];
// Newmas(mas2);

// void Newmas(int[] arr)
// {

//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)

//             mas2[mas[i, j]]++;
//     }
// }


// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < mas2.Length - 1; i++)
//     {
//         int minPosition = 1;
//         for (int j = i + 1; j < mas2.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// SelectionSort(mas2);


// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// PrintArray(mas2);

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] Fillimageay(int m, int n)
// {
//     double[,] mat = new double[m, n];
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             mat[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
//         }

//     }
//     Console.WriteLine();
//     return mat;
// }

// void Printimageay(double[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] mas = Fillimageay(m, n);
// Printimageay(mas);
// Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// int[,] mas = new int[3, 4];
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     }
// }

// FillArray(mas);
// PrintArray(mas);

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < mas.GetLength(0); i++)
// {
//     for (int j = 0; j < mas.GetLength(1); j++)
//     {
//         if (mas[i, j] == a) Console.WriteLine($"позиция числа {a}: строка {i + 1}, столбец {j + 1}");
//     }
// }
// if (a < 1 || a > 10)
//     Console.WriteLine("такого числа в массиве нет");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] mas = new int[3, 4];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
}
FillArray(mas);
PrintArray(mas);

void PrintArray(int[,] image)
{
        for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < mas.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        sum += mas[i, j];
    }
    Console.Write($"{Math.Round(sum / mas.GetLength(0),1)}     ");
}
Console.ReadLine();

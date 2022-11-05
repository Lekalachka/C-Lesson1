// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// 
// Console.WriteLine("Введите координату х точки а");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки а");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z точки а");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату х точки b");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки b");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z точки b");
// int bz = Convert.ToInt32(Console.ReadLine());

// Double dist = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));
// Console.WriteLine($"Расстояние между двумя точками равно {dist}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 1;
//     while (count <=x)
//     {
//         Console.Write($"{count*count*count}, ");
//         count++;
//     }

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
int a = x / 10000;
int b = x % 10;
int c = ((x / 1000) % 10);
int d = ((x % 100) / 10);
int razryad = 0;

void CountNumbers(int x)
{
    int razryad = 0;
    while (x % 10 > 0)
    {
        razryad++;
        x /= 10;
    }
    Console.WriteLine(razryad);
}

if (razryad < 5 || razryad>5)
{
    if (a == b && c == d)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
else Console.WriteLine("вы ввели недопустимое число");



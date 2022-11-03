// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// int x1 = x%100;
// int x2 = x1/10;

// Console.WriteLine(x2);

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// // что третьей цифры нет.Через строку решать нельзя.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

Console.WriteLine("введите число = ");
int x = Convert.ToInt32(Console.ReadLine());

if (x>99)
{
   while (x > 999)
    {
       x = (x / 10);
    }  
    x = x % 10;
    Console.WriteLine(x);
}
else Console.WriteLine("Третьей цифры нет");

// int Number = new Random().Next(1, 1500);
// System.Console.WriteLine();
// System.Console.WriteLine($"Дано число: {Number}");

// if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 100 % 10}");
// else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

// System.Console.WriteLine();       

       

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число дня недели от 1 до 7: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < 1 || x > 7)
// {
//     Console.WriteLine("Вы ввели неверное число!");
// }
// else if (x > 5)
// {
//     Console.WriteLine("Да");
// }
// else
//     Console.WriteLine("Нет");
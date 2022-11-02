// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x>y) Console.WriteLine($"max={x}");
// else if (y>x) Console.WriteLine($"max={y}");
// else Console.WriteLine("Числа равны");

// Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int z = Convert.ToInt32(Console.ReadLine());
// int max = x;
// if (y > max) max=y;
// if (z > max) max=z;
// Console.WriteLine(max);

// Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x%2==0) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= x)
{
    if (count % 2 == 0)
    {
        Console.Write(count+", ");
        count++;
    }
    else count++;
}


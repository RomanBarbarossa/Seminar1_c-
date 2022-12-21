// //////// Задача 1: напишите программу, которая принимает на вход два числа и выдает,
//  какое число большее а какое меньшее.
// Console.WriteLine("Введите число 1");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 2");
// int number2 = int.Parse(Console.ReadLine()!);

// if(number1 > number2)
// {
//     Console.WriteLine ($"Число {number1} ,больше числа {number2}");
// }

//     else
//     {
//         Console.WriteLine ($"Число {number2} ,больше числа {number1}");
//     }
// if(number1 == number2)
// {
//     Console.WriteLine ($"Число {number2} ,равно числу {number1}");
// }

/////// задача 2 напишите программу которая принимает на
//  вход три числа и ыдает максимальное из них.

// int Max(int arg1, int arg2, int arg3)
// {
//     int max = arg1;
//     if(arg2 > max) max = arg2;
//     if(arg3 > arg2) max = arg3;
//     return max; 
// } 
// Console.WriteLine("Введите число 1");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 2");
// int number2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 3");
// int number3 = int.Parse(Console.ReadLine()!);
// int max = Max(number1, number2, number3);
// Console.WriteLine($"Максимальное число {max}");

///////// Задача 3 Напишите программу которая на вход принимает число и 
//выдает является ли оно четным.

// Console.WriteLine("Введите число");
// int number1 = int.Parse(Console.ReadLine()!);
// if(number1 % 2 == 0)
// {
//     Console.WriteLine($"Число {number1} является четным");
// }
//     else
//     {
//         Console.WriteLine($"Число {number1} НЕ является четным");
//     }

// ////////////Задача 4
// Напишите программу, которая на вход принимает число (N) ,  
// а на выходе показывает все четные числа от 1 до (N)

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int number0 = 1;
while(number0 <= number)
{
    if(number0 % 2 == 0)
    {
        Console.Write($"{number0}, ");
    }
    number0++;
}

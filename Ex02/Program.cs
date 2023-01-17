/*Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());
int Max = num1;
if (num1 < num2)
    {
        Max = num2;
    }
    else
    {
        Max = num1;
    }
if (Max < num3)
    { 
        Max = num3;
    }
Console.WriteLine(Max+" - максимальное из этих трех введеных чисел");

﻿/* Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите натуральное число : ");
int num = int.Parse(Console.ReadLine());
int counter = 2;
if (num <= 1)
{
    Console.Write("Вы ввели число " + num + ", в нем нет чётных положительных чисел : ");
}
else
{
    Console.Write("Все чётные числа из числа " + num + " в порядке возрастания : ");
}
while (counter <= num)
{
    Console.Write(counter + ", ");
    counter = counter + 2;
}
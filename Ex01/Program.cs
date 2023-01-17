/*Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 == num2)
{
    Console.WriteLine(num1 + " = " + num2 + " - эти числа равны !!!");
}
    else if (num1 > num2)
    {
        Console.WriteLine(num1+ " - это число большее, "+num2+ " - это число меньшее, из введеных Вами чисел");
    }
    else
    {
        Console.WriteLine(num2+ " - это число большее, "+num1+ " - это число меньшее, из введеных Вами чисел");
    }
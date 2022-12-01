/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int B = Convert.ToInt32(Console.ReadLine());

{
if (A > B)
    Console.WriteLine("максимальное значение A");
    
    else
    Console.WriteLine("максимальное значение B");

}
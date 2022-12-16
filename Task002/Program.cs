// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

using static System.Console;

WriteLine("Введите число А - ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число B - ");
int b = int.Parse(ReadLine()!);

WriteLine("Введите число C - ");
int c = int.Parse(ReadLine()!);


if (a>b && a>c) WriteLine($" Число {a} наибольшее");
if (b>a && b>c) WriteLine($" Число {b} наибольшее");
if (c>a && c>b) WriteLine($" Число {c} наибольшее");


// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

using static System.Console;

WriteLine("Введите число А - ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число B - ");
int b = int.Parse(ReadLine()!);

if (a>b) WriteLine($" Число {a} больше числа {b}");
if (a<b) WriteLine($" Число {b} больше числа {a}");
if (a == b) WriteLine($" Число {a} и число {b} равны");

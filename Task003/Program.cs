// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


using static System.Console;

WriteLine("Введите число - ");
int a = int.Parse(ReadLine()!);

if (a%2 == 0) WriteLine($" Число {a} чётное");
else WriteLine($" Число {a}  не чётное");


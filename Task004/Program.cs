// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

using static System.Console;

WriteLine("Введите число - ");

int n = int.Parse(ReadLine()!);
int count = 1;

while (count != n){
    if (count%2 == 0) WriteLine(count);
    count += 1;
}


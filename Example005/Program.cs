/*
1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8

*/

int number = new Random().Next(10, 99);

Console.WriteLine("Number = " + number);

int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.WriteLine("Max number = " + a);
}
else
{
    Console.WriteLine("Max number = " + b);
}


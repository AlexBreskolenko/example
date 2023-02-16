/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Clear();

Console.Write("Enter the first number : ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number : ");
int secondNumber = int.Parse(Console.ReadLine());

if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
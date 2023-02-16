/*
3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.Clear();

Console.Write("Enter the first number : ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number : ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine("Кратно.");
}
else
{
    Console.WriteLine("Не кратно.");
}
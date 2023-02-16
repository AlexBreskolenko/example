/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

//Просим ввести 3 значное число
Console.WriteLine("Введите 3 значное число : ");
string str = Console.ReadLine();

int num = Convert.ToInt32(str);

//Добываем 1 чило
int a = num / 100;
//Добываем 3 число 
int b = num % 10;

//Соединяем 1 и 3 число
int result = a * 10 + b;

Console.WriteLine(result);


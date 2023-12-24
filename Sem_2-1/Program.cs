// 1. Напишите программу, которая принимает на вход
//    трёхзначное число и удаляет вторую цифру этого числа.

Console.WriteLine("Enter number");
int a = int.Parse(Console.RedLine()!);
Console.WriteLine(a / 100 * 10 + a % 10);
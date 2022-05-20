//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.Write("Ведите трехзначное число  ");
int num = int.Parse(Console.ReadLine());
int TwoDigit = num / 10;
int SecondDigit = TwoDigit % 10;
Console.WriteLine(SecondDigit);
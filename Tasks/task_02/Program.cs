//Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.

Console.Write("Ведите число  ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num > 99 ? num.ToString()[2] : "Третьей цифры нет");
Console.ReadKey(true);

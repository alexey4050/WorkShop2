﻿//Задача 10. Напиши программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Задача 10. ");
Console.WriteLine("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString (threeDigitNumber);
{
Console.WriteLine("Вторая цифра этого числа ->" +stringNumber[1]);
}
﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите чило: ");
int number= Convert.ToInt32(Console.ReadLine());
if ((number%2)==0)
{
Console.WriteLine("Число четное");   
}
else Console.WriteLine("Число нечетное");
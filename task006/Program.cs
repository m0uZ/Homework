﻿Console.Write("Введите первое число и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Число четное.");
}
else
{
    Console.WriteLine("Число не четное!");
}

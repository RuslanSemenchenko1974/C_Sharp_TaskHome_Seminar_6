﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double FoundX(double k1, double b1, double k2, double b2)
{
    return (b2-b1)/(k1-k2);
}

Console.Clear();

try
{
Console.WriteLine("Введите k1 : ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1 : ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 : ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 : ");
double b2=Convert.ToDouble(Console.ReadLine());
if (k1==k2) Console.WriteLine("Прямые не пересекаются");
else 
{ 
    double x=FoundX(k1,b1,k2,b2);
    double y=k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке X={String.Format("{0:0.000}", x)} Y={String.Format("{0:0.000}", y)}");
}

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
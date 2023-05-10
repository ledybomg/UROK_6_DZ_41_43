﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Введите значение коэффициента наклона первой прямой: ");
    double k1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение коэффициента смещения первой прямой: ");
    double b1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение коэффициента наклона второй прямой: ");
    double k2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение коэффициента смещения второй прямой: ");
    double b2 = double.Parse(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
  }
}





/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double Getnumber(string message)
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine() ?? "");
    return result;
}

(double, double) PointOfLinesCross(double b1, double k1, double b2, double k2)
{
    double pointX = (b1 - b2) / (k2 - k1);
    double pointY = k2 * pointX + b2;
    return (pointX, pointY);
}

double b1 = Getnumber("Задайте значение параметра b1");
double k1 = Getnumber("Задайте значение параметра k1");
double b2 = Getnumber("Задайте значение параметра b2");
double k2 = Getnumber("Задайте значение параметра k2");
(double x, double y) = PointOfLinesCross(b1, k1, b2, k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} прямые пересекаются в точке с координатами ({x}; {y})");
/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double getUserNumber(string name)
{
    Console.Write(name + " ");
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double[] getIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] intersectionPoint = new double[2];
    intersectionPoint[0] = Math.Round((b1-b2)/(k2-k1), 2);
    intersectionPoint[1] = Math.Round(k1 * intersectionPoint[0] + b1, 2);
    return intersectionPoint;
}

double b1 = getUserNumber("Введите b1: ");
double k1 = getUserNumber("Введите k1: ");
double b2 = getUserNumber("Введите b2: ");
double k2 = getUserNumber("Введите k2: ");
double[] resultIntersectionPoint = getIntersectionPoint(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения прямых = ({resultIntersectionPoint[0]}, {resultIntersectionPoint[1]})");

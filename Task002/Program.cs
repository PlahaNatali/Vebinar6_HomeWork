// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// Получим X: x=(b2 - b1)/(k1 - k2)
// Подставляем: y=k1(b2 - b1)/(k1 - k2)+b1

Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Equation(b1, b2, k1, k2);

void Equation(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    Console.WriteLine($"Точка пересечения двух прямых: ({x} ; {y})");
}
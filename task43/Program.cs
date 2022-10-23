// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double[] DotCross(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] result = { x, y };
    return result;
}

double b1 = PrintAndGetValue("Введите b1 ");
double b2 = PrintAndGetValue("Введите b2 ");
double k1 = PrintAndGetValue("Введите k1 ");
double k2 = PrintAndGetValue("Введите k2 ");

Console.WriteLine("(" + string.Join("; ",DotCross(b1,b2,k1,k2)) + ")");

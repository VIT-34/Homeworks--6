// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}

double b1 = Promt("Введите значение b1 => ");
double k1 = Promt("Введите значение k1 => ");
double b2 = Promt("Введите значение b2 => ");
double k2 = Promt("Введите значение k2 => ");

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x + b1);

Console.WriteLine(( x, y));

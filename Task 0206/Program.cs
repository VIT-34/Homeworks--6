// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int a = Prompt("Введите число, которое определит максимальное количество чисел вводимых пользователем => ");
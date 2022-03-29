// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int a = Prompt("Введите число, которое определит максимальное количество чисел вводимых пользователем => ");

int count = 0;

for(int i = 0; i < a; i++)
{
Console.Write($"Введите число {i+1}: ");
int b = int.Parse(Console.ReadLine());
if(b > 0)
count++;
}
Console.Write($"количество чисел больше 0: {count}");

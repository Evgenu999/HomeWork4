// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

int TwoNumbers(int a, int b)
{
    int multiplication = 1;
    for (int i = 0; i < b; i++)
    {
        multiplication = multiplication * a;
    }
    return multiplication;
}

Console.WriteLine("Input first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input second number: ");
int b = Math.Abs(int.Parse(Console.ReadLine()));

int result = TwoNumbers(a, b);
Console.WriteLine(result);


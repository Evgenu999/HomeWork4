// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumDigits(int number)
{
    int sum = 0;
    int temporary = number;
    while (temporary > 0)
    {
        sum = sum + temporary % 10;
        temporary = temporary / 10;
    }
    return sum;
}

Console.WriteLine("Input number: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

int result = SumDigits(n);
Console.WriteLine($"Сумма цифр в числе {n} равна {result}" );

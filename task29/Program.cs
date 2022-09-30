// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Элементы массива вводятся пользователем.

void PrintArray(int number)
{
    int[] array = new int[number];
    Console.WriteLine("Введите элементы массива по одному: ");
    for(int i = 0; i < number; i++)
    {
        int tmp = int.Parse(Console.ReadLine());
        array[i] = tmp;
    }
    for(int i = 0; i < number; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

PrintArray(size);
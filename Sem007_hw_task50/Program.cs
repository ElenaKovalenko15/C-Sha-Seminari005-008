// На вход принимает позиции элемента в двумерном массиве и возвращает значение этого 
//элемента или указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();
int[,] numbers = new int[7, 7];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
ElementNumber(numbers, m, n);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 20;
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ElementNumber(int[,] array, int m, int n)
{
    if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {m} строки и {n} столбца равно {numbers[m - 1, n - 1]}");
    }
}
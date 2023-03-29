//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int rows = InputValue("Введите количество строк массива: ", "Ошибка ввода!");
int columns = InputValue("Введите количество столбцов массива (больше или меньше, чем введенное количество строк!): ", "Ошибка ввода!");
int min = InputValue("Введите минимальное значение: ", "Ошибка ввода!");
int max = InputValue("Введите максимальное значение: ", "Ошибка ввода!");

int[,] arr = GetArray(rows, columns, min, max);
PrintArray(arr);
Console.WriteLine();

int sumRow = SumRowElements(arr, 0);
int minSumRow = MinSumRow(arr, 0);

Console.WriteLine($"строкa № {minSumRow + 1} - строка с наименьшей суммой элементов, равной {sumRow}");

/////////////////////////////////////////////////////////////////////////

static int InputValue(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
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

int SumRowElements(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

int MinSumRow(int[,] array, int j)
{
    int minSumRow = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumRow = SumRowElements(array, i);
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow = i;
        }
    }
    return minSumRow;
}
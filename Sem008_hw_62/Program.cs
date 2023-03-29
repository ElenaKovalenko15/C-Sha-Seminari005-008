//Задача 62: Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int rows = 4;
int columns = 4;
int[,] arr = GetZeroArr(rows, columns);
PrintArray(arr);
Console.WriteLine();
int[,] spiralArr = SpiralFeelArray(arr);
PrintArray(spiralArr);

int[,] GetZeroArr(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
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

int[,] SpiralFeelArray(int[,] inArray)
{
    int n = 4;
    int[,] result = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return result;
}

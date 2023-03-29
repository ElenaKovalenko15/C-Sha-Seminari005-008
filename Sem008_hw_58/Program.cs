// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц

Console.Clear();

int rowsMatr1 = InputValue("Введите количество строк матрицы 1: ", "Ошибка ввода!");
int columnsMatr1 = InputValue("Введите количество столбцов матрицы 1: ", "Ошибка ввода!");
int minMatr1 = InputValue("Введите минимальное значение матрицы 1: ", "Ошибка ввода!");
int maxMatr1 = InputValue("Введите максимальное значение матрицы 1: ", "Ошибка ввода!");

int rowsMatr2 = InputValue("Введите количество строк матрицы 2: ", "Ошибка ввода!");
int columnsMatr2 = InputValue("Введите количество столбцов матрицы 2: ", "Ошибка ввода!");
int minMatr2 = InputValue("Введите минимальное значение матрицы 2: ", "Ошибка ввода!");
int maxMatr2 = InputValue("Введите максимальное значение матрицы 2: ", "Ошибка ввода!");


int[,] matrixA = GetArray(rowsMatr1, columnsMatr1, minMatr1, maxMatr1);
int[,] matrixB = GetArray(rowsMatr2, columnsMatr2, minMatr2, maxMatr2);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
int[,] matrixC = MatrixCompos(matrixA, matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(matrixC);

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


int[,] MatrixCompos(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(0) != arrB.GetLength(1))
    {
        throw new Exception("Нельзя перемножить! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    int[,] result = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < arrA.GetLength(0); k++)
            {

                result[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }
    return result;
}

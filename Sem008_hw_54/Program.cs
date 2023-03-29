//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int rows = InputValue("Введите количество строк массива: ", "Ошибка ввода!");
int columns = InputValue("Введите количество столбцов массива: ", "Ошибка ввода!");
int min = InputValue("Введите минимальное значение: ", "Ошибка ввода!");
int max = InputValue("Введите максимальное значение: ", "Ошибка ввода!");

int[,] arr = GetArray(rows, columns, min, max);
PrintArray(arr);
Console.WriteLine();
GetSortArray(arr);
PrintArray(arr);

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

void GetSortArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int l = 0; l < arr.GetLength(1) - 1; l++)
      {
        if (arr[i, l] < arr[i, l + 1])
        {
          int temp = arr[i, l + 1];
          arr[i, l + 1] = arr[i, l];
          arr[i, l] = temp;
        }
      }
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
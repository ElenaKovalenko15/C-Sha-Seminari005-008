//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечетных позициях. [3, 7, 23, 12] -> 19

Console.Clear();

int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int arrayMin = GetNumberFromUser("Введите минимальный элемент массива: ", "Ошибка ввода!");
int arrayMax = GetNumberFromUser("Введите максимальный элемент массива: ", "Ошибка ввода!");
int[] array = GetArray(arraySize, arrayMin, arrayMax);

int count = FindEvenSumPositionEl(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> сумма элементов на нечетных позициях = {count}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}


static int GetNumberFromUser(string message, string errorMessage)
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

int FindEvenSumPositionEl(int[] arr)
{
    int count = 0;
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (i % 2 != 0)
        {
            count += array[i];
        }
    }
    return count;
}
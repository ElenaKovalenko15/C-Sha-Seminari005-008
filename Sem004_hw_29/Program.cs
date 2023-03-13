// задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int arraySize = 8;
int arrayMin = GetNumberFromUser("Введите минимальный элемент массива: ", "Ошибка ввода!");
int arrayMax = GetNumberFromUser("Введите максимальный элемент массива: ", "Ошибка ввода!");
int[] array = GetArray(arraySize, arrayMin, arrayMax);;

Console.WriteLine($"[{String.Join(",", array)}]");

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
//программа замены элементов массива: положительные на отр и наоборот.

Console.Clear();

int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int arrayMin = GetNumberFromUser("Введите минимальный элемент массива: ", "Ошибка ввода!");
int arrayMax = GetNumberFromUser("Введите максимальный элемент массива: ", "Ошибка ввода!");
int[] array = GetArray(arraySize, arrayMin, arrayMax);
Console.WriteLine(String.Join(" ", array));
ChangeElements(array);
Console.WriteLine(String.Join(" ", array));

//возвращает массив из size элементов, заполненный случайными числасми из промежутка [minValue, maxValue]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

//меняет знак у элементов массива

void ChangeElements(int[] arr)
{
    //int lenght = array.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
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

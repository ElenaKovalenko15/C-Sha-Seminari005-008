//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.Clear();

int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int arrayMin = GetNumberFromUser("Введите минимальный элемент массива: ", "Ошибка ввода!");
int arrayMax = GetNumberFromUser("Введите максимальный элемент массива: ", "Ошибка ввода!");
int findNumber = GetNumberFromUser("Введите число для поиска в массиве: ", "Ошибка ввода!");
int[] array = GetArray(arraySize, arrayMin, arrayMax);
bool ifFind = FindElement(array, findNumber);
Console.WriteLine($"[{String.Join(" ", array)}] -> {(ifFind?"Да":"Нет")}"); //тернарный оператор



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

bool FindElement(int[] arr, int number)
{
    bool result = false;
    foreach (int num in arr)
    {
        if (num == number)
        {
            result = true;
            break;
        }
        return result;
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




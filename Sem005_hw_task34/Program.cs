//Задайте массив, заполненный случайными положительными трехзначными числамию Напишите программу
//которая покажет количество четных чисел в массиве.

Console.Clear();

int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = GetArray(arraySize, 100, 1000);
int count = FindEvenElements(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {count}");


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

int FindEvenElements(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

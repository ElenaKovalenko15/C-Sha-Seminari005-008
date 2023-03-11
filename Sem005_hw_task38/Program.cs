//Задайте массив вещественных чисел (одномерный). +
//Найдите разницу между максимальным и минимальным элементами массивa.[3 7 22 2 78] -> 76

Console.Clear();

int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
double[] array = GetArray(arraySize);
Console.WriteLine(String.Join(" ", array));

double MaxElement = GetMaxElement(array);
double MinElement = GetMinElement(array);
double Delta = FindDelta(array);

Console.WriteLine($"min el = {MinElement}, max el = {MaxElement} -> разница составляет {Delta}");


double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = (new Random().NextDouble()) * 100;
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

double GetMinElement(double[] arr)
{
    double min = double.MaxValue;
    foreach (double i in arr)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}

double GetMaxElement(double[] arr)
{
    double max = double.MinValue;
    foreach (double i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

double FindDelta(double[] arr)
{
double deltaResualt = 0;
{
    deltaResualt = GetMaxElement(array) - GetMinElement(array);
}
   return deltaResualt;
}
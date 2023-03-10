//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения
//которых лежат в отрезке [10,99].

Console.Clear();

const int sizeArray = 123; //вводим константой размер одномерного массива
int[] array = GetArray(sizeArray, 0, 200); //так же сами ограничиваем мин и макс элементы
int count = FindCountElements(array);
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

int FindCountElements(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num >= 10 && num <= 99)
        {
            count++;
        }
    }
    return count;
}

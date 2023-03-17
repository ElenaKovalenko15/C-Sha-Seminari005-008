//не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два число Ф 0 и 1. 
// если N = 5 -> 01123
// если N = 3 -> 011
// N = 7 -> 0112358

Console.Clear();
int num = GetNumberFromUser("Введите целое положительное число N: ", "Ошибка ввода!");
int [] arrayFibon = GetFibonNumbers(num);
Console.WriteLine($"{num} -> {String.Join(" ", arrayFibon)}");


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetFibonNumbers(int a)
{
    if(a==1)
    return new int[1];
    int[] result = new int[a];
    result[1] = 1;
    for (int i=2; i < a; i++)
    {
        result[i] = result[i -1] + result[i-2];
    }
    return result;
}
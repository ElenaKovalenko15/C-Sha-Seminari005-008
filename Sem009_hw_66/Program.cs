// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int M = GetNumberFromUser("Введите натуральное положительное число: ", "Ошибка ввода!");
int N = GetNumberFromUser("Введите натуральное положительное число, которое больше введенного ранее: ", "Ошибка ввода!");

//NaturalSum(M,N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} -> {NaturalSum(M, N)}");

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

int NaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalSum(m, n - 1);
}
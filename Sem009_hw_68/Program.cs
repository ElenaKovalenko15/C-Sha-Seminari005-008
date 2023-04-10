// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//Она принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число, 
//обозначается A(n,m)

Console.Clear();

int m = GetNumberFromUser("Введите натуральное положительное число: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите натуральное положительное число: ", "Ошибка ввода!");

Console.WriteLine($"А({m},{n}) -> {AkkermanFunction(m, n)}");

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

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunction(m - 1, 1);
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
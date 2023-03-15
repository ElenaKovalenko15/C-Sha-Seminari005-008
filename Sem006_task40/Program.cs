// принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

Console.Clear();

int A = GetNumberFromUser("Введите длину первой стороны: ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите длину второй стороны: ", "Ошибка ввода!");
int C = GetNumberFromUser("Введите длину третьей стороны: ", "Ошибка ввода!");
bool isTringle = IsTringle(A, B, C);
Console.WriteLine(isTringle? "Да" : "Нет");


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

bool IsTringle(int a, int b, int c)
{
    return (a + b > c && a + c > b && c + b > a);
}
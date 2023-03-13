// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

  int numberA = GetNumberFromUser("Введите число A: ", "Ошибка ввода!");
  int numberB = GetNumberFromUser("Введите число B: ", "Ошибка ввода!");

  int exponent = Exponent(numberA, numberB);
  Console.WriteLine($"Ответ: {exponent}");

  int Exponent(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
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
// принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int numberN = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе {sumNumber}");

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
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

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

Console.WriteLine($"Введите размер массива x * y * z:");
int x = ReadNumber("Введите x: ");
int y = ReadNumber("Введите y: ");
int z = ReadNumber("Введите z: ");
Console.WriteLine();


int[,,] array3D = new int[x, y, z];
FeelArray(array3D);
PrintArray(array3D);

static int ReadNumber(string Message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.Write(Message);
            n = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        { Console.WriteLine("Ошибка ввода"); }
    }
    return n;
}

void PrintArray (int[,,] arrXYZ)
{
  for (int i = 0; i < arrXYZ.GetLength(0); i++)
  {
    for (int j = 0; j < arrXYZ.GetLength(1); j++)
    {
      Console.Write($"x({i}) y({j}) ");
      for (int k = 0; k < arrXYZ.GetLength(2); k++)
      {
        Console.Write( $"z({k})={arrXYZ[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FeelArray(int[,,] arrXYZ)
{
  int[] temp = new int[arrXYZ.GetLength(0) * arrXYZ.GetLength(1) * arrXYZ.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrXYZ.GetLength(0); x++)
  {
    for (int y = 0; y < arrXYZ.GetLength(1); y++)
    {
      for (int z = 0; z < arrXYZ.GetLength(2); z++)
      {
        arrXYZ[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
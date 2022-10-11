// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите количество строк для первой матрицы: ");
int firstrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для первой матрицы: ");
int firstcolumn = Convert.ToInt32(Console.ReadLine());
int[,] firstmatrix = new int[firstrows, firstcolumn];
Console.WriteLine("Введите количество строк для второй матрицы: ");
int secondrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для второй матрицы: ");
int secondcolumn = Convert.ToInt32(Console.ReadLine());
int[,] secondmatrix = new int[secondrows, secondcolumn];
int [,] result = new int [firstrows, secondcolumn];
void MultiplicationMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int multi = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        multi += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      result[i,j] = multi;
    }
  }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

FillArrayRandom (firstmatrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstmatrix);
System.Console.WriteLine();
FillArrayRandom (secondmatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondmatrix);
System.Console.WriteLine();
MultiplicationMatrix(firstmatrix, secondmatrix, result);
Console.WriteLine($"Произведение матриц: ");
PrintArray(result);
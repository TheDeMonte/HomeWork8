// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
if (rows > column || rows < column)
{
    System.Console.WriteLine("Введено неверное значение");
}
else
{

    int[,] arr = new int[rows, column];
    int SumRows = default;
    int minRow = default;
    // int sumLine = SumLineElements(array, 0);

    // for (int i = 1; i < arr.GetLength(0); i++)
    // {
    //   int tempSumLine = SumLineElements(array, i);
    //   if (sumLine > tempSumLine)
    //   {
    //     sumLine = tempSumLine;
    //     minSumLine = i;
    //   }
    // }

    // 
    void FindMinRow(int[,] arr, int min)
    {
        int minRow = 1;
        int sumrow = SumRowsElem(arr, 0);
        for (int i = 1; i < arr.GetLength(0); i++)
        {
            int tempSum = SumRowsElem(arr, i);
            if (sumrow > tempSum)
            {
                sumrow = tempSum;
                minRow = i+1;
            }
        }
        System.Console.WriteLine($"Строка {minRow} является наименьшей, сумма элементов этой строки = {sumrow}");
    }
    int SumRowsElem(int[,] arr, int i)
    {
        int sumrows = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            sumrows += arr[i, j];
        }
        return sumrows;
    }

    void FillArrayRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt32(new Random().Next(0, 100));
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

    FillArrayRandom(arr);
    PrintArray(arr);
    SumRowsElem(arr, SumRows);
    FindMinRow(arr, minRow);
}
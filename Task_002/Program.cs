// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс строки: ");
int userRowValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int userColumnValue = Convert.ToInt32(Console.ReadLine());

//--------------------------------------------------------------------------------------------------

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

//---------------------------------------------------------------------------------------------------

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//---------------------------------------------------------------------------------------------------

void FindPosition(int[,] findPosition, int findRowValue, int findColumnValue)
{
    bool find = false;
    for (int i = 0; i < findPosition.GetLength(0); i++)
    {
        for (int j = 0; j < findPosition.GetLength(1); j++)
        {
            if (i == findRowValue && j == findColumnValue) 
            {
            Console.WriteLine($"Значением элемента {i} строки и {j} столбца является -> {findPosition[i - 1, j - 1]}");
            find = true;
            }
        }
    }
    if (!find) Console.Write($"Такого значения в массиве нет!");
}

//---------------------------------------------------------------------------------------------------

int[,] getArray = GetMatrix(rows, columns, minValue, maxValue);
PrintMatrix(getArray);
FindPosition(getArray, userRowValue, userColumnValue);


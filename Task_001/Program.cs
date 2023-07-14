// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


double[,] getArray = GetMatrix(rows, columns, minValue, maxValue);
PrintMatrix(getArray);

//-----------------------------------------------------------------------------------------------------------------------

double[,] GetMatrix(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random rand = new Random();
            matrix[i, j] = rand.Next(min, max) + rand.NextDouble();
        }
    }
    return matrix;
}

//----------------------------------------------------------------------------------------------------------------------

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:F1}\t");
        }
        Console.WriteLine();
    }
}

//----------------------------------------------------------------------------------------------------------------------
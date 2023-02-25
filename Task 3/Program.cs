//В прямоугольной матрице найти строку с наименьшей суммой элементов.

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }

    }
    return matrix;
}

void SumStringsMatrix(int[,] matrix)
{
    int sumRow = 0;
    int minRow = 0;
    int minSumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{minSumRow + 1} строка");

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();

    }
}
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
SumStringsMatrix(matrix);
Console.WriteLine();
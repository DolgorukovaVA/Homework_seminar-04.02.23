// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] SortRowAscending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;    
            }
            int temp = array[i, j];                                          
            array[i, j] = array[i, minPosition];                            
            array[i, minPosition] = temp;                                    
        }

    }
    return array;
}

void PrintTable(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int row = 5;
int col = 6;
int min = 10;
int max = 100;

int[,] table = GetMatrix(row, col, min, max);
PrintTable(table);

Console.WriteLine();
int[,] rowSort = SortRowAscending(table);
PrintTable(rowSort);

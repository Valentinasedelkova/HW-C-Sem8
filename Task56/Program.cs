// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = {
            { 5, 9, 3, 1 },
            { 8, 4, 2, 7 },
            { 6, 0, 2, 3 }
        };

void PrintArray(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintRow(int[,] matrix, int rowIndex)
    {
        int columns = matrix.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[rowIndex, j] + " ");
        }
        Console.WriteLine();
    }

int FindRowWithMinSum(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }

Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
int minSumRowIndex = FindRowWithMinSum(matrix);
Console.WriteLine("Строка с наименьшей суммой элементов:");
PrintRow(matrix, minSumRowIndex);

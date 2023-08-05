// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderRowsDescending(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                row[j] = matrix[i, j];
            }

            Array.Sort(row, (a, b) => b.CompareTo(a));

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = row[j];
            }
        }
    }

Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
OrderRowsDescending(matrix);
Console.WriteLine("Массив после упорядочивания:");
PrintArray(matrix);

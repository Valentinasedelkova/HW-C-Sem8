// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

int[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

int rows1 = matrix1.GetLength(0);
int cols1 = matrix1.GetLength(1);
int rows2 = matrix2.GetLength(0);
int cols2 = matrix2.GetLength(1);

int[,] resultMatrix = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{

    for (int j = 0; j < cols2; j++)
    {
        for (int k = 0; k < cols1; k++)
        {
            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

 Console.WriteLine("Результат умножения двух матриц:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }


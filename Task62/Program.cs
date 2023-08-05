// Напишите программу, которая заполнит спирально массив 4 на 4.

void Array4x4()
{
    int n = 4;
    int[,] spiralArray = new int[n, n];

    int value = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (value <= n * n)
    {

        for (int i = colStart; i <= colEnd; i++)
        {
            spiralArray[rowStart, i] = value;
            value++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralArray[i, colEnd] = value;
            value++;
        }
        colEnd--;
        for (int i = colEnd; i >= colStart; i--)
        {
            spiralArray[rowEnd, i] = value;
            value++;
        }
        rowEnd--;
        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralArray[i, colStart] = value;
            value++;
        }
        colStart++;
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{spiralArray[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

Array4x4();

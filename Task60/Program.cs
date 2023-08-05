// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


 int[,,] threeDimensionalArray = new int[3, 4, 5];
        int value = 10;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    threeDimensionalArray[i, j, k] = value;
                    value++;
                }
            }
        }

 void GetMassive (int [,,] massive)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine($"threeDimensionalArray[{i}, {j}, {k}] = {threeDimensionalArray[i, j, k]}");
                }
            }
        }
    }

    GetMassive(threeDimensionalArray);